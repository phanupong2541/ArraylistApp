using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArraylistApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txtName.Text);
        }
        private void btnAdd(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtName.Text);  
        }
        private void btnShow(object sender, RoutedEventArgs e)
        {
            foreach (var data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
            MessageBox.Show("Data = "+arrayList.Count.ToString());

        }
        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //Add Data
        //    arrayList.Add(10);
        //    arrayList.Add(40);
        //    arrayList.Add(50);
        //    arrayList.Add(60);
        //    arrayList.Add(400);


        //    //show Data
        //    foreach (var data in arrayList)
        //    {
        //        MessageBox.Show(data.ToString());
        //    }
        //    //Count
        //    MessageBox.Show(arrayList.Count.ToString());

        //    arrayList.Remove(10);

        //    foreach (var data in arrayList)
        //    {
        //        MessageBox.Show(data.ToString());
        //    }
        //    MessageBox.Show(arrayList.Count.ToString());
        //    //Remove
        //    //arrayList.Remove(10);
        //    //arrayList.RemoveAt(1);

        //    //Sort
        //    arrayList.Clear();


        //}

    }
}
