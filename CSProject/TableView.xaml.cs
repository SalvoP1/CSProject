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

        bool pictureCheck_1 = false;
        bool pictureCheck_2 = false;
        bool pictureCheck_3 = false;

        // Menue Gerichte
        public string[] Vorspeisen { get; set; }
        public string[] Gang_1 { get; set; }
        public string[] Gang_2 { get; set; }
        public string[] Nachspeise { get; set; }

        public TableView()
        {
            InitializeComponent();
            // Vorspeisen
            Vorspeisen = new string[] {
                " << LEER >> ",
                "Teufelseier",
                "Spinat-Lachs-Rolle",
                "Bacon-Mozzarella-Bombe",
                "Blätterteigrosen mit Aubergine",
                "Bruschetta"
            };
            // Erster Gang
            Gang_1 = new string[] {
                " << LEER >> ",
                "Penne mit Kichererbsencreme",
                "Hackfleischpfanne",
                "Nudelnester",
                "Mango-Papaya Chutney",
                "Hähnchenbrust mit Gemüse"
            };
            // Zweiter Gang
            Gang_2 = new string[] {
                " << LEER >> ",
                "Lachs-Orangen-Tatar",
                "Ramen-suppe",
                "Reisauflauf Wiener art",
                "Ravioli mit Lachs",
                "Lasagne mit Spinat"
            };
            // Nachspeise
            Nachspeise = new string[] {
                " << LEER >> ",
                "Tiramisu",
                "Schoko-Truffel",
                "Zitronen-Sorbet",
                "Crème Brûlée",
                "Karamell-Pudding"
            };

            // Initializing Comboboxes for TableView
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


        // save & quit event
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            SaveTable();
            Back?.Invoke(sender, e);
        }

        public void LoadTable(Tische pTisch)
        {
            this.Tisch = pTisch;
            // String Interpolation, nice to know hehe
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

        // Maintain The Collected Data
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

        // Easter Egg
        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {

            Button button = sender as Button;

            // Clicked first Person
            if (button.Name == "Person_1")
            {
                if (pictureCheck_1)
                    Bild_Person_1.Source = new BitmapImage(new Uri("https://cdn.discordapp.com/attachments/632532634051805185/956454543741321226/default_user_male.png"));
                else
                    Bild_Person_1.Source = new BitmapImage(new Uri("https://cdn.discordapp.com/attachments/632532634051805185/956451346712772648/default_user_female.png"));
                pictureCheck_1 = !pictureCheck_1;
            }
            // Clicked second Person
            if (button.Name == "Person_2")
            {
                if (pictureCheck_2)
                    Bild_Person_2.Source = new BitmapImage(new Uri("https://cdn.discordapp.com/attachments/632532634051805185/956451346712772648/default_user_female.png"));
                else
                    Bild_Person_2.Source = new BitmapImage(new Uri("https://cdn.discordapp.com/attachments/632532634051805185/956454543741321226/default_user_male.png"));
                pictureCheck_2 = !pictureCheck_2;
            }
            // Clicked third Person
            if (button.Name == "Person_3")
            {
                if (pictureCheck_3)
                    Bild_Person_3.Source = new BitmapImage(new Uri("https://cdn.discordapp.com/attachments/632532634051805185/956454543741321226/default_user_male.png"));
                else
                    Bild_Person_3.Source = new BitmapImage(new Uri("https://cdn.discordapp.com/attachments/632532634051805185/956451346712772648/default_user_female.png"));
                pictureCheck_3 = !pictureCheck_3;
            }

        }
    }
}
