namespace EFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        UserName = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Name = c.String(unicode: false),
                        BirthDate = c.DateTime(nullable: false, precision: 0),
                        Age = c.Int(nullable: false),
                        Email = c.String(unicode: false),
                        Gender = c.Boolean(nullable: false),
                        ProfilePicture = c.String(unicode: false),
                        TypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountID)
                .ForeignKey("dbo.AccountTypes", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DetailedInformation",
                c => new
                    {
                        AccountID = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        NumberOfLoginDay = c.Int(nullable: false),
                        NumberOfConsecutiveDay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountID)
                .ForeignKey("dbo.Account", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.HistoryEnglishContainer",
                c => new
                    {
                        AccountID = c.Int(nullable: false),
                        WordNum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SynsetID = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.AccountID, t.WordNum, t.SynsetID })
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.Wn_word", t => new { t.WordNum, t.SynsetID }, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => new { t.WordNum, t.SynsetID });
            
            /*CreateTable(
                "dbo.Wn_word",
                c => new
                    {
                        synset_id = c.Decimal(nullable: false, precision: 18, scale: 2),
                        w_num = c.Decimal(nullable: false, precision: 18, scale: 2),
                        word = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.synset_id, t.w_num })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id)
                .Index(t => t.synset_id);
            
            CreateTable(
                "dbo.Wn_synset",
                c => new
                    {
                        synset_id = c.Decimal(nullable: false, precision: 18, scale: 2),
                        definition = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.synset_id);
            
            CreateTable(
                "dbo.Wn_antonym",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        wnum_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        wnum_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.wnum_1, t.synset_id_2, t.wnum_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
            
            CreateTable(
                "dbo.Wn_derived",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        wnum_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        wnum_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.wnum_1, t.synset_id_2, t.wnum_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
            
            CreateTable(
                "dbo.Wn_see_also",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        wnum_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        wnum_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.wnum_1, t.synset_id_2, t.wnum_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
            
            CreateTable(
                "dbo.Wn_verb_frame",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        f_num = c.Decimal(nullable: false, precision: 18, scale: 2),
                        w_num = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.f_num, t.w_num })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .Index(t => t.synset_id_1);*/
            
            CreateTable(
                "dbo.HistoryVietNameseContainer",
                c => new
                    {
                        AccountID = c.Int(nullable: false),
                        WordID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccountID, t.WordID })
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.word_viet", t => t.WordID, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => t.WordID);
            
            /*CreateTable(
                "dbo.word_viet",
                c => new
                    {
                        idx = c.Int(nullable: false),
                        word = c.String(maxLength: 255, unicode: false),
                        detail = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idx);*/
            
            CreateTable(
                "dbo.InformationPerDay",
                c => new
                    {
                        DayID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        NumberOfLearnedWord = c.Int(nullable: false),
                        OnlineHour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DayID, t.AccountID })
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Notebook",
                c => new
                    {
                        AccountID = c.Int(nullable: false),
                        WordNum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SynsetID = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LearnedPercent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccountID, t.WordNum, t.SynsetID })
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.Wn_word", t => new { t.WordNum, t.SynsetID }, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => new { t.WordNum, t.SynsetID });
            
            CreateTable(
                "dbo.UserPacketInfo",
                c => new
                    {
                        PacketID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        DueDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => new { t.PacketID, t.AccountID })
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.UserPacket", t => t.PacketID, cascadeDelete: true)
                .Index(t => t.PacketID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.UserPacket",
                c => new
                    {
                        PacketID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Price = c.Int(nullable: false),
                        TimeOfUse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PacketID);
            
            /*CreateTable(
                "pbl3.Wn_entails",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.synset_id_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
            
            CreateTable(
                "pbl3.Wn_hypernym",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.synset_id_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
            
            CreateTable(
                "pbl3.Wn_hyponym",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.synset_id_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
            
            CreateTable(
                "pbl3.Wn_similar",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.synset_id_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
            
            CreateTable(
                "dbo.Wn_verb_group",
                c => new
                    {
                        synset_id_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        synset_id_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.synset_id_1, t.synset_id_2 })
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_1)
                .ForeignKey("dbo.Wn_synset", t => t.synset_id_2)
                .Index(t => t.synset_id_1)
                .Index(t => t.synset_id_2);
         */   
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPacketInfo", "PacketID", "dbo.UserPacket");
            DropForeignKey("dbo.UserPacketInfo", "AccountID", "dbo.Account");
            DropForeignKey("dbo.Notebook", new[] { "WordNum", "SynsetID" }, "dbo.Wn_word");
            DropForeignKey("dbo.Notebook", "AccountID", "dbo.Account");
            DropForeignKey("dbo.InformationPerDay", "AccountID", "dbo.Account");
            DropForeignKey("dbo.HistoryVietNameseContainer", "WordID", "dbo.word_viet");
            DropForeignKey("dbo.HistoryVietNameseContainer", "AccountID", "dbo.Account");
            DropForeignKey("dbo.HistoryEnglishContainer", new[] { "WordNum", "SynsetID" }, "dbo.Wn_word");
            DropForeignKey("dbo.Wn_word", "synset_id", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_verb_frame", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_verb_group", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_verb_group", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_similar", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_similar", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_hyponym", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_hyponym", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_hypernym", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_hypernym", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_entails", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("Wn_pro_mysql.Wn_entails", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_see_also", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_see_also", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_derived", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_derived", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_antonym", "synset_id_2", "dbo.Wn_synset");
            DropForeignKey("dbo.Wn_antonym", "synset_id_1", "dbo.Wn_synset");
            DropForeignKey("dbo.HistoryEnglishContainer", "AccountID", "dbo.Account");
            DropForeignKey("dbo.DetailedInformation", "AccountID", "dbo.Account");
            DropForeignKey("dbo.Account", "TypeID", "dbo.AccountTypes");
            DropIndex("dbo.Wn_verb_group", new[] { "synset_id_2" });
            DropIndex("dbo.Wn_verb_group", new[] { "synset_id_1" });
            DropIndex("Wn_pro_mysql.Wn_similar", new[] { "synset_id_2" });
            DropIndex("Wn_pro_mysql.Wn_similar", new[] { "synset_id_1" });
            DropIndex("Wn_pro_mysql.Wn_hyponym", new[] { "synset_id_2" });
            DropIndex("Wn_pro_mysql.Wn_hyponym", new[] { "synset_id_1" });
            DropIndex("Wn_pro_mysql.Wn_hypernym", new[] { "synset_id_2" });
            DropIndex("Wn_pro_mysql.Wn_hypernym", new[] { "synset_id_1" });
            DropIndex("Wn_pro_mysql.Wn_entails", new[] { "synset_id_2" });
            DropIndex("Wn_pro_mysql.Wn_entails", new[] { "synset_id_1" });
            DropIndex("dbo.UserPacketInfo", new[] { "AccountID" });
            DropIndex("dbo.UserPacketInfo", new[] { "PacketID" });
            DropIndex("dbo.Notebook", new[] { "WordNum", "SynsetID" });
            DropIndex("dbo.Notebook", new[] { "AccountID" });
            DropIndex("dbo.InformationPerDay", new[] { "AccountID" });
            DropIndex("dbo.HistoryVietNameseContainer", new[] { "WordID" });
            DropIndex("dbo.HistoryVietNameseContainer", new[] { "AccountID" });
            DropIndex("dbo.Wn_verb_frame", new[] { "synset_id_1" });
            DropIndex("dbo.Wn_see_also", new[] { "synset_id_2" });
            DropIndex("dbo.Wn_see_also", new[] { "synset_id_1" });
            DropIndex("dbo.Wn_derived", new[] { "synset_id_2" });
            DropIndex("dbo.Wn_derived", new[] { "synset_id_1" });
            DropIndex("dbo.Wn_antonym", new[] { "synset_id_2" });
            DropIndex("dbo.Wn_antonym", new[] { "synset_id_1" });
            DropIndex("dbo.Wn_word", new[] { "synset_id" });
            DropIndex("dbo.HistoryEnglishContainer", new[] { "WordNum", "SynsetID" });
            DropIndex("dbo.HistoryEnglishContainer", new[] { "AccountID" });
            DropIndex("dbo.DetailedInformation", new[] { "AccountID" });
            DropIndex("dbo.Account", new[] { "TypeID" });
            DropTable("dbo.Wn_verb_group");
            DropTable("Wn_pro_mysql.Wn_similar");
            DropTable("Wn_pro_mysql.Wn_hyponym");
            DropTable("Wn_pro_mysql.Wn_hypernym");
            DropTable("Wn_pro_mysql.Wn_entails");
            DropTable("dbo.UserPacket");
            DropTable("dbo.UserPacketInfo");
            DropTable("dbo.Notebook");
            DropTable("dbo.InformationPerDay");
            DropTable("dbo.word_viet");
            DropTable("dbo.HistoryVietNameseContainer");
            DropTable("dbo.Wn_verb_frame");
            DropTable("dbo.Wn_see_also");
            DropTable("dbo.Wn_derived");
            DropTable("dbo.Wn_antonym");
            DropTable("dbo.Wn_synset");
            DropTable("dbo.Wn_word");
            DropTable("dbo.HistoryEnglishContainer");
            DropTable("dbo.DetailedInformation");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.Account");
        }
    }
}
