﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;

namespace TourPlanner.DataAccessLayer
{
    interface IDataAccess
    {
        public List<TourLog> GetItems();
        public void addItem(TourLog newTourLog);
        void removeItem(TourLog tourLog);
    }
}
