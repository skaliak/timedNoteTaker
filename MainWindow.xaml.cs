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

namespace timedNoteTaker
{
     /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
     public partial class MainWindow : Window
     {
          public MainWindow()
          {
               //delay startup so splash screen shows up
               System.Threading.Thread.Sleep(1000);
               InitializeComponent();
          }

          void theTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
          {
               if (e.Key == Key.Enter)
               {
                    //when enter is pressed, append timestamp plus test to the notes box
                    notesBox.Text += "\n" + DateTime.Now + "\t" + theTextBox.Text;
                    theTextBox.Text = "";
               }
          }

          private void copyButton_Click(object sender, RoutedEventArgs e)
          {
               Clipboard.SetText(notesBox.Text);
          }

     }
}
