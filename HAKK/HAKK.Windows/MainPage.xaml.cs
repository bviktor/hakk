using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HAKK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            bool badInput = false;
            SolidColorBrush whiteBack = new SolidColorBrush() { Color = Windows.UI.Colors.White };
            SolidColorBrush redBack = new SolidColorBrush() { Color = Windows.UI.Colors.Red };

            evjaratBox.Background = whiteBack;
            kobcentiBox.Background = whiteBack;
            powerBox.Background = whiteBack;

            int evjarat = 0;
            int kobcenti = 0;
            int power = 0;


            try
            {
                evjarat = Convert.ToInt32(evjaratBox.Text);
            }
            catch (Exception)
            {
                badInput = true;
                evjaratBox.Text = "";
                evjaratBox.Background = redBack;
            }


            try
            {
                kobcenti = Convert.ToInt32(kobcentiBox.Text);
            }
            catch (Exception)
            {
                badInput = true;
                kobcentiBox.Text = "";
                kobcentiBox.Background = redBack;
            }


            try
            {
                power = Convert.ToInt32(powerBox.Text);
            }
            catch (Exception)
            {
                badInput = true;
                powerBox.Text = "";
                powerBox.Background = redBack;
            }


            if (badInput)
            {
                eredetBox.Text = "";
                gadoBox.Text = "";
                vagyonBox.Text = "";
                forgalmiBox.Text = "";
                torzskonvyBox.Text = "";
                rendszamBox.Text = "";
                totalBox.Text = "";
            }
            else
            {
                eredetBox.Text = Calculator.eredetCalc(kobcenti).ToString() + " Ft";
                gadoBox.Text = Calculator.gadoCalc(evjarat, power).ToString() + " Ft";
                vagyonBox.Text = Calculator.vagyonCalc(evjarat, power).ToString() + " Ft";
                forgalmiBox.Text = Calculator.forgalmiCalc().ToString() + " Ft";
                torzskonvyBox.Text = Calculator.torzskonyvCalc().ToString() + " Ft";
                rendszamBox.Text = Calculator.rendszamCalc().ToString() + " Ft";
                totalBox.Text = Calculator.totalCalc(evjarat, kobcenti, power).ToString() + " Ft";
            }
        }
    }
}
