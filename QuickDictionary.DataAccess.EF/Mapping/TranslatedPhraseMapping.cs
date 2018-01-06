using QuickDictionary.DataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace QuickDictionary.DataAccess.EF.Mapping
{
    internal class TranslatedPhraseMapping : EntityTypeConfiguration<TranslatedPhrase>
    {
        internal TranslatedPhraseMapping()
        {
            HasKey(s => s.Id);

            HasRequired(t => t.SourcePhrase)
                .WithMany(s => s.TranslatedPhrases)
                .HasForeignKey(t => t.SourcePhraseId)
                .WillCascadeOnDelete(true);

            Property(s => s.Value)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}
