using TourPlanner.DataAccessLayer;
using TourPlanner.Models;

namespace TourPlanner.BusinessLayer
{
    public class MediaItemFactoryImpl : IMediaItemFactory
    {
        private MediaItemDAO mediaItemDAO = new MediaItemDAO();

        public void addItem(TourLog newTourLog)
        {
            mediaItemDAO.addItem(newTourLog);
        }

        public IEnumerable<MediaItem> GetItems()
        {
            List<TourLog> tourLogs = mediaItemDAO.GetItems();
            List<MediaItem> tourLogToConvertToMediaItem = new List<MediaItem>();
            foreach (var item in tourLogs) {
                tourLogToConvertToMediaItem.Add(new MediaItem() { Name = item.commentText });
            }
            return tourLogToConvertToMediaItem;

            /*
            return new List<MediaItem>()
            {
                new MediaItem(){Name = "Item1"},
                new MediaItem(){Name = "Item2"},
                new MediaItem(){Name = "Another"},
                new MediaItem(){Name = "SWE"},
                new MediaItem(){Name = "FHTW"}
            };
            */
        }

        public IEnumerable<MediaItem> Search(string itemName, bool caseSensitive = false)
        {
            IEnumerable<MediaItem> items = GetItems();
            if (caseSensitive)
            {
                items.Where(x => x.Name.Contains(itemName));
            }
            return items.Where(x => x.Name.ToLower().Contains(itemName.ToLower()));
        }
    }
}