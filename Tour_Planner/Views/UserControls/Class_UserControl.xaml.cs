using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tour_Planner.Views.UserControls
{
    public partial class Class_UserControl : UserControl
    {
        public string _buttonText;
        public Class_UserControl(string text)
        {
            this._buttonText = text;
            InitializeComponent();
        }
    }
}
