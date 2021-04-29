using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Active", "Description", "Dirty", "DoubleBed", "InsertDateTime", "Name", "PersonTotal", "Price1", "Price2", "Price3", "Price4", "SingleBed", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, true, null, false, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 603, DateTimeKind.Local).AddTicks(5291), "102", (byte)2, 100m, null, null, null, (byte)2, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(4971) },
                    { 2, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(7644), "103", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(7652) },
                    { 3, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8052), "104", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8056) },
                    { 4, true, null, false, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8059), "105", (byte)1, 80m, null, null, null, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8061) },
                    { 5, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8064), "106", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8065) },
                    { 6, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8068), "107", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8070) },
                    { 7, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8072), "108", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8074) },
                    { 8, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8076), "109", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8078) },
                    { 9, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8081), "110", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8082) },
                    { 10, true, null, false, (byte)1, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8085), "101", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8086) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
