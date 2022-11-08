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
using System.Windows.Threading;

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
            DispatcherTimer Timer1 = new DispatcherTimer();
            Timer1.Interval = TimeSpan.FromSeconds(5);
            Timer1.Tick += Timer1_Tick;
            Timer1.Start();
        }


        ///Global vars
        //Aantallen van pizza's
        int MargaritaX = 0;
        int SucukX = 0;
        int ChampignonsX = 0;
        int HawaiiX = 0;
        int DonerX = 0;
        int VeggieX = 0;
        int NonveggieX = 0;
        int TotaalPizzas = 0;
        //Prijzen
        float MargaritaPrijs;
        float SucukPrijs;
        float ChampignonsPrijs;
        float HawaiiPrijs;
        float DonerPrijs;
        float VeggiePrijs;
        float NonveggiePrijs;
        //BestelNR
        int BestelNr = 0;
        //GegevensLog
        string Naam;
        string Telefoonnummer;
        string Email;
        string Adres;
        string Woonplaats;
        string Postcode;
        //Disptachtimer Image counter
        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Count
            if (i != 5) i++;
            else i = 1;

            //Change image
            switch (i)
            {
                case 1:
                    {
                        ImgPizza.Source = new BitmapImage(new Uri("/Pizza_Images/Pizza2.png", UriKind.Relative));
                        break;
                    }
                case 2:
                    {
                        ImgPizza.Source = new BitmapImage(new Uri("/Pizza_Images/Pizza3.jpg", UriKind.Relative));
                        break;
                    }
                case 3:
                    {
                        ImgPizza.Source = new BitmapImage(new Uri("/Pizza_Images/Pizza4.jpg", UriKind.Relative));
                        break;
                    }
                case 4:
                    {
                        ImgPizza.Source = new BitmapImage(new Uri("/Pizza_Images/Pizza5.png", UriKind.Relative));
                        break;
                    }
                case 5:
                    {
                        ImgPizza.Source = new BitmapImage(new Uri("/Pizza_Images/Pizza1.png", UriKind.Relative));
                        break;
                    }
            }
        }

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

            //Hou totaal aantal pizzas bij
            TotaalPizzas = MargaritaX + SucukX + ChampignonsX + HawaiiX + DonerX + VeggieX + NonveggieX;

            //Pas slider aan
            SldMargarita.Value = MargaritaX;
            SldSucuk.Value = SucukX;
            SldChampignons.Value = ChampignonsX;
            SldHawaii.Value = HawaiiX;
            SldDoner.Value = DonerX;
            SldVeggie.Value = VeggieX;
            SldNonveggie.Value = NonveggieX;

            //Toon Nummers
            TxtMargarita.Text = MargaritaX.ToString();
            TxtSucuk.Text = SucukX.ToString();
            TxtChampignons.Text = ChampignonsX.ToString();
            TxtHawaii.Text = HawaiiX.ToString();
            TxtDoner.Text = DonerX.ToString();
            TxtVeggie.Text = VeggieX.ToString();
            TxtNonveggie.Text = NonveggieX.ToString();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;

            switch (slider.Name)
            {
                case "SldMargarita":
                    {
                        MargaritaX = Convert.ToInt16(slider.Value);
                        break;
                    }
                case "SldSucuk":
                    {
                        SucukX = Convert.ToInt16(slider.Value);
                        break;
                    }
                case "SldChampignons":
                    {
                        ChampignonsX = Convert.ToInt16(slider.Value);
                        break;
                    }
                case "SldHawaii":
                    {
                        HawaiiX = Convert.ToInt16(slider.Value);
                        break;
                    }
                case "SldDoner":
                    {
                        DonerX = Convert.ToInt16(slider.Value);
                        break;
                    }
                case "SldVeggie":
                    {
                        VeggieX = Convert.ToInt16(slider.Value);
                        break;
                    }
                case "SldNonveggie":
                    {
                        NonveggieX = Convert.ToInt16(slider.Value);
                        break;
                    }
            }

            RefreshValues();
        }

        private void Txtbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox TXT = (TextBox)sender;

            switch (TXT.Name)
            {
                case "TxtMargarita":
                    {
                        //Fout procedure
                        bool Gelukt = int.TryParse(TXT.Text, out int i);
                        if (!Gelukt)
                        {
                            TxtMargarita.Text = MargaritaX.ToString();
                            return;
                        }

                        //Verander waarde
                        MargaritaX = i;
                        RefreshValues();
                        break;
                    }
                case "TxtSucuk":
                    {
                        //Fout procedure
                        bool Gelukt = int.TryParse(TXT.Text, out int i);
                        if (!Gelukt)
                        {
                            TxtSucuk.Text = SucukX.ToString();
                            return;
                        }

                        //Verander waarde
                        SucukX = i;
                        RefreshValues();
                        break;
                    }
                case "TxtChampignons":
                    {
                        //Fout procedure
                        bool Gelukt = int.TryParse(TXT.Text, out int i);
                        if (!Gelukt)
                        {
                            TxtChampignons.Text = ChampignonsX.ToString();
                            return;
                        }

                        //Verander waarde
                        ChampignonsX = i;
                        RefreshValues();
                        break;
                    }
                case "TxtHawaii":
                    {
                        //Fout procedure
                        bool Gelukt = int.TryParse(TXT.Text, out int i);
                        if (!Gelukt)
                        {
                            TxtHawaii.Text = HawaiiX.ToString();
                            return;
                        }

                        //Verander waarde
                        HawaiiX = i;
                        RefreshValues();
                        break;
                    }
                case "TxtDoner":
                    {
                        //Fout procedure
                        bool Gelukt = int.TryParse(TXT.Text, out int i);
                        if (!Gelukt)
                        {
                            TxtDoner.Text = DonerX.ToString();
                            return;
                        }

                        //Verander waarde
                        DonerX = i;
                        RefreshValues();
                        break;
                    }
                case "TxtVeggie":
                    {
                        //Fout procedure
                        bool Gelukt = int.TryParse(TXT.Text, out int i);
                        if (!Gelukt)
                        {
                            TxtVeggie.Text = VeggieX.ToString();
                            return;
                        }

                        //Verander waarde
                        VeggieX = i;
                        RefreshValues();
                        break;
                    }
                case "TxtNonveggie":
                    {
                        //Fout procedure
                        bool Gelukt = int.TryParse(TXT.Text, out int i);
                        if (!Gelukt)
                        {
                            TxtNonveggie.Text = NonveggieX.ToString();
                            return;
                        }

                        //Verander waarde
                        NonveggieX = i;
                        RefreshValues();
                        break;
                    }

            }
        }

        private void Windows_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Txtbox_LostFocus(sender, e);
            }
        }

        private void PizzaTextbox_Changed(object sender, TextChangedEventArgs e)
        {
            TextBox TXT = (TextBox)sender;

            if (TXT.MaxLength == 2)
            {
                if (TXT.Text == "00") //Vermijd dubbel 0's
                {
                    TXT.Text = "0";
                    return;
                }
                else if (TXT.Text == "-0") //Vermijd -0
                {
                    TXT.Text = "0";
                    return;
                }

                //Respecteer Limieten
                //FoutProcedure
                bool gelukt = int.TryParse((string)TXT.Text, out int i);
                if (gelukt)
                {
                    //[Respecteer de limieten]
                    if (i < 0)
                    {
                        TXT.Text = "0";
                    }
                    else if (i > 10)
                    {
                        TXT.Text = "10";
                    }
                    //[Zet SelectionStart op laatste punt]
                    TXT.SelectionStart = TXT.Text.Length;
                }
            }
        }

        private void BtnBestel_Click(object sender, RoutedEventArgs e)
        {
            //Variabels
            StringBuilder order = new StringBuilder();
            float TotaalPrijs = 0;

            //Controleer orders
            if (TotaalPizzas == 0)
            {
                MessageBox.Show("Er zijn geen pizzas geselecteerd.", "Fout"); return;
            }

            //Indien Skip gegevens niet van toepassing, controleer gegevens.
            if (ChkSkipGegevens.IsChecked == false)
            {
                if (String.IsNullOrWhiteSpace(TxtNaam.Text))
                {
                    MessageBox.Show("Vul een naam in.", "Fout"); return;
                }
                else if (String.IsNullOrWhiteSpace(TxtTelefoonnummer.Text))
                {
                    MessageBox.Show("Vul een Telefoonnummer in.", "Fout"); return;
                }
                else if (String.IsNullOrWhiteSpace(TxtEmail.Text))
                {
                    MessageBox.Show("Vul een email in.", "Fout"); return;
                }
                else if (String.IsNullOrWhiteSpace(TxtAdres.Text))
                {
                    MessageBox.Show("Vul een adres in.", "Fout"); return;
                }
                else if (String.IsNullOrWhiteSpace(TxtWoonplaats.Text))
                {
                    MessageBox.Show("Vul een woonplaats in.", "Fout"); return;
                }
                else if (String.IsNullOrWhiteSpace(TxtPostcode.Text))
                {
                    MessageBox.Show("Vul een postcode in.", "Fout"); return;
                }
                else //Naam is bekend ==> Gebruik Header 1
                {
                    BestelNr++;
                    order.Append($"Bestelling voor {TxtNaam.Text}" + Environment.NewLine);
                }
            }
            else //Naam is onbekend ==> Gebruik Header 2
            {
                BestelNr++;
                order.Append($"Bestelling {BestelNr}:" + Environment.NewLine);
            }

             // [Voer order uit]
            //Voeg pizzas toe aan de order
            if (MargaritaX != 0)
            {
                MargaritaPrijs = MargaritaX * 6;
                TotaalPrijs += MargaritaPrijs;
                order.AppendLine($"[{MargaritaX}] Pizza Margarita");
                order.AppendLine($" ~ {MargaritaPrijs:c}");
            }
            if (SucukX != 0)
            {
                SucukPrijs = SucukX * 7;
                TotaalPrijs += SucukPrijs;
                order.AppendLine($"[{SucukX}] Pizza Sucuk");
                order.AppendLine($" ~ {SucukPrijs:c}");
            }
            if (ChampignonsX != 0)
            {
                ChampignonsPrijs = ChampignonsX * 6.5f;
                TotaalPrijs += ChampignonsPrijs;
                order.AppendLine($"[{ChampignonsX}] Pizza Champignons");
                order.AppendLine($" ~ {ChampignonsPrijs:c}");
            }
            if (HawaiiX != 0)
            {
                HawaiiPrijs = HawaiiX * 8;
                TotaalPrijs += HawaiiPrijs;
                order.AppendLine($"[{HawaiiX}] Pizza Hawaii");
                order.AppendLine($" ~ {HawaiiPrijs:c}");
            }
            if (DonerX != 0)
            {
                DonerPrijs = DonerX * 8.5f;
                TotaalPrijs += DonerPrijs;
                order.AppendLine($"[{DonerX}] Pizza Doner");
                order.AppendLine($" ~ {DonerPrijs:c}");
            }
            if (VeggieX != 0)
            {
                VeggiePrijs = VeggieX * 12.5f;
                TotaalPrijs += VeggiePrijs;
                order.AppendLine($"[{VeggieX}] Pizza Veggie");
                order.AppendLine($" ~ {VeggiePrijs:c}");
            }
            if (NonveggieX != 0)
            {
                NonveggiePrijs = NonveggieX * 5;
                TotaalPrijs += NonveggiePrijs;
                order.AppendLine($"[{NonveggieX}] Pizza Non Veggie");
                order.AppendLine($" ~ {NonveggiePrijs:c}");
            }
            order.AppendLine("-----------------------");
            
            //Voeg Toppings toe aan de order
            if (ChkAnjovis.IsChecked == true) 
            {
                TotaalPrijs += 0.5f;
                order.AppendLine("Incl. Anjovis - €0,5");
            }
            if (ChkArtisjok.IsChecked == true)
            {
                TotaalPrijs += 0.5f;
                order.AppendLine("Incl. Artisjok - €0,5");
            }
            if (ChkMozzarella.IsChecked == true)
            {
                TotaalPrijs += 0.5f;
                order.AppendLine("Incl. Mozarella - €0,5");
            }
            if (ChkSalami.IsChecked == true)
            {
                TotaalPrijs += 0.5f;
                order.AppendLine("Incl. Salami - €0,5");
            }
            order.AppendLine("-----------------------");

            
            //Rond bestel overzicht af en toon 
            order.AppendLine(Environment.NewLine + $"Totaal Prijs = {TotaalPrijs:c}");
            TxtOverzicht.Text = order.ToString();

            //Maak gegevens Textvakken leeg
            BtnWissen_Click(sender, e);
        }

        private void ChkSkipGegevens_Check(object sender, RoutedEventArgs e)
        {
            if (ChkSkipGegevens.IsChecked == true)
            {
                TxtNaam.IsEnabled = false;
                TxtNaam.Background = Brushes.Gray;
                TxtNaam.TextDecorations = TextDecorations.Strikethrough;
                TxtTelefoonnummer.IsEnabled = false;
                TxtTelefoonnummer.Background = Brushes.Gray;
                TxtTelefoonnummer.TextDecorations = TextDecorations.Strikethrough;
                TxtEmail.IsEnabled = false;
                TxtEmail.Background = Brushes.Gray;
                TxtEmail.TextDecorations = TextDecorations.Strikethrough;
                TxtAdres.IsEnabled = false;
                TxtAdres.Background = Brushes.Gray;
                TxtAdres.TextDecorations = TextDecorations.Strikethrough;
                TxtWoonplaats.IsEnabled = false;
                TxtWoonplaats.Background = Brushes.Gray;
                TxtWoonplaats.TextDecorations = TextDecorations.Strikethrough;
                TxtPostcode.IsEnabled = false;
                TxtPostcode.Background = Brushes.Gray;
                TxtPostcode.TextDecorations = TextDecorations.Strikethrough;
                BtnWissen.IsEnabled = false;
                BtnTerug.IsEnabled = false;
            }
            else if (ChkSkipGegevens.IsChecked == false)
            {
                TxtNaam.IsEnabled = true;
                TxtNaam.Background = Brushes.White;
                TxtNaam.TextDecorations = null;
                TxtTelefoonnummer.IsEnabled = true;
                TxtTelefoonnummer.Background = Brushes.White;
                TxtTelefoonnummer.TextDecorations = null;
                TxtEmail.IsEnabled = true;
                TxtEmail.Background = Brushes.White;
                TxtEmail.TextDecorations = null;
                TxtAdres.IsEnabled = true;
                TxtAdres.Background = Brushes.White;
                TxtAdres.TextDecorations = null;
                TxtWoonplaats.IsEnabled = true;
                TxtWoonplaats.Background = Brushes.White;
                TxtWoonplaats.TextDecorations = null;
                TxtPostcode.IsEnabled = true;
                TxtPostcode.Background = Brushes.White;
                TxtPostcode.TextDecorations = null;
                BtnWissen.IsEnabled = true;
                BtnTerug.IsEnabled = true;
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            //Zijn er gegevens ingevuld?
            if (ChkSkipGegevens.IsChecked == true)
            {
                return;
            }

            //Onthoud gegevens
            Naam = TxtNaam.Text;
            Telefoonnummer = TxtTelefoonnummer.Text;
            Email = TxtEmail.Text;
            Adres = TxtAdres.Text;
            Woonplaats = TxtWoonplaats.Text;
            Postcode = TxtPostcode.Text;

            //Maak Textvakken leeg
            TxtNaam.Clear();
            TxtTelefoonnummer.Clear();
            TxtEmail.Clear();
            TxtAdres.Clear();
            TxtWoonplaats.Clear();
            TxtPostcode.Clear();
        }

        private void BtnTerug_Click(object sender, RoutedEventArgs e)
        {
            //Zijn er recente gegevens?
            if (String.IsNullOrEmpty(Naam))
            {
                MessageBox.Show("Geen recente gegevens om te tonen.", "Fout");
                return;
            }

            //Herstel gegevens
            TxtNaam.Text = Naam;
            TxtTelefoonnummer.Text = Telefoonnummer;
            TxtEmail.Text = Email;
            TxtAdres.Text = Adres;
            TxtWoonplaats.Text = Woonplaats;
            TxtPostcode.Text = Postcode;
        }
    }
}
