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

namespace Pizza_Oefening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Global vars
        //Aantallen van pizza's
        int MargaritaX = 0;
        int SucukX = 0;
        int ChampignonsX = 0;
        int HawaiiX = 0;
        int DonerX = 0;
        int VeggieX = 0;
        int NonveggieX = 0;

        private void PizzaButton_Click(object sender, RoutedEventArgs e)
        {
            //Wie is de sender?
            Button Btn = (Button)sender;

            //Voer actie uit.
            switch (Btn.Name)
            {
                case "BtnMargaritaMin":
                    {
                        MargaritaX--;
                        break;
                    }
                case "BtnMargaritaPlus":
                    {
                        MargaritaX++;
                        break;
                    }
                case "BtnSucukMin":
                    {
                        SucukX--;
                        break;
                    }
                case "BtnSucukPlus":
                    {
                        SucukX++;
                        break;
                    }
                case "BtnChampignonsMin":
                    {
                        ChampignonsX--;
                        break;
                    }
                case "BtnChampignonsPlus":
                    {
                        ChampignonsX++;
                        break;
                    }
                case "BtnHawaiiMin":
                    {
                        HawaiiX--;
                        break;
                    }
                case "BtnHawaiiPlus":
                    {
                        HawaiiX++;
                        break;
                    }
                case "BtnDonerMin":
                    {
                        DonerX--;
                        break;
                    }
                case "BtnDonerPlus":
                    {
                        DonerX++;
                        break;
                    }
                case "BtnVeggieMin":
                    {
                        VeggieX--;
                        break;
                    }
                case "BtnVeggiePlus":
                    {
                        VeggieX++;
                        break;
                    }
                case "BtnNonveggieMin":
                    {
                        NonveggieX--;
                        break;
                    }
                case "BtnNonveggiePlus":
                    {
                        NonveggieX++;
                        break;
                    }
            }

            //Verniew
            RefreshValues();
        }

        private void RefreshValues()
        {
            //Limiten overschreden?
            if (MargaritaX > 10)
            {
                MargaritaX = 10;
            }
            else if (MargaritaX < 0)
            {
                MargaritaX = 0;
            }

            if (SucukX > 10)
            {
                SucukX = 10;
            }
            else if (SucukX < 0)
            {
                SucukX = 0;
            }

            if (ChampignonsX > 10)
            {
                ChampignonsX = 10;
            }
            else if (ChampignonsX < 0)
            {
                ChampignonsX = 0;
            }

            if (HawaiiX > 10)
            {
                HawaiiX = 10;
            }
            else if (HawaiiX < 0)
            {
                HawaiiX = 0;
            }

            if (DonerX > 10)
            {
                DonerX = 10;
            }
            else if (DonerX < 0)
            {
                DonerX = 0;
            }

            if (VeggieX > 10)
            {
                VeggieX = 10;
            }
            else if (VeggieX < 0)
            {
                VeggieX = 0;
            }

            if (NonveggieX > 10)
            {
                NonveggieX = 10;
            }
            else if (NonveggieX < 0)
            {
                NonveggieX = 0;
            }

            //Toon Nummers
            TxtMargarita.Text = MargaritaX.ToString();
            TxtSucuk.Text = SucukX.ToString();
            TxtChampignons.Text = ChampignonsX.ToString();
            TxtHawaii.Text = HawaiiX.ToString();
            TxtDoner.Text = DonerX.ToString();
            TxtVeggie.Text = VeggieX.ToString();
            TxtNonveggie.Text = NonveggieX.ToString();
        }
    }
}
