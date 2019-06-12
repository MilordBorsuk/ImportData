using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportiEksportDanych
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'wodaDataSet.Watter' . Możesz go przenieść lub usunąć.
            this.watterTableAdapter.Fill(this.wodaDataSet.Watter);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Eksport_Click(object sender, EventArgs e)
        {
            table.WriteXml(@"C:\Users\Piotr-Laptop\Documents\XMLFile1", XmlWriteMode.WriteSchema);
            MessageBox.Show("Data Exported");
        }

        private void import_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.ReadXml(@"C:\Users\Piotr-Laptop\Documents\XMLFile1");
            dataGridView2.DataSource = dt;
            MessageBox.Show("Data Imported");
        }
    }
}
