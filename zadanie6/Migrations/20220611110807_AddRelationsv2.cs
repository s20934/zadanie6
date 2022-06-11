using Microsoft.EntityFrameworkCore.Migrations;

namespace zadanie6.Migrations
{
    public partial class AddRelationsv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_IdPateint",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_IdPateint",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "IdPateint",
                table: "Prescriptions");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_IdPatient",
                table: "Prescriptions",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicaments_IdMedicament",
                table: "Prescription_Medicaments",
                column: "IdMedicament");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicaments_Medicaments_IdMedicament",
                table: "Prescription_Medicaments",
                column: "IdMedicament",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicaments_Prescriptions_IdPrescription",
                table: "Prescription_Medicaments",
                column: "IdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_IdPatient",
                table: "Prescriptions",
                column: "IdPatient",
                principalTable: "Patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicaments_Medicaments_IdMedicament",
                table: "Prescription_Medicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicaments_Prescriptions_IdPrescription",
                table: "Prescription_Medicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_IdPatient",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_IdPatient",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_Medicaments_IdMedicament",
                table: "Prescription_Medicaments");

            migrationBuilder.AddColumn<int>(
                name: "IdPateint",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_IdPateint",
                table: "Prescriptions",
                column: "IdPateint");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_IdPateint",
                table: "Prescriptions",
                column: "IdPateint",
                principalTable: "Patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
