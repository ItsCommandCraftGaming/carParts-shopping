using Microsoft.JSInterop;
using System.Text.Json;
using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Services
{
    public class CartItem
    {
        public Article Article { get; set; } = null!;
        public int Quantity { get; set; }
    }

    public class CartService(IJSRuntime jsRuntime)
    {
        private readonly IJSRuntime _jsRuntime = jsRuntime;
        private List<CartItem> _items = new();
        private const string LocalStorageKey = "shopping_cart";
        private bool _isInitialized = false;

        public event Action? OnCartChanged;

        public IReadOnlyList<CartItem> GetItems() => _items.AsReadOnly();

        public async Task InitializeAsync()
        {
            if (_isInitialized) return;
            try
            {
                var json = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", LocalStorageKey);
                if (!string.IsNullOrEmpty(json))
                {
                    _items = JsonSerializer.Deserialize<List<CartItem>>(json) ?? new List<CartItem>();
                }
                _isInitialized = true;
                NotifyCartChanged();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CartService] Error loading cart from localStorage: {ex.Message}");
            }
        }

        public async Task AddToCartAsync(Article article, int quantity = 1)
        {
            await InitializeAsync();
            var existingItem = _items.FirstOrDefault(i => i.Article.Id == article.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _items.Add(new CartItem { Article = article, Quantity = quantity });
            }
            NotifyCartChanged();
            await SaveToLocalStorageAsync();
        }

        public async Task RemoveFromCartAsync(Guid articleId)
        {
            await InitializeAsync();
            var existingItem = _items.FirstOrDefault(i => i.Article.Id == articleId);
            if (existingItem != null)
            {
                _items.Remove(existingItem);
                NotifyCartChanged();
                await SaveToLocalStorageAsync();
            }
        }

        public async Task UpdateQuantityAsync(Guid articleId, int quantity)
        {
            await InitializeAsync();
            var existingItem = _items.FirstOrDefault(i => i.Article.Id == articleId);
            if (existingItem != null)
            {
                if (quantity <= 0)
                {
                    _items.Remove(existingItem);
                }
                else
                {
                    existingItem.Quantity = quantity;
                }
                NotifyCartChanged();
                await SaveToLocalStorageAsync();
            }
        }

        public async Task ClearCartAsync()
        {
            _items.Clear();
            NotifyCartChanged();
            await SaveToLocalStorageAsync();
        }

        public int GetTotalItemsCount() => _items.Sum(i => i.Quantity);

        public decimal GetTotalPrice() => _items.Sum(i => i.Article.Price * i.Quantity);

        private void NotifyCartChanged() => OnCartChanged?.Invoke();

        private async Task SaveToLocalStorageAsync()
        {
            try
            {
                var json = JsonSerializer.Serialize(_items);
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", LocalStorageKey, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CartService] Error saving cart to localStorage: {ex.Message}");
            }
        }
    }
}
