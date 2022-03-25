using System;
using System.Collections.Generic;
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

namespace CSProject
{
    public partial class TableView : UserControl
    {
        // Menue Gerichte
        public string[] Vorspeisen { get; set; }
        public string[] Gang_1 { get; set; }
        public string[] Gang_2 { get; set; }
        public string[] Nachspeise { get; set; }

        public TableView()
        {
            InitializeComponent();

            Vorspeisen = new string[] {
                " << LEER >> ",
                "Teufelseier", 
                "Spinat-Lachs-Rolle", 
                "Bacon-Mozzarella-Bombe", 
                "Blätterteigrosen mit Aubergine", 
                "Bruschetta" 
            };

            Gang_1 = new string[] {
                " << LEER >> ",
                "Penne mit Kichererbsencreme", 
                "Hackfleischpfanne", 
                "Nudelnester", 
                "Mango-Papaya Chutney", 
                "Hähnchenbrust mit Gemüse" 
            };

            Gang_2 = new string[] {
                " << LEER >> ",
                "Lachs-Orangen-Tatar", 
                "Ramen-suppe", 
                "Reisauflauf Wiener art", 
                "Ravioli mit Lachs", 
                "Lasagne mit Spinat" 
            };

            Nachspeise = new string[] {
                " << LEER >> ",
                "Tiramisu", 
                "Schoko-Truffel", 
                "Zitronen-Sorbet", 
                "Crème Brûlée", 
                "Karamell-Pudding" 
            };


            Vorspeise_1.ItemsSource = Vorspeisen;
            Vorspeise_1.SelectedIndex = 0;

            Vorspeise_2.ItemsSource = Vorspeisen;
            Vorspeise_2.SelectedIndex = 0;

            Vorspeise_3.ItemsSource = Vorspeisen;
            Vorspeise_3.SelectedIndex = 0;

            Gang_1_1.ItemsSource = Gang_1;
            Gang_1_1.SelectedIndex = 0;

            Gang_1_2.ItemsSource = Gang_1;
            Gang_1_2.SelectedIndex = 0;

            Gang_1_3.ItemsSource = Gang_1;
            Gang_1_3.SelectedIndex = 0;

            Gang_2_1.ItemsSource = Gang_2;
            Gang_2_1.SelectedIndex = 0;

            Gang_2_2.ItemsSource = Gang_2;
            Gang_2_2.SelectedIndex = 0;

            Gang_2_3.ItemsSource = Gang_2;
            Gang_2_3.SelectedIndex = 0;

            Nachspeise_1.ItemsSource = Nachspeise;
            Nachspeise_1.SelectedIndex = 0;

            Nachspeise_2.ItemsSource = Nachspeise;
            Nachspeise_2.SelectedIndex = 0;

            Nachspeise_3.ItemsSource = Nachspeise;
            Nachspeise_3.SelectedIndex = 0;

        }
    }
}
