using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_writerMessages",
                table: "writerMessages");

            migrationBuilder.RenameTable(
                name: "writerMessages",
                newName: "WriterMessages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages",
                column: "WriterMessageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages");

            migrationBuilder.RenameTable(
                name: "WriterMessages",
                newName: "writerMessages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_writerMessages",
                table: "writerMessages",
                column: "WriterMessageId");
        }
    }
}
