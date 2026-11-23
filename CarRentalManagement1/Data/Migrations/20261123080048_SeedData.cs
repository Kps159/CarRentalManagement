using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Vehicle",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Vehicle",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Vehicle",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Model",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Model",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Model",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Make",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Make",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Make",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Customer",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Customer",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Colour",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Colour",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Colour",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Booking",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Booking",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Booking",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Black", "System" },
                    { 2, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "BMW", "System" },
                    { 2, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "i4", "System" },
                    { 2, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "X5", "System" },
                    { 3, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Prius", "System" },
                    { 4, "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Vehicle",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Vehicle",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicle",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Model",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Model",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Model",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Make",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Make",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Make",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Customer",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Customer",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Colour",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Colour",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colour",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Booking",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Booking",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Booking",
                newName: "id");
        }
    }
}
