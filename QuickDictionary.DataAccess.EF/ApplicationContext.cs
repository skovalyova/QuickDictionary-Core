using LazyVocabulary.DataAccess.Mapping;
using Microsoft.AspNet.Identity.EntityFramework;
using QuickDictionary.DataAccess.EF.Mapping;
using QuickDictionary.DataAccess.Models;
using System.Data.Entity;

namespace QuickDictionary.DataAccess.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Language> Languages { get; set; }

        public DbSet<Dictionary> Dictionaries { get; set; }

        public DbSet<SourcePhrase> SourcePhrases { get; set; }

        public DbSet<TranslatedPhrase> TranslatedPhrases { get; set; }

        public ApplicationContext()
        {

        }

        public ApplicationContext(string conectionString) 
            : base(conectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new LanguageMapping());
            modelBuilder.Configurations.Add(new DictionaryMapping());
            modelBuilder.Configurations.Add(new ApplicationUserMapping());
            modelBuilder.Configurations.Add(new SourcePhraseMapping());
            modelBuilder.Configurations.Add(new TranslatedPhraseMapping());
        }
    }
}
