using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Final643450327_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product product = new Product();
        Coupon coupon = new Coupon();
        SaleManagement saleManagement = new SaleManagement();

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV(*.csv)|*.csv";
            openFile.Title = "Please select file";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dataGridView2.DataSource = null;

                DataTable dt = new DataTable();
                string[] colNames = { "รายการ", "ราคา" };

                foreach (string col in colNames)
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
                dataGridView2.DataSource = dt;
            }
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
            if(cbLiquid.Checked == true)
            {
                tbLiquid.Enabled = true;
            }
            if(cbLiquid.Checked == false)
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

        private void btCal_Click(object sender, EventArgs e)
        {
            
            string notebook = this.tbNotebook.Text;
            string pen = this.tbPen.Text;
            string pencil = this.tbPencil.Text;
            string ruler = this.tbRuler.Text;
            string eraser = this.tbEraser.Text;
            string liquid = this.tbLiquid.Text;
            string color12 = this.tbColor12.Text;
            string color24 = this.tbColor24.Text;
            string color36 = this.tbColor36.Text;
            string color48 = this.tbColor48.Text;


            double Notebook = Convert.ToDouble(notebook);
            product.addNotebook(Notebook);
            double Tnotebook = product.getNotebook();
            tbTnotebook.Text = Tnotebook.ToString();

            double Pen = Convert.ToDouble(pen);
            product.addPen(Pen);
            double Tpen = product.getPen();
            tbTpen.Text = Tpen.ToString();

            double Pencil = Convert.ToDouble(pencil);
            product.addPencil(Pencil);
            double Tpencil = product.getPencil();
            tbTpencil.Text = Tpencil.ToString();

            double Ruler = Convert.ToDouble(ruler);
            product.addRuler(Ruler);
            double Truler = product.getRuler();
            tbTruler.Text = Truler.ToString();

            double Eraser = Convert.ToDouble(eraser);
            product.addEraser(Eraser);
            double Teraser = product.getEraser();
            tbTeraser.Text = Teraser.ToString();

            double Liquid = Convert.ToDouble(liquid);
            product.addLiquid(Liquid);
            double Tliuid = product.getLiquid();
            tbTliquid.Text = Tliuid.ToString();

            double Color12 = Convert.ToDouble(color12);
            product.addColor12(Color12);
            double Tcolor12 = product.getColor12();
            tbTcolor12.Text = Tcolor12.ToString();

            double Color24 = Convert.ToDouble(color24);
            product.addColor24(Color24);
            double Tcolor24 = product.getColor24();
            tbTcolor24.Text = Tcolor24.ToString();

            double Color36 = Convert.ToDouble(color36);
            product.addColor36(Color36);
            double Tcolor36 = product.getColor36();
            tbTcolor36.Text = Tcolor36.ToString();

            double Color48 = Convert.ToDouble(color48);
            product.addColor48(Color48);
            double Tcolor48 = product.getColor48();
            tbTcolor48.Text = Tcolor48.ToString();

        

            double total = product.getPrice();
            textBox1.Text = total.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            string notebook = this.tbNotebook.Text;
            string pen = this.tbPen.Text;
            string pencil = this.tbPencil.Text;
            string ruler = this.tbRuler.Text;
            string eraser = this.tbEraser.Text;
            string liquid = this.tbLiquid.Text;
            string color12 = this.tbColor12.Text;
            string color24 = this.tbColor24.Text;
            string color36 = this.tbColor36.Text;
            string color48 = this.tbColor48.Text;

            double Notebook = Convert.ToDouble(notebook);
            product.addNotebook(Notebook);
            double Tnotebook = product.getNotebook();
            tbTnotebook.Text = Tnotebook.ToString();

            double Pen = Convert.ToDouble(pen);
            product.addPen(Pen);
            double Tpen = product.getPen();
            tbTpen.Text = Tpen.ToString();

            double Pencil = Convert.ToDouble(pencil);
            product.addPencil(Pencil);
            double Tpencil = product.getPencil();
            tbTpencil.Text = Tpencil.ToString();

            double Ruler = Convert.ToDouble(ruler);
            product.addRuler(Ruler);
            double Truler = product.getRuler();
            tbTruler.Text = Truler.ToString();

            double Eraser = Convert.ToDouble(eraser);
            product.addEraser(Eraser);
            double Teraser = product.getEraser();
            tbTeraser.Text = Teraser.ToString();

            double Liquid = Convert.ToDouble(liquid);
            product.addLiquid(Liquid);
            double Tliuid = product.getLiquid();
            tbTliquid.Text = Tliuid.ToString();

            double Color12 = Convert.ToDouble(color12);
            product.addColor12(Color12);
            double Tcolor12 = product.getColor12();
            tbTcolor12.Text = Tcolor12.ToString();

            double Color24 = Convert.ToDouble(color24);
            product.addColor24(Color24);
            double Tcolor24 = product.getColor24();
            tbTcolor24.Text = Tcolor24.ToString();

            double Color36 = Convert.ToDouble(color36);
            product.addColor36(Color36);
            double Tcolor36 = product.getColor36();
            tbTcolor36.Text = Tcolor36.ToString();

            double Color48 = Convert.ToDouble(color48);
            product.addColor48(Color48);
            double Tcolor48 = product.getColor48();
            tbTcolor48.Text = Tcolor48.ToString();

            if (cbNotebook.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbNotebook.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbNotebook.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTnotebook.Text;
            }
            if (cbPen.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbPen.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbPen.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTpen.Text;
            }
            if (cbPencil.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbPencil.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbPencil.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTpencil.Text;
            }
            if (cbRuler.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbRuler.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbRuler.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTruler.Text;
            }
            if (cbEraser.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbEraser.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbEraser.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTeraser.Text;
            }
            if (cbLiquid.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbLiquid.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbLiquid.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTliquid.Text;
            }
            if (cbColor12.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbColor12.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbColor12.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTcolor12.Text;
            }
            if (cbColor24.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbColor24.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbColor24.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTcolor24.Text;
            }
            if (cbColor36.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbColor36.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbColor36.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTcolor36.Text;
            }
            if (cbColor48.Checked == true)
            {
                dataGridView1.Rows[n].Cells[0].Value = cbColor48.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbColor48.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbTcolor48.Text;
            }
        }

        private void btCoupon_Click(object sender, EventArgs e)
        {
            string totalcoupon = this.textBox1.Text;  
            double Coupon = Convert.ToDouble(totalcoupon);
            coupon.createCoupon(Coupon); 
            double totalCoupon = coupon.getCoupon();
            textBox2.Text = totalCoupon.ToString();
            labelCouponCode.Text = coupon.getCouponCode().ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV(*.csv)|*.csv";
            openFile.Title = "Please select file";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dataGridView2.DataSource = null;

                DataTable dt = new DataTable();
                string[] colNames = { "รายการ", "ราคา" };

                foreach(string col in colNames)
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
                dataGridView2.DataSource = dt;
            }
        }
                

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            string pay = this.textBox2.Text;
            string getmoney = this.tbGetMoney.Text;

            double Pay = Convert.ToDouble(pay);
            double GetMoney = Convert.ToDouble(getmoney);
            saleManagement.Bill(Pay, GetMoney);
            double Tpay = saleManagement.payBill();
            tbChange.Text = Tpay.ToString();
        }
    }
}