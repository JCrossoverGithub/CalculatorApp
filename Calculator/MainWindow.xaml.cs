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
using System.ComponentModel;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ConfigurationData m_data;

        public MainWindow()
        {
            InitializeComponent();
            m_data = new ConfigurationData();
            this.DataContext = m_data;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if(m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 1;
            }
            else
            {
                m_data.total = 1;
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 2;
            }
            else
            {
                m_data.total = 2;
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 3;
            }
            else
            {
                m_data.total = 3;
            }
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 4;
            }
            else
            {
                m_data.total = 4;
            }
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 5;
            }
            else
            {
                m_data.total = 5;
            }
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 6;
            }
            else
            {
                m_data.total = 6;
            }
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 7;
            }
            else
            {
                m_data.total = 7;
            }
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 8;
            }
            else
            {
                m_data.total = 8;
            }
        }
        // TESTSTSTSTT
        private void BPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            m_data.total = 0;
        }

        private void BSplit_Click(object sender, RoutedEventArgs e)
        {
            m_data.total /= 2;
        }
    }
    public class ConfigurationData : INotifyPropertyChanged
    {
        private decimal _total;
        public decimal total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged("total"); }
        }

        //below is the boilerplate code supporting PropertyChanged events:
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

