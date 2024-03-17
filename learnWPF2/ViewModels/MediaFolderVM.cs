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


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        Text:>>>>>>>>>>>>>>>

        private string dateTimeText;
        private string difficultyText;
        private string distanceText;
        private string durationText;
        private string ratingText;
        private string commentText;


        public string DateTimeText
        {
            get
            {
                return dateTimeText;
            }

            set
            {
                if (dateTimeText != value)
                {
                    dateTimeText = value;
                    RaisePropertyChangedEvent(nameof(DateTimeText));
                }
            }
        }
        public string CommentText
        {
            get
            {
                return commentText;
            }

            set
            {
                if (commentText != value)
                {
                    commentText = value;
                    RaisePropertyChangedEvent(nameof(CommentText));
                }
            }
        }

        public string DifficultyText
        {
            get
            {
                return difficultyText;
            }

            set
            {
                if (difficultyText != value)
                {
                    difficultyText = value;
                    RaisePropertyChangedEvent(nameof(DifficultyText));
                }
            }
        }

        public string DistanceText
        {
            get
            {
                return distanceText;
            }

            set
            {
                if (distanceText != value)
                {
                    distanceText = value;
                    RaisePropertyChangedEvent(nameof(DistanceText));
                }
            }
        }

        public string DurationText
        {
            get
            {
                return durationText;
            }

            set
            {
                if (durationText != value)
                {
                    durationText = value;
                    RaisePropertyChangedEvent(nameof(DurationText));
                }
            }
        }

        public string RatingText
        {
            get
            {
                return ratingText;
            }

            set
            {
                if (ratingText != value)
                {
                    ratingText = value;
                    RaisePropertyChangedEvent(nameof(RatingText));
                }
            }
        }





        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        <<<<<<<<<<<<<<<<<<<<<




        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        BUTTONS:
        private RelayCommand saveCommand;
        private RelayCommand removeCommand;
        private RelayCommand clearFormCommand;
        public ICommand ClearFormCommand => clearFormCommand ??= new RelayCommand(ClearForm);

        private void ClearForm(object commandParameter)
        {
            DifficultyText = "";
            RatingText = "";
            DurationText = "";
            DistanceText = "";
            DateTimeText = "";
            CommentText = "";
        }

        public ICommand SaveCommand => saveCommand ??= new RelayCommand(SaveTourLog);

        private void SaveTourLog(object commandParameter)
        {
            throw new NotImplementedException();
        }

        public ICommand RemoveCommand => removeCommand ??= new RelayCommand(RemoveTourLog);

        private void RemoveTourLog(object commandParameter)
        {
            // TODO. implement Remove and clear all text inputs
            throw new NotImplementedException();
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
