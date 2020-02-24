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
        decimal temptotal = 0;
        bool newtotal;
        int sign = 1;

        enum operations
        {
            idle,
            plus,
            minus,
            multiply,
            divide
        };

        operations operation;

        public MainWindow()
        {
            InitializeComponent();
            m_data = new ConfigurationData();
            this.DataContext = m_data;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {

            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (1 * sign);
            }
            else
            {
                m_data.total = 1;
            }
            if (newtotal)
            {
                m_data.total = 1;
                newtotal = false;
            }

        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (2 * sign);
            }
            else
            {
                m_data.total = 2;
            }
            if (newtotal)
            {
                m_data.total = 2;
                newtotal = false;
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (3 * sign);
            }
            else
            {
                m_data.total = 3;
            }
            if (newtotal)
            {
                m_data.total = 3;
                newtotal = false;
            }
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (4 * sign);
            }
            else
            {
                m_data.total = 4;
            }
            if (newtotal)
            {
                m_data.total = 4;
                newtotal = false;
            }
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (5 * sign);
            }
            else
            {
                m_data.total = 5;
            }
            if (newtotal)
            {
                m_data.total = 5;
                newtotal = false;
            }
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (6 * sign);
            }
            else
            {
                m_data.total = 6;
            }
            if (newtotal)
            {
                m_data.total = 6;
                newtotal = false;
            }
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (7 * sign);
            }
            else
            {
                m_data.total = 7;
            }
            if (newtotal)
            {
                m_data.total = 7;
                newtotal = false;
            }
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (8 * sign);
            }
            else
            {
                m_data.total = 8;
            }
            if (newtotal)
            {
                m_data.total = 8;
                newtotal = false;
            }
        }
        private void B9_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += (9 * sign);
            }
            else
            {
                m_data.total = 9;
            }
            if (newtotal)
            {
                m_data.total = 9;
                newtotal = false;
            }
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            if (m_data.total != 0)
            {
                m_data.total *= 10;
                m_data.total += 0;
            }
            else
            {
                m_data.total = 0;
            }
            if (newtotal)
            {
                m_data.total = 0;
                newtotal = false;
            }
        }


        /* Operation Buttons*/

        private void BPlus_Click(object sender, RoutedEventArgs e)
        {
            temptotal = m_data.total;
            operation = operations.plus;
            newtotal = true;
        }

        private void BMinus_Click(object sender, RoutedEventArgs e)
        {
            temptotal = m_data.total;
            operation = operations.minus;
            newtotal = true;
        }

        private void BMultiply_Click(object sender, RoutedEventArgs e)
        {
            temptotal = m_data.total;
            operation = operations.multiply;
            newtotal = true;
        }

        private void BDivide_Click(object sender, RoutedEventArgs e)
        {
            temptotal = m_data.total;
            operation = operations.divide;
            newtotal = true;
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            m_data.total = 0;
            temptotal = 0;
            sign = 1;
        }

        private void BPosNeg_Click(object sender, RoutedEventArgs e)
        {
            m_data.total *= -1;
            sign = (sign * -1);
        }

        private void BEquals_Click(object sender, RoutedEventArgs e)
        {

            switch(operation)
            {
                case operations.plus:
                    {
                        m_data.total += temptotal;
                        temptotal = 0;
                        sign = 1;
                        operation = operations.idle;
                        break;
                    }
                case operations.minus:
                    {
                        m_data.total = (temptotal - m_data.total);
                        temptotal = 0;
                        sign = 1;
                        operation = operations.idle;
                        break;
                    }
                case operations.multiply:
                    {
                        m_data.total *= temptotal;
                        temptotal = 0;
                        sign = 1;
                        operation = operations.idle;
                        break;
                    }
                case operations.divide:
                    {
                        m_data.total = (temptotal / m_data.total);
                        temptotal = 0;
                        sign = 1;
                        operation = operations.idle;
                        break;
                    }
                default: break;
            }
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

