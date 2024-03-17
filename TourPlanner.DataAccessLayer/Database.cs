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
        private List<MediaItem> mediaItems;

        public Database()
        {
            // get connection from config file
            connectionString = "...";
            // establish connection with db
            this.mediaItems = new List<MediaItem>()
            {
                new MediaItem(){Name = "Item1"},
                new MediaItem(){Name = "Item2"},
                new MediaItem(){Name = "Another"},
                new MediaItem(){Name = "SWE"},
                new MediaItem(){Name = "FHTW"}
            };
        }

        public void addItem(TourLog newTourLog)
        {
            // TODO: change it with the database!
            this.mediaItems.Add(new MediaItem(){Name = newTourLog.commentText});
        }

        public List<MediaItem> GetItems()
        {/*
            this.mediaItems = new List<MediaItem>()
            {
                new MediaItem(){Name = "Item1"},
                new MediaItem(){Name = "Item2"},
                new MediaItem(){Name = "Another"},
                new MediaItem(){Name = "SWE"},
                new MediaItem(){Name = "FHTW"}
            };
            */
            return this.mediaItems; 

            
        }
    }
}
