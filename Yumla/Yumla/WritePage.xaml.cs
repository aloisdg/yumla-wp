using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Yumla
{
    public partial class WritePage : PhoneApplicationPage
    {
        public WritePage()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/DrawPage.xaml", UriKind.Relative));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save button works!");
            //Do work for your application here.
        }
    }
}