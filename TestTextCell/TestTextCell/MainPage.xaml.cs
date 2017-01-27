using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestTextCell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            this.BindingContext = new[] { "a", "b", "c" };

        }
    }
}
