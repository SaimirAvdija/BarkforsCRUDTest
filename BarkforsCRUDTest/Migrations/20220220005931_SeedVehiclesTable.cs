using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkforsCRUDTest.Migrations
{
    public partial class SeedVehiclesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "LicencePlateNumber", "ModelName", "TypeOfFuel", "VehicleColor", "VehicleEquipment" },
                values: new object[] { 1, 0, 1, "A1", 0, 0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
