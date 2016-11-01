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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lommeregner_pair
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

        public double tal1 { get; set; }
        public double tal2 { get; set; }

        public double tal3 { get; set; }
        public double tal4 { get; set; }

        public double mem { get; set; }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            TextboxTilVariable();
            tb_visResultat.Text = (tal1 + tal2).ToString();
            tb_operator.Text = "+";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            TextboxTilVariable();
            tb_visResultat.Text = (tal1 - tal2).ToString();
            tb_operator.Text = "-";
        }

        private void btn_gange_Click(object sender, RoutedEventArgs e)
        {
            TextboxTilVariable();
            tb_visResultat.Text = (tal1 * tal2).ToString();
            tb_operator.Text = "*";
        }

        private void btn_divider_Click(object sender, RoutedEventArgs e)
        {
            TextboxTilVariable();
            tb_visResultat.Text = (tal1 / tal2).ToString();
            tb_operator.Text = "/";
        }

        private void btn_ryd_Click(object sender, RoutedEventArgs e)
        {
            tb_tal1.Text = "";
            tb_tal2.Text = "";
            tal1 = 0;
            tal2 = 0;
            tb_operator.Text = "";
            tb_visResultat.Text = "slettet";
        }

        private void TextboxTilVariable()
        {
            tal1 = Int32.Parse(tb_tal1.Text);
            tal2 = Int32.Parse(tb_tal2.Text);
        }

        private void btn_m_Click(object sender, RoutedEventArgs e)
        {
            mem = Int32.Parse(tb_visResultat.Text);
            tb_visResultat.Text = mem + " :er gemt";
            tb_tal1.Text = mem.ToString();
            tb_tal2.Text = "";
        }

        private void btn_mRyd_Click(object sender, RoutedEventArgs e)
        {
            //clearer alt
            tb_tal1.Text = "";
            mem = 0;
            tb_visResultat.Text = "";
         }



    }
}
