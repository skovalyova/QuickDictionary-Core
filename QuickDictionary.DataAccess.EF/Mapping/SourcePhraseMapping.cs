using QuickDictionary.DataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace QuickDictionary.DataAccess.EF.Mapping
{
    internal class SourcePhraseMapping : EntityTypeConfiguration<SourcePhrase>
    {
        internal SourcePhraseMapping()
        {
            HasKey(s => s.Id);

            HasRequired(s => s.Dictionary)
                .WithMany(d => d.SourcePhrases)
                .HasForeignKey(s => s.DictionaryId)
                .WillCascadeOnDelete(true);

            Property(s => s.Value)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}
