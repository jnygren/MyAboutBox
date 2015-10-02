using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;

namespace MyAboutBox
{
    /// <summary>
    /// Interaction logic for AboutBox.xaml
    /// </summary>
    public partial class AboutBox : Window
    {

        public AboutBox()
        {
            InitializeComponent();

            string s = AssemblyTitle;
        }

        public string AssemblyTitle
        {
            get 
            {
                string title = Assembly.GetExecutingAssembly().FullName;

                return title;
            }
        }

    }
}
