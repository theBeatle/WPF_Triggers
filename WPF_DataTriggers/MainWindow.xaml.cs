using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_DataTriggers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            //Countries myC = new Countries();
           // var x = myC[2];

        

        }


    }
    class Countries : ObservableCollection<Country>
    {
        public Countries()
        {
            this.Add(new Country("Ukraine", "UA"));
            this.Add(new Country("United Kingdom", "UK"));
            this.Add(new Country("United States of America", "USA"));
            this.Add(new Country("Italy", "ITL"));
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public Country()
        {

        }

        public Country(string name, string shortName)
        {
            Name = name;
            ShortName = shortName;
        }

        public override string ToString() => $" {Name} {ShortName}";

    } // Data Model
}
