using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "1542b9df-06d1-4b26-97ea-2e79e5d4ac14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "be279c6e-e6e0-4296-9fc0-55f0668453f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e04f34fd-6692-4a91-a25d-0272e837199b", "AQAAAAEAACcQAAAAELR/XyX+IfaBie/ePlYqzoHutc9Flj5gu7MFDEm+zqYGxgVpAwRPMiwxFhXDiSvArA==", "4be21c96-b2d9-4153-9ff8-d9f99bff6179" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d4fe030-6b1a-4658-9134-22d0a5ffe45d", "AQAAAAEAACcQAAAAEI2C3hh9S98PWwwptAjKZlo2aBGhOCNYVAtKPM4tDAidrG8/2/Evy+UMorZwtAHtjQ==", "11229ac1-e328-4e6c-8645-d554774dcfe3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "4ead6e79-84b4-4a80-b0e1-dc4006a233de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "fc3acd77-dc02-4553-a71e-d7020a16a569");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "817a9d48-83e4-44f5-9d3b-e9a4819ce3fe", "AQAAAAEAACcQAAAAEFJbxKluFqbCpZQZHoi0HzQZltt4dV/RU/HaC1L9qqABT7Mh0M8e4SDiL4ELavqMtw==", "a96ccbd7-5608-4a56-b38c-45725850eb71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b81255b9-0e99-41e2-9ea5-9c9c2b193f4c", "AQAAAAEAACcQAAAAEK7Bt9mF1ZbBeFbOer1RI4Pdw0OL3vOG/jSspdPkzyBaEPoUyAV4BS5vqSuGlcnf1Q==", "da100006-0caa-4be2-b515-2ea21d086ff7" });
        }
    }
}
