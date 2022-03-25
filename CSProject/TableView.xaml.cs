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
        public string[] vorspeisen { get; set; }
        public string[] gang_1 { get; set; }
        public string[] gang_2 { get; set; }
        public string[] nachspeise { get; set; }

        public TableView()
        {
            InitializeComponent();

            vorspeisen = new string[] {"Teufelseier", "Spinat-Lachs-Rolle", "Bacon-Mozzarella-Bombe", "Blätterteigrosen mit Aubergine", "Bruschetta" };
            gang_1 = new string[] {"Penne mit Kichererbsencreme", "Hackfleischpfanne", "Nudelnester", "Mango-Papaya Chutney", "Hähnchenbrust mit Gemüse" };
            gang_2 = new string[] {"Lachs-Orangen-Tatar", "Ramen-suppe", "Reisauflauf Wiener art", "Ravioli mit Lachs", "" };
            nachspeise = new string[] { "Tiramisu", "Schoko-Truffel", "Zitronen-Sorbet", "Crème Brûlée", "Karamell-Pudding" };

        }
    }
}
