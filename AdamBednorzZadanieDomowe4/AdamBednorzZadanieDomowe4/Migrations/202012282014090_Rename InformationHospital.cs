namespace AdamBednorzZadanieDomowe4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameInformationHospital : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.InforamtionHospitals", newName: "InformationHospitals");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.InformationHospitals", newName: "InforamtionHospitals");
        }
    }
}
