using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TWishList.Data.Migrations
{
    public partial class ModifiedCompanyRequestAndTravelCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRequests_Countries_CountryId",
                table: "CompanyRequests");

            migrationBuilder.DropIndex(
                name: "IX_CompanyRequests_CountryId",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "UniqueIdentifier",
                table: "CompanyRequests");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "TravelCompanies",
                newName: "LiablePerson");

            migrationBuilder.RenameColumn(
                name: "CompanyWebsite",
                table: "CompanyRequests",
                newName: "UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "TravelCompanies",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CompanyRequests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelCompanies_IsDeleted",
                table: "TravelCompanies",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRequests_UserId",
                table: "CompanyRequests",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                unique: true,
                filter: "[CompanyId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TravelCompanies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "TravelCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyRequests_AspNetUsers_UserId",
                table: "CompanyRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TravelCompanies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRequests_AspNetUsers_UserId",
                table: "CompanyRequests");

            migrationBuilder.DropIndex(
                name: "IX_TravelCompanies_IsDeleted",
                table: "TravelCompanies");

            migrationBuilder.DropIndex(
                name: "IX_CompanyRequests_UserId",
                table: "CompanyRequests");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LiablePerson",
                table: "TravelCompanies",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CompanyRequests",
                newName: "CompanyWebsite");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyWebsite",
                table: "CompanyRequests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueIdentifier",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRequests_CountryId",
                table: "CompanyRequests",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyRequests_Countries_CountryId",
                table: "CompanyRequests",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
