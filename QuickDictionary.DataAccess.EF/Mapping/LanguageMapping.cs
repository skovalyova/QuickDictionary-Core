﻿using QuickDictionary.DataAccess.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace QuickDictionary.DataAccess.EF.Mapping
{
    internal class LanguageMapping : EntityTypeConfiguration<Language>
    {
        internal LanguageMapping()
        {
            HasKey(l => l.Id);

            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(64)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Name") { IsUnique = true })
                );

            Property(l => l.Code)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Code") { IsUnique = true })
                );
        }
    }
}
