using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace BAPAss4
{
    public partial class SummaryForm : Form
    {
        ArrayList transactions = new ArrayList();

        public SummaryForm()
        {
            InitializeComponent();
            String path = "receipts";
            decimal totalRevenue = 0.0m;
            decimal averageTransaction = 0.0m;


            // Count receipts in folder
            int transactionCount = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories).Length;
            // Populates total transactions
            TotalTransactionsTextBox.Text = transactionCount.ToString();

            // Getting total revenue from receipt total
            foreach (String s in Directory.GetFiles("receipts"))
            {
                ArrayList transaction = new ArrayList();
                using (StreamReader file = new StreamReader(s))
                {
                    String line;
                    transaction.Add(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        transaction.Add(line);
                    }
                }

                transactions.Add(transaction);
                try
                {
                    decimal individualTotal = Decimal
                        .Parse(transaction[transaction.Count - 1]
                        .ToString()
                        .Split('€')[1]);

                    totalRevenue += individualTotal;
                    TotalRevenueTextBox.Text = totalRevenue.ToString("C",CultureInfo.CurrentCulture);
                }
                catch (Exception e)
                {
                    string message = "Unable to read files";  
                    MessageBox.Show(message);
                    
                }
            }

            //Calculating average transaction value
            averageTransaction = totalRevenue / transactionCount;
            AverageRevenueTextBox.Text = averageTransaction.ToString("C",CultureInfo.CurrentCulture);
        }


        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}