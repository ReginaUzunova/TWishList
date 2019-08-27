using Microsoft.EntityFrameworkCore.Migrations;

namespace TWishList.Data.Migrations
{
    public partial class ModifiedCompanyRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TravelCompanies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelCompanies_CompanyRequests_CompanyRequestId",
                table: "TravelCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelCompanies_Countries_CountryId",
                table: "TravelCompanies");

            migrationBuilder.DropIndex(
                name: "IX_TravelCompanies_CompanyRequestId",
                table: "TravelCompanies");

            migrationBuilder.DropIndex(
                name: "IX_TravelCompanies_CountryId",
                table: "TravelCompanies");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "CompanyRequestId",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "CompanyWebsite",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "LiablePerson",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "UniqueIdentifier",
                table: "TravelCompanies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyLiablePerson",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyPhoneNumber",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyUniqueIdentifier",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyWebsite",
                table: "CompanyRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "CompanyRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TravelCompanies_RequestId",
                table: "TravelCompanies",
                column: "RequestId",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_TravelCompanies_CompanyRequests_RequestId",
                table: "TravelCompanies",
                column: "RequestId",
                principalTable: "CompanyRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRequests_Countries_CountryId",
                table: "CompanyRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelCompanies_CompanyRequests_RequestId",
                table: "TravelCompanies");

            migrationBuilder.DropIndex(
                name: "IX_TravelCompanies_RequestId",
                table: "TravelCompanies");

            migrationBuilder.DropIndex(
                name: "IX_CompanyRequests_CountryId",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CompanyLiablePerson",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CompanyPhoneNumber",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CompanyUniqueIdentifier",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CompanyWebsite",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "CompanyRequests");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompanyRequestId",
                table: "TravelCompanies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyWebsite",
                table: "TravelCompanies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LiablePerson",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueIdentifier",
                table: "TravelCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelCompanies_CompanyRequestId",
                table: "TravelCompanies",
                column: "CompanyRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelCompanies_CountryId",
                table: "TravelCompanies",
                column: "CountryId");

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
                name: "FK_TravelCompanies_CompanyRequests_CompanyRequestId",
                table: "TravelCompanies",
                column: "CompanyRequestId",
                principalTable: "CompanyRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelCompanies_Countries_CountryId",
                table: "TravelCompanies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
