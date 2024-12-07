using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "3edba757-f298-4907-be96-b74e345deaeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "5db4a7a7-11f4-4b44-933b-944e5d0f8367");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c82cde03-aa14-49f0-8a68-0f4e4f5ec920", "AQAAAAEAACcQAAAAEK9/wHxoywLH+rgwP9P9NUkWt7JFMN8F0O0yMom8bEqf/JNYE+8iiJ4QIpgaMhiS0Q==", "45ef9f21-6f11-444b-bf31-df36505913f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6918e3d-10f3-432b-ac17-40d1983b4dfa", "AQAAAAEAACcQAAAAEFB9bYKTxE0GBwuSaCdOSJ9KNlniW5FZRxgIyrO6AaR+Ljw3XvrA2YAj5Jrbad33yw==", "c186f94b-8681-47ad-9f1c-cfae37c60c59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
