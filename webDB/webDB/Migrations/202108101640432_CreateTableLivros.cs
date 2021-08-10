namespace webDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableLivros : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Autor = c.String(),
                        QuantidadeDePaginas = c.Int(nullable: false),
                        DataDeLancamento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Livros");
        }
    }
}
