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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FurnitureOrder.dataBase;

namespace FurnitureOrder.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReferenceBookAdmin.xaml
    /// </summary>
    public partial class ReferenceBookAdmin : Page
    {
        MainWindow main;
        public ReferenceBookAdmin(MainWindow main, bool isFirniture)
        {
            this.main = main;
            InitializeComponent();
            if (isFirniture)
                foreach (Furniture f in main.bd.Furniture)
                {
                    createFurniture(f);
                }
            else 
                foreach (Material m in main.bd.Material)
                {
                    createMaterials(m);
                }
        }
        
        private void createFurniture(Furniture f)
        {
            StackPanel panel = new StackPanel();

            TextBox t1 = new TextBox();
            t1.Text = f.VendorCode;

            TextBox t2 = new TextBox();
            t2.Text = f.name;

            TextBox t3 = new TextBox();
            t3.Text = f.quantity.ToString();

            TextBox t4 = new TextBox();
            t4.Text = f.unit;

            TextBox t5 = new TextBox();
            t5.Text = f.price.ToString();
            

            TextBox t6 = new TextBox();
            try
            {
                t6.Text = f.provider.name;
            }
            catch
            {

            }

            panel.Children.Add(t1);
            panel.Children.Add(t2);
            panel.Children.Add(t3);
            panel.Children.Add(t4);
            panel.Children.Add(t5);
            panel.Children.Add(t6);
            records.Children.Add(panel);
        }

        private void createMaterials(Material f)
        {
            StackPanel panel = new StackPanel();

            TextBox t1 = new TextBox();
            t1.Text = f.vendorCode;

            TextBox t2 = new TextBox();
            t2.Text = f.name;

            TextBox t3 = new TextBox();
            t3.Text = f.quanity.ToString();

            TextBox t4 = new TextBox();
            t4.Text = f.unit;

            TextBox t5 = new TextBox();
            t5.Text = f.price.ToString();

            TextBox t6 = new TextBox();
            try
            {
                t6.Text = f.provider.name;
            }
            catch
            {

            }

            panel.Children.Add(t1);
            panel.Children.Add(t2);
            panel.Children.Add(t3);
            panel.Children.Add(t4);
            panel.Children.Add(t5);
            panel.Children.Add(t6);
            records.Children.Add(panel);
        }
    }
}
