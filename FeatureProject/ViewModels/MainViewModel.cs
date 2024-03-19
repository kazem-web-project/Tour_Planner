using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureProject.DummyData;
using FeatureProject.Models;

namespace FeatureProject.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Tour> Tours { get; set; } = new ObservableCollection<Tour>()
        {
            DummyTours.Tours[0],
            DummyTours.Tours[1],
            DummyTours.Tours[2],
            DummyTours.Tours[3],
        };

        public MainViewModel()
        {

        }
    }
}
