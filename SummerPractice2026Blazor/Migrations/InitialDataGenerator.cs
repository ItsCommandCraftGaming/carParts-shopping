namespace SummerPractice2026Blazor.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

public class InitialDataGenerator
{
  internal static void AddInitialData(ref MigrationBuilder migrationBuilder)
  {
    migrationBuilder.InsertData(
      table: "Articles",
      columns: new[] { "Id", "Name", "Price", "Description", "SpecialTag", "ArticleCategoryId", "ImageUrl" },
      values: new object[,]
      {
        { new Guid("e2f6708a-9a88-42cc-ad5e-32a7e9948ba6"), "Oil Filter", 19.90m, "For filtering engine oil.", "Best Seller", new Guid("7e5f5f7f-c9d2-4c5c-a3e1-3384be8fabf8"), "images/article/oil-filter.jpg" },
        { new Guid("e2f2052a-1e0d-4616-a49e-e4b0f25af1ac"), "Air Filter", 21.90m, "Ensures clean air intake for the engine.", "Top Rated", new Guid("7e5f5f7f-c9d2-4c5c-a3e1-3384be8fabf8"), "images/article/air-filter.jpg" },
        { new Guid("4ddb47f6-e376-4f1f-9f7e-b6622f739f6d"), "Spark Plug", 12.50m, "Reliable ignition for gasoline engines.", "Hot Deal", new Guid("7e5f5f7f-c9d2-4c5c-a3e1-3384be8fabf8"), "images/article/spark-plug.jpg" },
        { new Guid("3f2617f0-1946-4f4e-98d4-c7a7e9f7ed9a"), "Timing Belt Kit", 89.90m, "Complete kit for timing system replacement.", "Premium", new Guid("7e5f5f7f-c9d2-4c5c-a3e1-3384be8fabf8"), "images/article/timing-belt-kit.jpg" },
        { new Guid("8e5dcb22-0ebf-4f4a-9eef-db75dbc9f0da"), "Head Gasket", 39.90m, "Seals the cylinder head to the engine block.", "Latest Product", new Guid("7e5f5f7f-c9d2-4c5c-a3e1-3384be8fabf8"), "images/article/head-gasket.jpg" },

        { new Guid("e4f0d52f-0e79-432d-86d6-11dc0f2362ac"), "Brake Pad", 34.90m, "Front axle brake pad set.", "Best Seller", new Guid("81d67dc2-0d81-4406-b5fb-7a2d434da254"), "images/article/brake-pad.jpg" },
        { new Guid("d95b32c1-bd67-4258-b90c-f64966f8f5c6"), "Brake Disc", 54.90m, "Ventilated brake disc.", "Top Rated", new Guid("81d67dc2-0d81-4406-b5fb-7a2d434da254"), "images/article/brake-disc.jpg" },
        { new Guid("f4c44c4a-d1f4-4b85-a6fd-f545f82ff7f3"), "Brake Caliper", 79.90m, "Refurbished front brake caliper.", "Hot Deal", new Guid("81d67dc2-0d81-4406-b5fb-7a2d434da254"), "images/article/brake-caliper.jpg" },
        { new Guid("35f7d7de-d0ec-4e9f-9dc0-f11ec35f6073"), "Brake Fluid", 11.90m, "DOT4 brake fluid, 1L.", "Value Pick", new Guid("81d67dc2-0d81-4406-b5fb-7a2d434da254"), "images/article/brake-fluid.jpg" },
        { new Guid("8f866f74-9e95-4c57-b995-73f6a4fd2249"), "Brake Hose", 18.90m, "Braided steel brake hose.", "Latest Product", new Guid("81d67dc2-0d81-4406-b5fb-7a2d434da254"), "images/article/brake-hose.jpg" },

        { new Guid("5898f34d-1f7f-4f09-a20f-d40a5f131e4e"), "Control Arm", 49.90m, "Front lower control arm.", "Best Seller", new Guid("fd0074cf-cdc8-45b8-a9e4-1d18ddf12bde"), "images/article/control-arm.jpg" },
        { new Guid("c213f1b3-bf6f-4b69-ba67-2c3194c7677f"), "Ball Joint", 16.90m, "Steering tie-rod ball joint.", "Top Rated", new Guid("fd0074cf-cdc8-45b8-a9e4-1d18ddf12bde"), "images/article/ball-joint.jpg" },
        { new Guid("bf4bdd76-bd11-4d95-93f7-c9048f4d8f8e"), "Stabilizer Link", 22.90m, "Front stabilizer link.", "New Arrival", new Guid("fd0074cf-cdc8-45b8-a9e4-1d18ddf12bde"), "images/article/stabilizer-link.jpg" },
        { new Guid("ea5afd16-f26f-4b1b-b1d8-bc0b56f08d5c"), "Wheel Bearing", 41.90m, "Front wheel bearing kit.", "Hot Deal", new Guid("fd0074cf-cdc8-45b8-a9e4-1d18ddf12bde"), "images/article/wheel-bearing.jpg" },
        { new Guid("ec58690d-f945-45ce-b8d6-7eefd47df8f5"), "Shock Absorber", 59.90m, "Gas-filled shock absorber.", "Premium", new Guid("fd0074cf-cdc8-45b8-a9e4-1d18ddf12bde"), "images/article/shock-absorber.jpg" },

        { new Guid("ed891f8f-a02e-4419-b42e-c8e56a03d5cb"), "Battery", 99.90m, "12V starter battery.", "Best Seller", new Guid("a37484b6-272b-4a6a-8dd0-1e9a20636f1f"), "images/article/battery.jpg" },
        { new Guid("93cbb5c3-f2ec-4e1f-887a-a1e50e5ccd44"), "Alternator", 149.90m, "Refurbished alternator.", "Premium", new Guid("a37484b6-272b-4a6a-8dd0-1e9a20636f1f"), "images/article/alternator.jpg" },
        { new Guid("5967d188-07ef-4136-a97c-278f57cd7c70"), "Starter Motor", 129.90m, "High-torque starter motor.", "Top Rated", new Guid("a37484b6-272b-4a6a-8dd0-1e9a20636f1f"), "images/article/starter-motor.jpg" },
        { new Guid("f2df3903-9ac1-4fbc-aad9-a840f4d7a43b"), "Relay", 9.90m, "12V universal relay.", "Value Pick", new Guid("a37484b6-272b-4a6a-8dd0-1e9a20636f1f"), "images/article/relay.jpg" },
        { new Guid("db19daf8-4c8d-4962-9734-2430f44f8afe"), "Sensors", 29.90m, "General engine and system sensors.", "New Arrival", new Guid("a37484b6-272b-4a6a-8dd0-1e9a20636f1f"), "images/article/sensors.jpg" }
      });
  }
}
