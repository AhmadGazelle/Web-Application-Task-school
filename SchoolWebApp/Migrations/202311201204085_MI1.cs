namespace SchoolWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MI1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(maxLength: 50),
                        CourseNumber = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tetcher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TetcherName = c.String(maxLength: 50),
                        Major = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tetcher");
            DropTable("dbo.Student");
            DropTable("dbo.Course");
        }
    }
}
