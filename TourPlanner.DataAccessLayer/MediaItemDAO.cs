using System.Diagnostics;
using TourPlanner.Models;

namespace TourPlanner.DataAccessLayer
{
    public class MediaItemDAO
    {
        private IDataAccess dataAccess;

        public MediaItemDAO()
        {
            // chech which datasource to use
                
            dataAccess = new Database();
            //dataAccess = new FileSystem();
        }

        public List<TourLog> GetItems()
        {
            return dataAccess.GetItems();
        }

        public void addItem(MediaItem media)
        {
            dataAccess.addItem(media.TourLog);
        }
        public void removeItem(MediaItem media)
        {
            dataAccess.removeItem(media.TourLog);
        }


    }
}
