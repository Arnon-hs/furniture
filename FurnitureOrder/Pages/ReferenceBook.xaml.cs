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
    /// Логика взаимодействия для ReferenceBook.xaml
    /// </summary>
    public partial class ReferenceBook : Page
    {
        MainWindow main;
        public ReferenceBook(MainWindow main, bool isFurniture)
        {
            this.main = main;
            InitializeComponent();
            double price = 0;
            if (isFurniture)
            {
                foreach (Furniture f in main.bd.Furniture)
                {
                    Record record = new Record();
                    record.vendorCode = f.VendorCode;
                    record.name = f.name;
                    record.quantity = f.quantity ?? -1;
                    record.unit = f.unit;
                    record.price = f.price ?? -1;
                    record.mainProvider = f.mainProvider;
                    records.Items.Add(record);
                    if (record.price != -1)
                        price += record.price;
                }
                AllRecords.Text = "Общее количество фурнитуры " + main.bd.Furniture.Count().ToString();
                
            }
            else
            {
                foreach (Material f in main.bd.Material)
                {
                    try
                    {
                        Record record = new Record();
                        record.vendorCode = f.vendorCode;
                        record.name = f.name;
                        record.quantity = Convert.ToDouble(f.quanity);
                        record.unit = f.unit;
                        record.price = Convert.ToDouble(f.price);
                        record.mainProvider = f.mainProvider;
                        records.Items.Add(record);
                        if (record.price != -1)
                            price += record.price;
                    }
                    catch
                    {

                    }

                }
                AllRecords.Text = "Общее количество материалов: " + main.bd.Material.Count().ToString();
            }
            AllPrice.Text = "Общая цена: " + price.ToString();
        }
    }

    class Record
    {
        public string vendorCode { get; set; }
        public string name { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public string mainProvider { get; set; }
    }
}
