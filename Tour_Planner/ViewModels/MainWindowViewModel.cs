
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using static Tour_Planner.MenuItemCommands;

namespace Tour_Planner
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        public string TourSearchText { get; set; } = "Suche...";
        public List<MenuItemModel> MainMenuItems;


        public MainWindowViewModel()
        {

            MainMenuItems = new()
            {
                new () { Text="TOURS", Command = new ToursMenuCommand() },
                new () { Text="FILE", Command = new FileMenuCommand() },
                new() { Text = "EDIT", Command = new EditMenuCommand() },
                new() { Text = "SETTINGS", Command = new SettingsMenuCommand() }
            };
        }

        private void SearchTourButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("SearchTours Button Clicked");
            MessageBox.Show($"Searching for {TourSearchText}"); // Replace with your actual action
        }
        private void OnWindowLoaded(object Sender, RoutedEventArgs e)
        {
            UpdateMinHeight();
        }

        private void OnWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateMinHeight();
        }

        private void UpdateMinHeight()
        {
            //double _windowHeight = this.ActualHeight;
            //double _minimumHeight = _windowHeight / 3;

            //MainTopRow.MinHeight = _minimumHeight;
            //MainBottomRow.MinHeight = _minimumHeight;
        }

    }
}
