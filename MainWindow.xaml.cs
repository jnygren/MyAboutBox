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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyAboutBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //      Commands
        // The Execute and CanExecute methods on a RoutedCommand do not contain the command logic for the command.
        // These methods raise events that traverse the element tree looking for an object with a CommandBinding. The event handlers attached to the CommandBinding contain the command logic. 
        // The Execute method raises the PreviewExecuted and Executed events.
        //public static RoutedUICommand ExitCommand;
            // Note1: added 'static'.
        //public RoutedUICommand AboutCommand;

        public MainWindow()
        {
            //ExitCommand = new RoutedUICommand("Exit", "Exit", typeof(MainWindow));
            //AboutCommand = new RoutedUICommand("About", "About", typeof(MainWindow));

            InitializeComponent();
        }


        //public void About(Object sender, ExecutedRoutedEventArgs e)
        //{
        //    MessageBox.Show("About...");
        //}


        public void About(object sender, RoutedEventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }


        #region This Command Shit doesn't work!!!
        // Commands
        // ExecutedRoutedEventHandler
        public void ExitHandler(Object sender, ExecutedRoutedEventArgs e)
        {
            //RoutedCommand h = ApplicationCommands.Help;
            Application.Current.Shutdown();
            e.Handled = true;
        }

        //CanExecuteRoutedEventHandler 
        public void ExitCanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.Handled = true;
        }
        #endregion


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
