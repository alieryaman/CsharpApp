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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for yenisayfam.xaml
    /// </summary>
    public partial class yenisayfam : Window
    {
        public yenisayfam()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(ilksayi.Text); // convert ediliyor...
            int b = Convert.ToInt32(ikincisayi.Text);
            int sonuc;
            sonuc = a + b;
            snc.Text = a + "+" + b + "=" + sonuc.ToString(); 
        }

        

        
    }
}
