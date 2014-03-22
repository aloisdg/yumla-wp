using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Yumla
{
    public partial class DrawPage : PhoneApplicationPage//, INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //private void NotifyPropertyChanged(String propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (null != handler)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        //private bool NotifyPropertyChanged<T>(ref T variable, T value, [CallerMemberName] string nameProperty = null)
        //{
        //    if (object.Equals(variable, value))
        //        return false;
        //    variable = value;
        //    NotifyPropertyChanged(nameProperty);
        //    return true;
        //}

        //private List<string> types;
        //public List<string> Types
        //{
        //    get { return types; }
        //    set { NotifyPropertyChanged(ref types, value); }
        //}

        //private List<string> styles;
        //public List<string> Styles
        //{
        //    get { return styles; }
        //    set { NotifyPropertyChanged(ref styles, value); }
        //}

        public DrawPage()
        {
            InitializeComponent();
            //DataContext = this;

            //Types = new List<string> { "Class", "Activity", "Usecase" };
            //Styles = new List<string> { "Scruffy", "Boring", "Plain" };
            
            string sample = "http://yuml.me/diagram/scruffy/class/[note: You can stick notes on diagrams too!{bg:cornsilk}],[Customer]<>1-orders 0..*>[Order], [Order]++*-*>[LineItem], [Order]-1>[DeliveryMethod], [Order]*-*>[Product], [Category]<->[Product], [DeliveryMethod]^[National], [DeliveryMethod]^[International]";
            DiagramImage.Source = new BitmapImage(new Uri(sample, UriKind.Absolute));
        }
    }
}