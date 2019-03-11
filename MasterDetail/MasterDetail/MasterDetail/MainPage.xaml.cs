using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            // navigate to Page 1 as the default page
            Detail = new NavigationPage(new Page1());

            // Hide the Master Page Menu
            IsPresented = false;
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            // When we click the menu button 1, navigate the detail page to Page1
            Detail = new NavigationPage(new Page1());

            // Hide the Master Page Menu
            IsPresented = false;
        }

        private void Handle_Clicked2(object sender, EventArgs e)
        {
            // When we click the menu button 2, navigate the detail page to Page2
            Detail = new NavigationPage(new Page2());

            // Hide the Master Page Menu
            IsPresented = false;
        }
    }
}
