using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecordRest.Models;

namespace RecordRest.Managers
{
    public class RecordManager
    {
        public static List<Record> records = new List<Record>
        {
            new Record {Artist = "Michael Jackson", Title = "Thriller", Duration = 360, PublicationYear = 1982},
            new Record {Artist = "Kim Larsen", Title = "Det Bedste Til Mig og Mine Venner", Duration = 240, PublicationYear = 1977}
        };
        

        public List<Record> GetAllRecords()
        {
            return records;
        }
    }
}
