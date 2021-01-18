using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BAPAss4
{
    public partial class OrderForm : Form
    {
        Dictionary<String, int> inventory = new Dictionary<String, int>();

        Dictionary<String, int> cart = new Dictionary<String, int>();

        // Dictionary using the SKU as the key and the Product as the value
        Dictionary<String, Product> products = new Dictionary<string, Product>();

        String _cashier;

        public OrderForm(String username)
        {
            InitializeComponent();

            _cashier = username;


            // File with products stored on a csv
            String path = "products.csv";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] data = line.Split(',');
                        // New Product object is created consisting of SKU, Name, and Price
                        Product product = new Product(data[0], data[1], Decimal.Parse(data[2]));
                        // Adding new Product object to dictionary
                        products.Add(product.Sku, product);
                        // Adding stock level of products to Dictionary
                        inventory.Add(product.Sku, Int32.Parse(data[3]));
                    }
                }
            }

            // Binding data to DataGridView
            foreach (Product product in products.Values)
            {
                productBindingSource.Add(product);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductGridView.Columns[e.ColumnIndex].Name == "Add" ||
                ProductGridView.Columns[e.ColumnIndex].Name == "Remove")
            {
                String sku = ProductGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (ProductGridView.Columns[e.ColumnIndex].Name == "Add")
                {
                    if (cart.ContainsKey(sku))
                    {
                        if (cart[sku] < inventory[sku])
                        {
                            cart[sku] += 1;
                            inventory[sku] -= 1;
                        }
                    }
                    else if (inventory[sku] > 0)
                    {
                        cart[sku] = 1;
                        inventory[sku] -= 1;
                    }
                }
                else
                {
                    if (cart.ContainsKey(sku))
                    {
                        if (cart[sku] > 1)
                        {
                            cart[sku] -= 1;
                            inventory[sku] += 1;
                        }
                        else if (cart[sku] == 1)
                        {
                            cart.Remove(sku);
                            inventory[sku] += 1;
                        }
                    }
                }

                cartListBox.Items.Clear();


                decimal total = 0.0m;

                foreach (String s in cart.Keys)
                {
                    Product p = products[s];
                    // Font must be monospaced for text to line up correctly
                    String lineItem =
                        $"{p.Name} {String.Concat(Enumerable.Repeat(".", 37 - p.Name.Length - p.Price.ToString(CultureInfo.CurrentCulture).Length))} €{p.Price}";

                    // For each item in cart, increment the total
                    for (int i = 0; i < cart[s]; i++)
                    {
                        total += p.Price;
                        cartListBox.Items.Add(lineItem);
                    }
                }

                if (cart.Keys.ToArray().Length > 0)
                {
                    cartListBox.Items.Add(String.Concat(Enumerable.Repeat("=", 40)));
                    cartListBox.Items.Add(
                        $"Total {String.Concat(Enumerable.Repeat(" ", 32 - total.ToString(CultureInfo.CurrentCulture).Length))} €{total}");
                }


                ProductGridView.Refresh();
            }
        }

        private void ProductGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ProductGridView.Columns[e.ColumnIndex].Name == "StockLevel")
            {
                String sku = ProductGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ProductGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = inventory[sku];
            }
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.Items.Count > 0)
            {
                // Folder in which receipts are stored
                String path = "receipts";

                // Gets current DateTime
                DateTime date = DateTime.Now;

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Create files within the path, named year-month-day_hour-minute-second.txt
                using (StreamWriter file = new StreamWriter($"{path}\\{date:yyyy-MM-dd_HH-mm-ss}.txt"))
                {
                    // Adding information to start of receipts using StreamWriter
                    file.WriteLine(String.Concat(Enumerable.Repeat(" ", 40 - date.ToLongDateString().Length)) +
                                   date.ToLongDateString());
                    file.WriteLine($"Cashier: {_cashier}");
                    file.WriteLine($"ID: {Guid.NewGuid()}\n");

                    foreach (String line in cartListBox.Items)
                    {
                        file.WriteLine(line);
                    }
                }

                // Updating products.csv from ArrayList in memory as items have been sold
                using (StreamWriter file = new StreamWriter("products.csv"))
                {
                    foreach (Product p in products.Values)
                    {
                        file.WriteLine($"{p.Sku},{p.Name},{p.Price},{inventory[p.Sku]}");
                    }
                }

                // Opens the newly created receipt
                ViewInvoice viewInvoice = new ViewInvoice($"{path}\\{date:yyyy-MM-dd_HH-mm-ss}.txt");
                cartListBox.Items.Clear();
                cart.Clear();
                viewInvoice.Show();
            }
            else
            {
                toolTip1.SetToolTip(this.InvoiceButton, "Add item to cart to continue.");
            }
        }


        private void TransactionButton_Click(object sender, EventArgs e)
        {
            PreviousTransactions previousTransactions = new PreviousTransactions();
            previousTransactions.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Dispose(false);
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Show();
        }
    }


    public class Product
    {
        public String Sku { get; }
        public String Name { get; }
        public decimal Price { get; }

        // Product Constructor
        public Product(String sku, String name, decimal price)
        {
            Sku = sku;
            Name = name;
            Price = price;
        }
    }
}