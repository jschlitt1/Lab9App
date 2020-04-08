using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework9App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgePage : ContentPage
    {
        public AgePage()
        {
            InitializeComponent();
        }
        
        public void CalculateYears(Object sender, EventArgs args)
        {
            int length = Convert.ToInt32(Age.Text) - 16;
            Output.Text = "You have been able to legally drive for " + length + " years.";
        }
    }
}