using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 911, DateTimeKind.Local).AddTicks(6663), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5425), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5679), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5684), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5687), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5739), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5742), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5746), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5748), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5751), new DateTime(2021, 5, 1, 14, 3, 7, 912, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.InsertData(
                table: "baseConfigurations",
                columns: new[] { "Id", "AccommodationFee", "Active", "BreakfastPrice", "CompanyName", "DailyAdultFee", "DailyChildFee", "DailyGuestFeeForRoom", "DinnerPrice", "InsertDateTime", "LunchPrice", "TaxRateForAccommodation", "TaxRateForKDV", "UpdateDateTime" },
                values: new object[] { 1, 100m, true, 30m, "Hotel Manager Core", 110m, 60m, 0m, 50m, new DateTime(2021, 5, 1, 14, 3, 7, 913, DateTimeKind.Local).AddTicks(5742), 35m, 1m, 18m, new DateTime(2021, 5, 1, 14, 3, 7, 913, DateTimeKind.Local).AddTicks(5751) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "baseConfigurations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 107, DateTimeKind.Local).AddTicks(8191), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7669), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7927), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7931), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7935), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7937), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7941), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7944), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7947), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7949), new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7950) });
        }
    }
}
