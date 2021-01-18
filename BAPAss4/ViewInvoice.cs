using System;
using System.IO;
using System.Windows.Forms;

namespace BAPAss4
{
    public partial class ViewInvoice : Form
    {
        public ViewInvoice(String filename)
        {
            InitializeComponent();

            
            if (File.Exists(filename))
            {
                using (StreamReader file = new StreamReader(filename))
                {
                    String line;
                    while ((line = file.ReadLine()) != null)
                    {
                        cartListBox.Items.Add(line);
                    }
                }
            }
            else {
                cartListBox.Items.Add("Invoice not found");
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
