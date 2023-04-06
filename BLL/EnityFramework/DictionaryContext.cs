using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using BLL.EnityFramework.Model;
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
        public virtual DbSet<wn_similar> wn_similar { get; set; }
        public virtual DbSet<wn_hypernym> wn_hypernym { get; set; }
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
        public virtual DbSet<Topic> topic { get; set; }

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
                .HasMany(e => e.wn_similar)
                .WithRequired(e => e.wn_synset)
                .HasForeignKey(e => e.synset_id_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_similar1)
                .WithRequired(e => e.wn_synset1)
                .HasForeignKey(e => e.synset_id_2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_hypernym)
                .WithRequired(e => e.wn_synset)
                .HasForeignKey(e => e.synset_id_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasMany(e => e.wn_hypernym1)
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
                .HasForeignKey(e => e.synset_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_synset>()
                .HasRequired(e => e.topic)
                .WithRequiredPrincipal(e => e.wn_synset)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Notebook>()
            //    .HasRequired(e => e.Wn_Word)
            //    .WithMany(e => e.Notebooks)
            //    .HasForeignKey(e => new { e.SynsetID, e.WordNum, e.AccountID })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Notebook>()
            //    .HasRequired(e => e.Account)
            //    .WithMany(e => e.Notebooks)
            //    .HasForeignKey(e => new { e.SynsetID, e.WordNum, e.AccountID })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<wn_word>()
            //    .HasMany(e => e.Notebooks)
            //    .WithRequired(e => e.Wn_Word)
            //    .HasForeignKey(e => e.WordNum)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<wn_word>()
            //    .HasMany(e => e.Notebooks)
            //    .WithRequired(e => e.Wn_Word)
            //    .HasForeignKey(e => e.SynsetID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<wn_word>()
            //    .HasMany(e => e.HistoryContainer)
            //    .WithRequired(e => e.Wn_Word)
            //    .HasForeignKey(e => e.SynsetID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<wn_word>()
            //    .HasMany(e => e.HistoryContainer)
            //    .WithRequired(e => e.Wn_Word)
            //    .HasForeignKey(e => e.WordNum)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<wn_word>()
                .Property(e => e.word)
                .IsUnicode(false);

            //modelBuilder.Entity<word_viet>()
            //    .HasMany(e => e.HistoryContainer)
            //    .WithRequired(e => e.Word_Viet)
            //    .HasForeignKey(e => e.WordID)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<word_viet>()
                .Property(e => e.word)
                .IsUnicode(false);

            modelBuilder.Entity<word_viet>()
                .Property(e => e.detail)
                .IsUnicode(false);

            //modelBuilder.Entity<UserPacket>()
            //    .HasMany(e => e.UserPacketInfos)
            //    .WithRequired(e => e.UserPacket)
            //    .HasForeignKey(e => e.PacketID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Account>()
            //    .HasRequired(e => e.DetailedInformation)
            //    .WithRequiredDependent(e => e.Account)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Account>()
            //    .HasMany(e => e.HistoryEnglishContainer)
            //    .WithRequired(e => e.Account)
            //    .HasForeignKey(e => e.AccountID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Account>()
            //    .HasMany(e => e.HistoryVietNameseContainer)
            //    .WithRequired(e => e.Account)
            //    .HasForeignKey(e => e.AccountID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Account>()
            //    .HasMany(e => e.InformationPerDays)
            //    .WithRequired(e => e.Account)
            //    .HasForeignKey(e => e.AccountID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Account>()
            //    .HasMany(e => e.UserPacketInfos)
            //    .WithRequired(e => e.Account)
            //    .HasForeignKey(e => e.AccountID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Account>()
            //    .HasMany(e => e.Notebooks)
            //    .WithRequired(e => e.Account)
            //    .HasForeignKey(e => e.AccountID)
            //    .WillCascadeOnDelete(false);
        }
    }
}
