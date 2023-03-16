namespace WebsiteQuanLyTours.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequired1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DiaDiemHotNuocNgoais", "DiaDiemHotNuocNgoai1", c => c.String(nullable: false));
            AlterColumn("dbo.DiaDiemHotTrongNuocs", "DiaDiemHotTrongNuoc1", c => c.String(nullable: false));
            AlterColumn("dbo.LoaiTours", "LoaiTours", c => c.String(nullable: false));
            AlterColumn("dbo.TourNuocNgoais", "TourNuocNgoai1", c => c.String(nullable: false));
            AlterColumn("dbo.TourTheoChuDes", "TourTheoChuDe1", c => c.String(nullable: false));
            AlterColumn("dbo.TourTrongNuocs", "TourTrongNuoc1", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TourTrongNuocs", "TourTrongNuoc1", c => c.String());
            AlterColumn("dbo.TourTheoChuDes", "TourTheoChuDe1", c => c.String());
            AlterColumn("dbo.TourNuocNgoais", "TourNuocNgoai1", c => c.String());
            AlterColumn("dbo.LoaiTours", "LoaiTours", c => c.String());
            AlterColumn("dbo.DiaDiemHotTrongNuocs", "DiaDiemHotTrongNuoc1", c => c.String());
            AlterColumn("dbo.DiaDiemHotNuocNgoais", "DiaDiemHotNuocNgoai1", c => c.String());
        }
    }
}
