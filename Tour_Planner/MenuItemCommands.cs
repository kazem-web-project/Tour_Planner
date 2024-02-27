using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Tour_Planner
{
    public class MenuItemCommands
    {
        public class ToursMenuCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                // Implement logic to determine if the "TOURS" menu can be executed
                return true; // Replace with your actual logic
            }

            public void Execute(object parameter)
            {
                // Implement the action for the "TOURS" menu click
                MessageBox.Show("TOURS menu clicked!"); // Replace with your actual action
            }
        }

        public class FileMenuCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                // Implement logic to determine if the "TOURS" menu can be executed
                return true; // Replace with your actual logic
            }

            public void Execute(object parameter)
            {
                // Implement the action for the "TOURS" menu click
                MessageBox.Show("FILE menu clicked!"); // Replace with your actual action
            }
        }

        public class EditMenuCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                // Implement logic to determine if the "TOURS" menu can be executed
                return true; // Replace with your actual logic
            }

            public void Execute(object parameter)
            {
                // Implement the action for the "TOURS" menu click
                MessageBox.Show("EDIT menu clicked!"); // Replace with your actual action
            }
        }

        public class SettingsMenuCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                // Implement logic to determine if the "TOURS" menu can be executed
                return true; // Replace with your actual logic
            }

            public void Execute(object parameter)
            {
                // Implement the action for the "TOURS" menu click
                MessageBox.Show("SETTINGS menu clicked!"); // Replace with your actual action
            }
        }

    }
}
