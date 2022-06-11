using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace zadanie6.Migrations
{
    public partial class AddTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDay",
                value: new DateTime(2022, 6, 11, 14, 20, 41, 632, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDay",
                value: new DateTime(2022, 6, 11, 14, 20, 41, 632, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 6, 11, 14, 20, 41, 633, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 6, 11, 14, 20, 41, 645, DateTimeKind.Utc).AddTicks(8270));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDay",
                value: new DateTime(2022, 6, 11, 11, 36, 9, 332, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDay",
                value: new DateTime(2022, 6, 11, 11, 36, 9, 332, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 6, 11, 11, 36, 9, 333, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 6, 11, 11, 36, 9, 362, DateTimeKind.Utc).AddTicks(3413));
        }
    }
}
