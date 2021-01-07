using System;
using SQLite;

namespace JOURNAL.Models
{
    public class Memory
    {
      
            [PrimaryKey, AutoIncrement]
            public int MID { get; set; }
            public string Text { get; set; }
            public DateTime Date { get; set; }
        
    }
}
