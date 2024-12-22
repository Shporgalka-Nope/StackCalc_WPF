using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
using System.Xml.Linq;

namespace WPFStackCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _displayText;
        public string displayText 
        {  
            get { return _displayText; } 
            set 
            {  
                _displayText = value;
                OnPropertyChanged("displayText");
            } 
        }

        private string _displayResult;
        public string displayResult 
        { 
            get { return _displayResult; }
            set 
            { 
                _displayResult = value;
                OnPropertyChanged("displayResult");
            }
        }

        private Calc newCalc = new Calc();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void One(object sender, RoutedEventArgs e) { displayText += "1"; }
        private void Two(object sender, RoutedEventArgs e) { displayText += "2"; }
        private void Tree(object sender, RoutedEventArgs e) { displayText += "3"; }
        private void Four(object sender, RoutedEventArgs e) { displayText += "4"; }
        private void Five(object sender, RoutedEventArgs e) { displayText += "5"; }
        private void Six(object sender, RoutedEventArgs e) { displayText += "6"; }
        private void Seven(object sender, RoutedEventArgs e) { displayText += "7"; }
        private void Eight(object sender, RoutedEventArgs e) { displayText += "8"; }
        private void Nine(object sender, RoutedEventArgs e) { displayText += "9"; }
        private void Zero(object sender, RoutedEventArgs e) { displayText += "0"; }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (displayText.Length < 1) { return; }
            string str = "";
            for (int i = 0; i < displayText.Length-1; i++)
            {
                if (i == displayText.Length - 1) { break; }
                str += displayText[i];
            }
            displayText = str;
        }

        private void Plus(object sender, RoutedEventArgs e) { displayText += " + "; }
        private void Minus(object sender, RoutedEventArgs e) { displayText += " - "; }
        private void Myl(object sender, RoutedEventArgs e) { displayText += " * "; }
        private void Div(object sender, RoutedEventArgs e) { displayText += " / "; }
        private void LeftBr(object sender, RoutedEventArgs e) { displayText += "( "; }
        private void RightBr(object sender, RoutedEventArgs e) { displayText += " )"; }
        private void Sqrt(object sender, RoutedEventArgs e) { displayText += " ^"; }

        private void Result(object sender, RoutedEventArgs e) 
        {
            try
            {
                displayResult = newCalc.AUTOIdentify(displayText);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}