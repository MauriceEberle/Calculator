using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace Calculator
{
    public partial class MainWindow : Window
    {

        public Calculator calculator = new Calculator();
        public List<string> verlaufListe = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            verlaufBox.ItemsSource = verlaufListe;
        }

        private void Update()
        {
            verlaufBox.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num1.Content.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num2.Content.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num3.Content.ToString();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num4.Content.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num5.Content.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num6.Content.ToString();
        }


        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num7.Content.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num8.Content.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num9.Content.ToString();
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            ergebnisBox.Text += Num0.Content.ToString();
        }
        private void Button_Click__(object sender, RoutedEventArgs e)
        {
            if(!ergebnisBox.Text.Contains(','))
                ergebnisBox.Text = ergebnisBox.Text + Point.Content.ToString();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            calculator.x = decimal.Parse(ergebnisBox.Text);
            ergebnisBox.Text = "";
            calculator.addActive = true;
        }

        private void Button_Click_Sub(object sender, RoutedEventArgs e)
        {
            calculator.x = decimal.Parse(ergebnisBox.Text);
            ergebnisBox.Text = "";
            calculator.subActive = true;
        }

        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            calculator.x = decimal.Parse(ergebnisBox.Text);
            ergebnisBox.Text = "";
            calculator.divActive = true;
        }

        private void Button_Click_Multi(object sender, RoutedEventArgs e)
        {
            calculator.x = decimal.Parse(ergebnisBox.Text);
            ergebnisBox.Text = "";
            calculator.multiActive = true;
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            calculator.x = 0;
            calculator.y = 0;
            ergebnisBox.Text = "";
        }

        private void Button_Click_Calc(object sender, RoutedEventArgs e)
        {
            calculator.y = decimal.Parse(ergebnisBox.Text);
            if (calculator.addActive == true)
            {
                calculator.ergebnis = calculator.Addiere(calculator.x, calculator.y);
                calculator.ergebnis = Decimal.Round(calculator.ergebnis, 10);
                ergebnisBox.Text = calculator.ergebnis.ToString();
                calculator.GanzeRechnung = $"{calculator.x} + {calculator.y} = {calculator.ergebnis}";
                verlaufListe.Add(calculator.GanzeRechnung);
                calculator.addActive = false;
                Update();
            }
            else if (calculator.subActive == true)
            {
                calculator.ergebnis = calculator.Subtrahiere(calculator.x, calculator.y);
                calculator.ergebnis = Decimal.Round(calculator.ergebnis, 10);
                ergebnisBox.Text = calculator.ergebnis.ToString();
                calculator.GanzeRechnung = $"{calculator.x} - {calculator.y} = {calculator.ergebnis}";
                verlaufListe.Add(calculator.GanzeRechnung);
                calculator.subActive = false;
                Update();
            }
            else if (calculator.multiActive == true)
            {
                calculator.ergebnis = calculator.Multipiziere(calculator.x, calculator.y);
                calculator.ergebnis = Decimal.Round(calculator.ergebnis, 10);
                ergebnisBox.Text = calculator.ergebnis.ToString();
                calculator.GanzeRechnung = $"{calculator.x} * {calculator.y} = {calculator.ergebnis}";
                verlaufListe.Add(calculator.GanzeRechnung);
                calculator.multiActive = false;
                Update();
            }
            else if (calculator.divActive == true)
            {
                calculator.ergebnis = calculator.Dividiere(calculator.x, calculator.y);
                calculator.ergebnis = Decimal.Round(calculator.ergebnis, 10);
                ergebnisBox.Text = calculator.ergebnis.ToString();
                calculator.GanzeRechnung = $"{calculator.x} / {calculator.y} = {calculator.ergebnis}";
                verlaufListe.Add(calculator.GanzeRechnung);
                calculator.divActive = false;
                Update();
            }
            else
                ergebnisBox.Text = calculator.y.ToString();
        }
    }
}
