using System.Data;

namespace Final643450327_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Product[]oducts = new Product[10];
        SaleManagement saleManagement = new SaleManagement();
        public static void main()
        {         

        }
        public void loadProductFormFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV(.csv)|*.csv";
            openFile.Title = "Please select file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = null;

                DataTable dt = new DataTable();
                string[] colName = { "รายการ", "จำนวน", "รวม" };

                foreach (string col in colName)
                {
                    dt.Columns.Add(col);
                }

                foreach (string file in openFile.FileNames)
                {
                    try
                    {
                        if (File.Exists(file) == true)
                        {
                            //import file data
                            StreamReader csv = new StreamReader(file);
                            string textLine; //string line data
                            string[] splitLine; // use array to save split data

                            do
                            {
                                textLine = csv.ReadLine();
                                splitLine = textLine.Split(",");
                                dt.Rows.Add(splitLine);
                            }
                            while (csv.Peek() != -1);
                            csv.Close();
                            csv.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                dataGridView1.DataSource = dt;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbNotebook_CheckedChanged(object sender, EventArgs e)
        {
            if(cbNotebook.Checked == true)
            {
                tbNotebook.Enabled = true;
            }
            if(cbNotebook.Checked == false)
            {
                tbNotebook.Enabled = false;
                tbNotebook.Text = "0";
            }
        }

        private void cbPen_CheckedChanged(object sender, EventArgs e)
        {
           if(cbPen.Checked == true)
           {
               tbPen.Enabled = true;
           }
           if(cbPen.Checked == false)
           {
               tbPen.Enabled = false;
               tbPen.Text = "0";
           }
        }

        private void cbPencil_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPencil.Checked == true)
            {
                tbPencil.Enabled = true;    
            }
            if(cbPencil.Checked == false)
            {
                tbPencil.Enabled = false;
                tbPencil.Text ="0";
            }
        }

        private void cbRuler_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRuler.Checked == true)
            {
               tbRuler.Enabled = true;
            }
            if(cbRuler.Checked == false)
            {
                tbRuler.Enabled = false;
                tbRuler.Text ="0";
            }
        }

        private void cbEraser_CheckedChanged(object sender, EventArgs e)
        {
            if(cbEraser.Checked == true)
            {
                tbEraser.Enabled = true;
            }
            if(cbEraser.Checked == false)
            {
                tbEraser.Enabled = false;
                tbEraser.Text = "0";
            }
        }

        private void cbLiquin_CheckedChanged(object sender, EventArgs e)
        {
            if(cbLiquin.Checked == true)
            {
                tbLiquid.Enabled = true;
            }
            if(cbLiquin.Checked == false)
            {
                tbLiquid.Enabled = false;
                tbLiquid.Text = "0";
            }
        }

        private void cbColor12_CheckedChanged(object sender, EventArgs e)
        {
            if(cbColor12.Checked == true)
            {
                tbColor12.Enabled = true;
            }
            if(cbColor12.Checked == false)
            {
                tbColor12.Enabled = false;
                tbColor12.Text = "0";
            }
        }

        private void cbColor24_CheckedChanged(object sender, EventArgs e)
        {
            if(cbColor24.Checked == true)
            {
                tbColor24.Enabled = true;
            }
            if(cbColor24.Checked == false)
            {
                tbColor24.Enabled = false;
                tbColor24.Text = "0";
            }
        }

        private void cbColor36_CheckedChanged(object sender, EventArgs e)
        {
            if(cbColor36.Checked == true)
            {
                tbColor36.Enabled = true;
            }
            if(cbColor36.Checked == false)
            {
                tbColor36.Enabled = false;
                tbColor36.Text = "0";
            }
        }

        private void cbColor48_CheckedChanged(object sender, EventArgs e)
        {
            if(cbColor48.Checked == true)
            {
                tbColor48.Enabled = true;
            }
            if(cbColor48.Checked == false)
            {
                tbColor48.Enabled = false;
                tbColor48.Text = "0";
            }
        }
    }
}