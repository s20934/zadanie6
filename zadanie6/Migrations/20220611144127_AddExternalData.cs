using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace zadanie6.Migrations
{
    public partial class AddExternalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 3, "Na chore oczy", "Wziewy", "Jakis tam zilowoy" },
                    { 4, "Na chore oczy", "Plastry", "Jakis tam zilowoy" },
                    { 5, "Na chore oczy", "Tabletki", "Jakis tam zilowoy" }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDay",
                value: new DateTime(2022, 6, 11, 14, 41, 26, 874, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDay",
                value: new DateTime(2022, 6, 11, 14, 41, 26, 874, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 2, 1, "cos tam", 2 });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 6, 11, 14, 41, 26, 876, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 6, 11, 14, 41, 26, 890, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 3, 1, "cos tam", 2 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 4, 1, "cos tam", 2 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 5, 1, "cos tam", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 5);

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
    }
}
