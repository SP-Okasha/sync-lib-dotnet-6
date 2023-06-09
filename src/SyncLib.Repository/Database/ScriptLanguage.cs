﻿namespace SyncLib.Repository.Database
{
    public partial class ScriptLanguage
    {
        public ScriptLanguage()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string LanguageName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
