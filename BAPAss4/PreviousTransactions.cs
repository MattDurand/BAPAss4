using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace BAPAss4
{
    public partial class PreviousTransactions : Form
    {
        ArrayList transactions = new ArrayList();

        public PreviousTransactions()
        {
            InitializeComponent();
            foreach (String path in Directory.GetFiles("receipts"))
            {
                ArrayList transaction = new ArrayList();
                using (StreamReader file = new StreamReader(path))
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
                    PreviousGridView.Rows.Add(new String[] {


                    transaction[1].ToString().Trim(),
                    transaction[2].ToString().Split(':')[1],
                    transaction[3].ToString().Split(':')[1],
                    transaction[transaction.Count - 1].ToString().Split('€')[1],
                    null,
                    path

                });
                }
                catch (Exception e)
                {
                    // Unable to parse
                }

            }
        }
        private void PreviousGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PreviousGridView.Columns[e.ColumnIndex].Name == "ViewButtonColumn")
            {
                ViewInvoice viewInvoice = new ViewInvoice(PreviousGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                viewInvoice.Show();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PreviousGridView.Rows.Clear();
            foreach (ArrayList transaction in transactions)
            {

                if (String.Join(" ", transaction.ToArray()).Contains(SearchTextBox.Text))
                {
                    PreviousGridView.Rows.Add(new String[] {


                    transaction[1].ToString().Trim(),
                    transaction[2].ToString().Split(':')[1],
                    transaction[3].ToString().Split(':')[1],
                    transaction[transaction.Count - 1].ToString().Split('€')[1],
                    null,
                    transaction[0].ToString()

                });
                }
            }
        }
    }



}
