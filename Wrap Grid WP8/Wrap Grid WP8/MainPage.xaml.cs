using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Wrap_Grid_WP8.Resources;

namespace Wrap_Grid_WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            AddItems();
        }
        private void AddItems()
        {
            List<string> items = new List<string>
            {
                "Delhi NCR",
                "Bangalore",
                "Bombay",
                "Chennai",
                "Mangalore",
                "Hyderabad",
                "Kolkata",
                "Patna",
                "Goa",
                "Pune",
                "Lahore"
            };
            LocationItemsControl.ItemsSource = items;
        }
    }
}