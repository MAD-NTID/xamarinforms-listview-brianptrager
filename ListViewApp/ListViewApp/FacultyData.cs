using ListViewApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewApp
{
    public static class FacultyData
    {
        public static ObservableCollection<Faculty> facultyList = new ObservableCollection<Faculty>();

        public static void LoadData()
        {
            facultyList.Add(new Faculty() { Name = "Brian Trager", Rank = "Associate Professor", Specialty = "Mobile App Development", ImageUri = "Trager.jpg" });
        }
    }
}
