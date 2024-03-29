﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;

namespace TourPlanner.BusinessLayer
{
    public interface IMediaItemFactory
    {
        IEnumerable<MediaItem> GetItems();
        IEnumerable<MediaItem> Search(string itemName, bool caseSensitive = false);
        public void addItem(MediaItem mediaItem);
        public void removeItem(MediaItem mediaItem);
        public void updateItem(MediaItem oldItem, MediaItem newMediaItem );

    }
}
