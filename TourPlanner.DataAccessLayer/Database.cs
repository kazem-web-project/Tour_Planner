using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;

namespace TourPlanner.DataAccessLayer
{    
    class Database : IDataAccess
    {
        private string connectionString;

        public Database()
        {
            // get connection from config file
            connectionString = "...";
            // establish connection with db
        }
        public List<MediaItem> GetItems()
        {
            
            return new List<MediaItem>()
            {
                new MediaItem(){Name = "Item1"},
                new MediaItem(){Name = "Item2"},
                new MediaItem(){Name = "Another"},
                new MediaItem(){Name = "SWE"},
                new MediaItem(){Name = "FHTW"}
            };
            
            
        }
    }
}
