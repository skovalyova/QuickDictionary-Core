using System.Collections.Generic;

namespace QuickDictionary.DataAccess.Models
{
    public class Language
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public virtual ICollection<Dictionary> SourceDictionaries { get; set; }

        public virtual ICollection<Dictionary> TargetDictionaries { get; set; }

        public Language()
        {
            SourceDictionaries = new List<Dictionary>();
            TargetDictionaries = new List<Dictionary>();
        }
    }
}
