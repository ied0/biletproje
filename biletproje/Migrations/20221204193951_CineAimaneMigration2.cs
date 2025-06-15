using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace biletproje.Migrations
{
	/// <inheritdoc />
	public partial class biletprojeMigration2 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "Showtimes",
				table: "Movies",
				type: "nvarchar(max)",
				nullable: false,
				defaultValue: "");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "Showtimes",
				table: "Movies");
		}
	}
}
