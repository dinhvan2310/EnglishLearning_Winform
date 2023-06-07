using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using BLL.EnityFramework.Model;
using EFramework.Model;
using Library;

namespace EFramework
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

        public virtual DbSet<wn_antonym> Wn_antonym { get; set; }
        public virtual DbSet<wn_similar> Wn_similar { get; set; }
        public virtual DbSet<wn_hypernym> Wn_hypernym { get; set; }
        public virtual DbSet<wn_derived> Wn_derived { get; set; }
        public virtual DbSet<wn_see_also> Wn_see_also { get; set; }
        public virtual DbSet<wn_synset> Wn_synset { get; set; }
        public virtual DbSet<wn_verb_frame> Wn_verb_frame { get; set; }
        public virtual DbSet<wn_word> Wn_word { get; set; }
        public virtual DbSet<word_viet> Word_viet { get; set; }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<DetailedInformation> DetailedInformation { get; set; }
        public virtual DbSet<InformationPerDay> InformationPerDay { get; set; }
        public virtual DbSet<UserPacketInfo> UserPacketInfo { get; set; }
        public virtual DbSet<UserPacket> UserPacket { get; set; }
        public virtual DbSet<Notebook> Notebook { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = true;
        }
    }
}
