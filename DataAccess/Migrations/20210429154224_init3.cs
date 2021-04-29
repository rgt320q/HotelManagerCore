using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "GuestTotal",
                table: "Reservations",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "ChildrenWithFee",
                table: "Reservations",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Children",
                table: "Reservations",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Adult",
                table: "Reservations",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 720, DateTimeKind.Local).AddTicks(4706), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(3755), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4022), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4028), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4030), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4034), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4036), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4039), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4042), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4044), new DateTime(2021, 4, 29, 18, 42, 23, 721, DateTimeKind.Local).AddTicks(4045) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GuestTotal",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "ChildrenWithFee",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "Children",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "Adult",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 603, DateTimeKind.Local).AddTicks(5291), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(7644), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8052), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8059), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8064), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8068), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8072), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8076), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8081), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8085), new DateTime(2021, 4, 28, 13, 58, 19, 604, DateTimeKind.Local).AddTicks(8086) });
        }
    }
}
