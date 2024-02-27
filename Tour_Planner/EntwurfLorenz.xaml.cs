using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Tour_Planner.MenuItemCommands;


namespace Tour_Planner
{
    /// <summary>
    /// Interaction logic for EntwurfLorenz.xaml
    /// </summary>
    public partial class EntwurfLorenz : Window, INotifyPropertyChanged
    {
        public string TourSearchText { get; set; } = "Suche..." ;
        public EntwurfLorenz()
        {
            InitializeComponent();
            this.Loaded += OnWindowLoaded;
            this.SizeChanged += OnWindowSizeChanged;

            var menuItems = new List<MenuItemModel>()
            {
                new() { Text="TOURS", Command = new ToursMenuCommand() },
                new() { Text="FILE", Command = new FileMenuCommand() },
                new() { Text="EDIT", Command = new EditMenuCommand() },
                new() { Text="SETTINGS", Command = new SettingsMenuCommand() }
            };

            MainMenuControl.ItemsSource = menuItems;
        }

        public event PropertyChangedEventHandler? PropertyChanged;  // during initialization the engine registers itself to listen to PropertyChanged events

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
            double _windowHeight = this.ActualHeight;
            double _minimumHeight = _windowHeight / 3;

            MainTopRow.MinHeight = _minimumHeight;
            MainBottomRow.MinHeight = _minimumHeight;
        }
    }
    public class MenuItemModel
    {
        public required string Text { get; set; }
        public required ICommand Command { get; set; }
    }

    public class MenuItemModelCommand : ICommand // Example implementing ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // Implement logic to determine if the command can be executed
            return true; // Replace with your actual logic
        }

        public void Execute(object parameter)
        {
            // Implement the action for the menu item
            MessageBox.Show("Menu item clicked!"); // Replace with your actual logic
        }
    }
}
