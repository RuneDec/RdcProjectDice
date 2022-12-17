using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace RuneDecProjectDice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArduinoPort _arduinoPort = new ArduinoPort("COM8", 9600);
        int milliseconds = 1100;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random1 = new Random();
            int dobbelsteen1 = random1.Next(1, 7);
            TxtBl1.Text = dobbelsteen1.ToString();
            _arduinoPort.WriteToPort("31");
            Thread.Sleep(milliseconds);
            _arduinoPort.WriteToPort(TxtBl1.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random random2 = new Random();
            int dobbelsteen2 = random2.Next(1, 7);
            TxtBl2.Text = dobbelsteen2.ToString();
            _arduinoPort.WriteToPort("32");
            Thread.Sleep(milliseconds);
            _arduinoPort.WriteToPort(TxtBl2.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random random3 = new Random();
            int dobbelsteen3 = random3.Next(1, 21);
            TxtBl3.Text = dobbelsteen3.ToString();
            _arduinoPort.WriteToPort("33");
            Thread.Sleep(milliseconds);
            _arduinoPort.WriteToPort(TxtBl3.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TxtBl1.Text = (" ");
            TxtBl2.Text = (" ");
            TxtBl3.Text = (" ");
            _arduinoPort.WriteToPort("34");
        }
    }
}
