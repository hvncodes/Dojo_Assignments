using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class AddS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWedding_Users_UserId",
                table: "UserWedding");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWedding_Wedding_WeddingId",
                table: "UserWedding");

            migrationBuilder.DropForeignKey(
                name: "FK_Wedding_Users_UserId",
                table: "Wedding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wedding",
                table: "Wedding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWedding",
                table: "UserWedding");

            migrationBuilder.RenameTable(
                name: "Wedding",
                newName: "Weddings");

            migrationBuilder.RenameTable(
                name: "UserWedding",
                newName: "UserWeddings");

            migrationBuilder.RenameIndex(
                name: "IX_Wedding_UserId",
                table: "Weddings",
                newName: "IX_Weddings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserWedding_WeddingId",
                table: "UserWeddings",
                newName: "IX_UserWeddings_WeddingId");

            migrationBuilder.RenameIndex(
                name: "IX_UserWedding_UserId",
                table: "UserWeddings",
                newName: "IX_UserWeddings_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weddings",
                table: "Weddings",
                column: "WeddingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWeddings",
                table: "UserWeddings",
                column: "UserWeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserWeddings_Users_UserId",
                table: "UserWeddings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWeddings_Weddings_WeddingId",
                table: "UserWeddings",
                column: "WeddingId",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weddings_Users_UserId",
                table: "Weddings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWeddings_Users_UserId",
                table: "UserWeddings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWeddings_Weddings_WeddingId",
                table: "UserWeddings");

            migrationBuilder.DropForeignKey(
                name: "FK_Weddings_Users_UserId",
                table: "Weddings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weddings",
                table: "Weddings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWeddings",
                table: "UserWeddings");

            migrationBuilder.RenameTable(
                name: "Weddings",
                newName: "Wedding");

            migrationBuilder.RenameTable(
                name: "UserWeddings",
                newName: "UserWedding");

            migrationBuilder.RenameIndex(
                name: "IX_Weddings_UserId",
                table: "Wedding",
                newName: "IX_Wedding_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserWeddings_WeddingId",
                table: "UserWedding",
                newName: "IX_UserWedding_WeddingId");

            migrationBuilder.RenameIndex(
                name: "IX_UserWeddings_UserId",
                table: "UserWedding",
                newName: "IX_UserWedding_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wedding",
                table: "Wedding",
                column: "WeddingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWedding",
                table: "UserWedding",
                column: "UserWeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserWedding_Users_UserId",
                table: "UserWedding",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWedding_Wedding_WeddingId",
                table: "UserWedding",
                column: "WeddingId",
                principalTable: "Wedding",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wedding_Users_UserId",
                table: "Wedding",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
