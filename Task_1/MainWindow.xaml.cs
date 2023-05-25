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

namespace Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int countText = 0;
        public MainWindow()
        {
            InitializeComponent();

        }
        public void MainWindow_Load(object sender, EventArgs e)
        {
            
           
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bntAddName_Click(object sender, RoutedEventArgs e)
        {
            if(txtBoxName.Text!="") 
            {
                nameBlock.Text += ++countText+". "+txtBoxName.Text+"\n";
                txtBoxName.Text = "";
            }
        }

        private void bntClearAll_Click(object sender, RoutedEventArgs e)
        {
            nameBlock.Text = "";
            countText = 0;
        }
    }
}
