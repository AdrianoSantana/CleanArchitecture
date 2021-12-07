using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMVC.Data.Migrations
{
    public partial class seedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) "+
                "VALUES('Caderno espiral', 'Caderno espiral 100 folhas', 7.45, 50, '', 1)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) "+
                "VALUES('Estojo', 'Estojo', 5.50, 50, '', 1)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) "+
                "VALUES('Borracha escolar', 'Borracha escolar description', 0.65, 50, '', 1)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) "+
                "VALUES('Camisa NBA', 'Camisa NBA', 234.00, 5, 'https://cdnx.jumpseller.com/alley-oop-store/image/15356014/resize/540/540?1636297706', 1)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) "+
                "VALUES('Caderno espiral', 'Caderno espiral 100 folhas', 7.45, 50, '', 1)"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
