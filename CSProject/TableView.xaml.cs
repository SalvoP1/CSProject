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
        public event EventHandler Back;

        public Tische Tisch;

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


        // Trigger return button event
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            SaveTable();
            Back?.Invoke(sender, e);
        }

        public void LoadTable(Tische pTisch)
        {
            this.Tisch = pTisch;
            // String Interpolation
            TableTitle.Content = $"Tisch {Tisch.TischNr}";

            // Person 1:
            Vorspeise_1.SelectedIndex = Tisch.Vorspeise_1;
            Gang_1_1.SelectedIndex = Tisch.Gang_1_1;
            Gang_2_1.SelectedIndex = Tisch.Gang_2_1;
            Nachspeise_1.SelectedIndex = Tisch.Nachspeise_1;

            // Person 2:
            Vorspeise_2.SelectedIndex = Tisch.Vorspeise_2;
            Gang_1_2.SelectedIndex = Tisch.Gang_1_2;
            Gang_2_2.SelectedIndex = Tisch.Gang_2_2;
            Nachspeise_2.SelectedIndex = Tisch.Nachspeise_2;

            // Person 3:

            Vorspeise_3.SelectedIndex = Tisch.Vorspeise_3;
            Gang_1_3.SelectedIndex = Tisch.Gang_1_3;
            Gang_2_3.SelectedIndex = Tisch.Gang_2_3;
            Nachspeise_3.SelectedIndex = Tisch.Nachspeise_3;
        }

        private void SaveTable()
        {
            // Person 1:
            Tisch.Vorspeise_1 = Vorspeise_1.SelectedIndex;
            Tisch.Gang_1_1 = Gang_1_1.SelectedIndex;
            Tisch.Gang_2_1 = Gang_2_1.SelectedIndex;
            Tisch.Nachspeise_1 = Nachspeise_1.SelectedIndex;

            // Person 2:
            Tisch.Vorspeise_2 = Vorspeise_2.SelectedIndex;
            Tisch.Gang_1_2 = Gang_1_2.SelectedIndex;
            Tisch.Gang_2_2 = Gang_2_2.SelectedIndex;
            Tisch.Nachspeise_2 = Nachspeise_2.SelectedIndex;

            // Person 3:
            Tisch.Vorspeise_3 = Vorspeise_3.SelectedIndex;
            Tisch.Gang_1_3 = Gang_1_3.SelectedIndex;
            Tisch.Gang_2_3 = Gang_2_3.SelectedIndex;
            Tisch.Nachspeise_3 = Nachspeise_3.SelectedIndex;
        }

    }
}
