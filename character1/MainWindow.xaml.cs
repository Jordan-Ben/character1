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

namespace character1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Char character = new Char();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PetalNextButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayPetal.Source = character.GetNextPetal();
        }

        private void StemNextButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayStem.Source = character.GetNextStem();
        }

        private void LeafNextButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayLeaf.Source = character.GetNextLeaf();
        }
    }
}
