using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

using BLL.EntityFrameWork.Model;
using PBLLibrary;

namespace BLL.EntityFrameWork
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public partial class DictionaryContext : DbContext
    {
        public DictionaryContext()
            : base(GlobalConfig.Instance.ConnectionString("Dictionary"))
        {
            //var initializer = new MigrateDatabaseToLatestVersion<Model1, BLL.Migrations.Configuration>();
            //Database.SetInitializer(initializer);
        }

        public virtual DbSet<wn_antonym> wn_antonym { get; set; }
        public virtual DbSet<wn_derived> wn_derived { get; set; }
        public virtual DbSet<wn_see_also> wn_see_also { get; set; }
        public virtual DbSet<wn_synset> wn_synset { get; set; }
        public virtual DbSet<wn_verb_frame> wn_verb_frame { get; set; }
        public virtual DbSet<wn_word> wn_word { get; set; }
        public virtual DbSet<word_viet> word_viet { get; set; }

        public virtual DbSet<Account> account { get; set; }
        public virtual DbSet<DetailedInformation> detailedInformation { get; set; }
        public virtual DbSet<InformationPerDay> informationPerDay { get; set; }
        public virtual DbSet<UserPacketInfo> userPacketInfo { get; set; }
        public virtual DbSet<UserPacket> userPacket { get; set; }
        public virtual DbSet<Notebook> notebook { get; set; }
        public virtual DbSet<HistoryEnglishContainer> historyEnglishContainer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = true;

            modelBuilder.Entity<wn_synset>()
                .Property(e => e.definition)
                .IsUnicode(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_antonym)
                .WithRequired(e => e.wn_synset)
                .HasForeignKey(e => e.synset_id_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_antonym1)
                .WithRequired(e => e.wn_synset1)
                .HasForeignKey(e => e.synset_id_2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_derived)
                .WithRequired(e => e.wn_synset)
                .HasForeignKey(e => e.synset_id_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_derived1)
                .WithRequired(e => e.wn_synset1)
                .HasForeignKey(e => e.synset_id_2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_see_also)
                .WithRequired(e => e.wn_synset)
                .HasForeignKey(e => e.synset_id_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_see_also1)
                .WithRequired(e => e.wn_synset1)
                .HasForeignKey(e => e.synset_id_2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_verb_frame)
                .WithRequired(e => e.wn_synset)
                .HasForeignKey(e => e.synset_id_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_word)
                .WithRequired(e => e.wn_synset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_synset1)
                .WithMany(e => e.wn_synset2)
                .Map(m => m.ToTable("wn_entails", "wn_pro_mysql").MapLeftKey("synset_id_1").MapRightKey("synset_id_2"));

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_synset11)
                .WithMany(e => e.wn_synset3)
                .Map(m => m.ToTable("wn_hypernym", "wn_pro_mysql").MapLeftKey("synset_id_1").MapRightKey("synset_id_2"));

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_synset12)
                .WithMany(e => e.wn_synset4)
                .Map(m => m.ToTable("wn_hyponym", "wn_pro_mysql").MapLeftKey("synset_id_1").MapRightKey("synset_id_2"));

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_synset13)
                .WithMany(e => e.wn_synset5)
                .Map(m => m.ToTable("wn_similar", "wn_pro_mysql").MapLeftKey("synset_id_1").MapRightKey("synset_id_2"));

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_synset14)
                .WithMany(e => e.wn_synset6)
                .Map(m => m.ToTable("wn_verb_group").MapLeftKey("synset_id_1").MapRightKey("synset_id_2"));

            modelBuilder.Entity<wn_word>()
                .Property(e => e.word)
                .IsUnicode(false);

            modelBuilder.Entity<word_viet>()
                .Property(e => e.word)
                .IsUnicode(false);

            modelBuilder.Entity<word_viet>()
                .Property(e => e.detail)
                .IsUnicode(false);
        }
    }
}
