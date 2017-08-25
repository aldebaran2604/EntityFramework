namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Name = Tittle");
            DropColumn("dbo.Courses", "Tittle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Tittle", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Tittle = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
