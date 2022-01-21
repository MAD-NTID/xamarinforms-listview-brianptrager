using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            FacultyData.LoadData();

            BindingContext = FacultyData.facultyList;
        }

        private void facultyListView_Refreshing(object sender, EventArgs e)
        {
            FacultyData.LoadData();
            facultyListView.IsRefreshing = false;
        }

        private void facultyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void facultyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
