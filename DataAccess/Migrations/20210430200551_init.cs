using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "baseConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxRateForKDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxRateForAccommodation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyAdultFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyGuestFeeForRoom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyChildFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccommodationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BreakfastPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DinnerPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baseConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    TypeOfGuest = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentSerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Days = table.Column<byte>(type: "tinyint", nullable: false),
                    Children = table.Column<byte>(type: "tinyint", nullable: false),
                    ChildrenWithFee = table.Column<byte>(type: "tinyint", nullable: false),
                    Adult = table.Column<byte>(type: "tinyint", nullable: false),
                    GuestTotal = table.Column<byte>(type: "tinyint", nullable: false),
                    ReservationNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationType = table.Column<byte>(type: "tinyint", nullable: false),
                    BoardType = table.Column<byte>(type: "tinyint", nullable: true),
                    Breakfast = table.Column<bool>(type: "bit", nullable: false),
                    Lunch = table.Column<bool>(type: "bit", nullable: false),
                    Dinner = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dirty = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonTotal = table.Column<byte>(type: "tinyint", nullable: false),
                    DoubleBed = table.Column<byte>(type: "tinyint", nullable: false),
                    SingleBed = table.Column<byte>(type: "tinyint", nullable: false),
                    Price1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuestReservation",
                columns: table => new
                {
                    GuestsId = table.Column<int>(type: "int", nullable: false),
                    ReservationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestReservation", x => new { x.GuestsId, x.ReservationsId });
                    table.ForeignKey(
                        name: "FK_GuestReservation_Guests_GuestsId",
                        column: x => x.GuestsId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestReservation_Reservations_ReservationsId",
                        column: x => x.ReservationsId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalKdv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAccommodationTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TheExtrasPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyAdultFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyGuestFeeForRoom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyChildFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccommodationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BreakfastPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DinnerPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDailyAdultFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDailyGuestFeeForRoom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalChildFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRoomFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAccommodationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBreakFastFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalLunchFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDinnerFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReservationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservationRoom",
                columns: table => new
                {
                    ReservationsId = table.Column<int>(type: "int", nullable: false),
                    RoomsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationRoom", x => new { x.ReservationsId, x.RoomsId });
                    table.ForeignKey(
                        name: "FK_ReservationRoom_Reservations_ReservationsId",
                        column: x => x.ReservationsId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationRoom_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Active", "Description", "Dirty", "DoubleBed", "InsertDateTime", "Name", "PersonTotal", "Price1", "Price2", "Price3", "Price4", "SingleBed", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, true, null, false, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 107, DateTimeKind.Local).AddTicks(8191), "102", (byte)2, 100m, null, null, null, (byte)2, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(5493) },
                    { 2, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7669), "103", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7676) },
                    { 3, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7927), "104", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7929) },
                    { 4, true, null, false, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7931), "105", (byte)1, 80m, null, null, null, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7932) },
                    { 5, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7935), "106", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7936) },
                    { 6, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7937), "107", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7939) },
                    { 7, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7941), "108", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7942) },
                    { 8, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7944), "109", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7945) },
                    { 9, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7947), "110", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7948) },
                    { 10, true, null, false, (byte)1, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7949), "101", (byte)2, 100m, null, null, null, (byte)0, new DateTime(2021, 4, 30, 23, 5, 51, 108, DateTimeKind.Local).AddTicks(7950) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuestReservation_ReservationsId",
                table: "GuestReservation",
                column: "ReservationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRoom_RoomsId",
                table: "ReservationRoom",
                column: "RoomsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "baseConfigurations");

            migrationBuilder.DropTable(
                name: "GuestReservation");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ReservationRoom");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
