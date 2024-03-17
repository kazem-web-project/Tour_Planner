using TourPlanner.Models;

namespace TourPlanner.DataAccessLayer
{
    class FileSystem : IDataAccess
    {
        private string filePath;

        public FileSystem()
        {
            // get filepath from config file
            this.filePath = "...";
        }

        public void addItem(TourLog newTourLog)
        {
            throw new NotImplementedException();
        }

        public List<MediaItem> GetItems()
        {
            // get media items from file system
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
