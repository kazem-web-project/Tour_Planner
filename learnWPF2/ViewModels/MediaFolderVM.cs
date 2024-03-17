using System.Collections.ObjectModel;
using System.Windows.Input;
using TourPlanner.Models;
using TourPlanner.BusinessLayer;
using System.Collections;


namespace TourPlanner.ViewModels
{
    public class MediaFolderVM : ViewModelBase
    {
        private IMediaItemFactory mediaItemFactory;
        private MediaItem currentItem;
        private string searchName;

        private RelayCommand searchCommand;
        private RelayCommand clearCommand;
        public ICommand SearchCommand => searchCommand ??= new RelayCommand(Search);
        public ICommand ClearCommand => clearCommand ??= new RelayCommand(Clear);

        public ObservableCollection<MediaItem> Items { set; get; }  
        public MediaItem CurrentItem
        {
            get
            {
                return currentItem;
            }
            set
            {
                if(currentItem != value && value!=null) { 
                    currentItem = value;
                    RaisePropertyChangedEvent(nameof(CurrentItem));
                }
            }
        }

        public string SearchName {
            get
            {
                return searchName;
            }

            set {
                if (searchName !=value)
                {
                    searchName = value;
                    RaisePropertyChangedEvent(nameof(SearchName));
                }
            }
        }        
        public MediaFolderVM()
        {
            this.mediaItemFactory = MediaItemFactory.GetInstance();
            InitListBox();
        }

        private void InitListBox()
        {
            Items = new ObservableCollection<MediaItem>();
            FillListBox();
        }

        private void FillListBox()
        {
            foreach (MediaItem item in this.mediaItemFactory.GetItems())
            {
                Items.Add(item);
            }
        }

        private void Search(object commandParameter)
        {
            IEnumerable foundItems = this.mediaItemFactory.Search(SearchName);
            Items.Clear();
            foreach (MediaItem item in foundItems)
            {
                Items.Add(item);
            }
        }


        private void Clear(object commandParameter)
        {
            Items.Clear();
            SearchName = "";
            FillListBox();
        }
    }
}
