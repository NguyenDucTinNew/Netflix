namespace WebsiteQuanLyTours.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequired : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiaDiemHotNuocNgoais",
                c => new
                    {
                        MaDiaDiemHotNuocNgoai = c.Long(nullable: false, identity: true),
                        DiaDiemHotNuocNgoai1 = c.String(),
                    })
                .PrimaryKey(t => t.MaDiaDiemHotNuocNgoai);
            
            CreateTable(
                "dbo.DiaDiemHotTrongNuocs",
                c => new
                    {
                        MaDiaDiemHotTrongNuoc = c.Long(nullable: false, identity: true),
                        DiaDiemHotTrongNuoc1 = c.String(),
                    })
                .PrimaryKey(t => t.MaDiaDiemHotTrongNuoc);
            
            CreateTable(
                "dbo.LoaiTours",
                c => new
                    {
                        MaLoaiTour = c.Long(nullable: false, identity: true),
                        LoaiTours = c.String(),
                    })
                .PrimaryKey(t => t.MaLoaiTour);
            
            CreateTable(
                "dbo.TourNuocNgoais",
                c => new
                    {
                        MaTourNuocNgoai = c.Long(nullable: false, identity: true),
                        TourNuocNgoai1 = c.String(),
                    })
                .PrimaryKey(t => t.MaTourNuocNgoai);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        MaTour = c.Long(nullable: false, identity: true),
                        TenTour = c.String(nullable: false),
                        ThoiGianTour = c.DateTime(nullable: false),
                        Gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ChuongTrinhTour = c.String(nullable: false),
                        MaLoaiTour = c.Long(nullable: false),
                        MaChuDe = c.Long(nullable: false),
                        MaTourNuocNgoai = c.Long(nullable: false),
                        MaTourTrongNuoc = c.Long(nullable: false),
                        MaDiaDiemHotNuocNgoai = c.Long(nullable: false),
                        MaDiaDiemHotTrongNuoc = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.MaTour)
                .ForeignKey("dbo.DiaDiemHotNuocNgoais", t => t.MaDiaDiemHotNuocNgoai, cascadeDelete: true)
                .ForeignKey("dbo.DiaDiemHotTrongNuocs", t => t.MaDiaDiemHotTrongNuoc, cascadeDelete: true)
                .ForeignKey("dbo.LoaiTours", t => t.MaLoaiTour, cascadeDelete: true)
                .ForeignKey("dbo.TourNuocNgoais", t => t.MaTourNuocNgoai, cascadeDelete: true)
                .ForeignKey("dbo.TourTheoChuDes", t => t.MaChuDe, cascadeDelete: true)
                .ForeignKey("dbo.TourTrongNuocs", t => t.MaTourTrongNuoc, cascadeDelete: true)
                .Index(t => t.MaLoaiTour)
                .Index(t => t.MaChuDe)
                .Index(t => t.MaTourNuocNgoai)
                .Index(t => t.MaTourTrongNuoc)
                .Index(t => t.MaDiaDiemHotNuocNgoai)
                .Index(t => t.MaDiaDiemHotTrongNuoc);
            
            CreateTable(
                "dbo.TourTheoChuDes",
                c => new
                    {
                        MaChuDe = c.Long(nullable: false, identity: true),
                        TourTheoChuDe1 = c.String(),
                    })
                .PrimaryKey(t => t.MaChuDe);
            
            CreateTable(
                "dbo.TourTrongNuocs",
                c => new
                    {
                        MaTourTrongNuoc = c.Long(nullable: false, identity: true),
                        TourTrongNuoc1 = c.String(),
                    })
                .PrimaryKey(t => t.MaTourTrongNuoc);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tours", "MaTourTrongNuoc", "dbo.TourTrongNuocs");
            DropForeignKey("dbo.Tours", "MaChuDe", "dbo.TourTheoChuDes");
            DropForeignKey("dbo.Tours", "MaTourNuocNgoai", "dbo.TourNuocNgoais");
            DropForeignKey("dbo.Tours", "MaLoaiTour", "dbo.LoaiTours");
            DropForeignKey("dbo.Tours", "MaDiaDiemHotTrongNuoc", "dbo.DiaDiemHotTrongNuocs");
            DropForeignKey("dbo.Tours", "MaDiaDiemHotNuocNgoai", "dbo.DiaDiemHotNuocNgoais");
            DropIndex("dbo.Tours", new[] { "MaDiaDiemHotTrongNuoc" });
            DropIndex("dbo.Tours", new[] { "MaDiaDiemHotNuocNgoai" });
            DropIndex("dbo.Tours", new[] { "MaTourTrongNuoc" });
            DropIndex("dbo.Tours", new[] { "MaTourNuocNgoai" });
            DropIndex("dbo.Tours", new[] { "MaChuDe" });
            DropIndex("dbo.Tours", new[] { "MaLoaiTour" });
            DropTable("dbo.TourTrongNuocs");
            DropTable("dbo.TourTheoChuDes");
            DropTable("dbo.Tours");
            DropTable("dbo.TourNuocNgoais");
            DropTable("dbo.LoaiTours");
            DropTable("dbo.DiaDiemHotTrongNuocs");
            DropTable("dbo.DiaDiemHotNuocNgoais");
        }
    }
}
