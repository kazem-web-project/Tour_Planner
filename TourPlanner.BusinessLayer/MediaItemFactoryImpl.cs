using TourPlanner.DataAccessLayer;
using TourPlanner.Models;

namespace TourPlanner.BusinessLayer
{
    public class MediaItemFactoryImpl : IMediaItemFactory
    {
        private MediaItemDAO mediaItemDAO = new MediaItemDAO();

        public void addItem(MediaItem mediaItem)
        {
            mediaItemDAO.addItem(mediaItem);
        }


        public void removeItem(MediaItem mediaItem)
        {
            mediaItemDAO.removeItem(mediaItem);
        }


        public IEnumerable<MediaItem> GetItems()
        {
            List<TourLog> tourLogs = mediaItemDAO.GetItems();
            List<MediaItem> tourLogToConvertToMediaItem = new List<MediaItem>();
            foreach (var item in tourLogs) {
                tourLogToConvertToMediaItem.Add(new MediaItem() { Name = item.commentText,TourLog = item });
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


        public void updateItem(MediaItem oldItem, MediaItem newMediaItem)
        {
            this.removeItem(oldItem);
            this.addItem(newMediaItem);
        }
    }
}