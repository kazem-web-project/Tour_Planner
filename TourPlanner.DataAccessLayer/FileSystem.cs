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

        public List<TourLog> GetItems()
        {
            // get media items from file system
            return new List<TourLog>()
            {
                new TourLog(){commentText = "Item1"},
                new TourLog(){commentText = "Item2"},
                new TourLog(){commentText = "Another"},
                new TourLog(){commentText = "SWE"},
                new TourLog(){commentText = "FHTW"}
            };
        }

        public void removeItem(TourLog tourLog)
        {
            throw new NotImplementedException();
        }
    }
}
