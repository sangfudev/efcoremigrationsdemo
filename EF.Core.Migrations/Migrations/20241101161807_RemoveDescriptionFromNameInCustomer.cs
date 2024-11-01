using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Core.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDescriptionFromNameInCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameDescription",
                table: "Customers",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "NameDescription");
        }
    }
}
