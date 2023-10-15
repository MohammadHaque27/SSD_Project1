using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSD_Project1
{
    public partial class Form1 : Form
    {
        //This List holds All of the candlesticks read for a ticker
        List<Candlestick> tempList = new List<Candlestick>(1024);
        private BindingList<Candlestick> candlesticks { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void StockLoader_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogStockLoader.ShowDialog();
            if (result == DialogResult.OK)
            {
                String referenceString = "\"Ticker\".\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";
                String fn = openFileDialogStockLoader.FileName;
                Text = fn;

                String[] filenames = openFileDialogStockLoader.FileNames;
                // The using statement also closes the StreamReader.
                using(StreamReader sr = new StreamReader(fn))
                {
                    candlesticks = new BindingList<Candlestick>();
                    dataGridView1.DataSource = candlesticks;

                    string line;
                    string header = sr.ReadLine();

                    if (header == referenceString)
                    {
                        //Read and display lines from the file until of the file is reached
                        while ((line = sr.ReadLine()) != null)
                        {
                            Candlestick cs = new Candlestick(line);
                            tempList.Add(cs);
                        }
                        for (int i = tempList.Count - 1;i >= 0; i--)
                        {
                            Candlestick cs = tempList[i];
                            if (cs.date > dateTimePicker2.Value)
                                break;
                            if (cs.date >= dateTimePicker1.Value)
                            {
                                candlesticks.Add(cs);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = candlesticks;
            }

        }

        private void openFileDialogStockLoader_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Open CSV File",
                Multiselect = true
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
