namespace Final643450327_0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbNotebook = new System.Windows.Forms.CheckBox();
            this.cbPen = new System.Windows.Forms.CheckBox();
            this.cbPencil = new System.Windows.Forms.CheckBox();
            this.cbRuler = new System.Windows.Forms.CheckBox();
            this.cbEraser = new System.Windows.Forms.CheckBox();
            this.cbColor12 = new System.Windows.Forms.CheckBox();
            this.tbNotebook = new System.Windows.Forms.TextBox();
            this.tbPen = new System.Windows.Forms.TextBox();
            this.tbPencil = new System.Windows.Forms.TextBox();
            this.tbRuler = new System.Windows.Forms.TextBox();
            this.tbEraser = new System.Windows.Forms.TextBox();
            this.tbColor12 = new System.Windows.Forms.TextBox();
            this.cbColor48 = new System.Windows.Forms.CheckBox();
            this.cbColor36 = new System.Windows.Forms.CheckBox();
            this.cbColor24 = new System.Windows.Forms.CheckBox();
            this.tbColor24 = new System.Windows.Forms.TextBox();
            this.tbColor36 = new System.Windows.Forms.TextBox();
            this.tbColor48 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbLiquin = new System.Windows.Forms.CheckBox();
            this.tbLiquid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ราคารวม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ราคารวมสุทธิ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(602, 254);
            this.dataGridView1.TabIndex = 2;
            // 
            // cbNotebook
            // 
            this.cbNotebook.AutoSize = true;
            this.cbNotebook.Location = new System.Drawing.Point(29, 33);
            this.cbNotebook.Name = "cbNotebook";
            this.cbNotebook.Size = new System.Drawing.Size(68, 29);
            this.cbNotebook.TabIndex = 3;
            this.cbNotebook.Text = "สมุด";
            this.cbNotebook.UseVisualStyleBackColor = true;
            this.cbNotebook.CheckedChanged += new System.EventHandler(this.cbNotebook_CheckedChanged);
            // 
            // cbPen
            // 
            this.cbPen.AutoSize = true;
            this.cbPen.Location = new System.Drawing.Point(29, 70);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(84, 29);
            this.cbPen.TabIndex = 4;
            this.cbPen.Text = "ปากกา";
            this.cbPen.UseVisualStyleBackColor = true;
            this.cbPen.CheckedChanged += new System.EventHandler(this.cbPen_CheckedChanged);
            // 
            // cbPencil
            // 
            this.cbPencil.AutoSize = true;
            this.cbPencil.Location = new System.Drawing.Point(29, 107);
            this.cbPencil.Name = "cbPencil";
            this.cbPencil.Size = new System.Drawing.Size(79, 29);
            this.cbPencil.TabIndex = 5;
            this.cbPencil.Text = "ดินสอ";
            this.cbPencil.UseVisualStyleBackColor = true;
            this.cbPencil.CheckedChanged += new System.EventHandler(this.cbPencil_CheckedChanged);
            // 
            // cbRuler
            // 
            this.cbRuler.AutoSize = true;
            this.cbRuler.Location = new System.Drawing.Point(29, 144);
            this.cbRuler.Name = "cbRuler";
            this.cbRuler.Size = new System.Drawing.Size(102, 29);
            this.cbRuler.TabIndex = 6;
            this.cbRuler.Text = "ไม้บรรทัด";
            this.cbRuler.UseVisualStyleBackColor = true;
            this.cbRuler.CheckedChanged += new System.EventHandler(this.cbRuler_CheckedChanged);
            // 
            // cbEraser
            // 
            this.cbEraser.AutoSize = true;
            this.cbEraser.Location = new System.Drawing.Point(29, 181);
            this.cbEraser.Name = "cbEraser";
            this.cbEraser.Size = new System.Drawing.Size(82, 29);
            this.cbEraser.TabIndex = 7;
            this.cbEraser.Text = "ยางลบ";
            this.cbEraser.UseVisualStyleBackColor = true;
            this.cbEraser.CheckedChanged += new System.EventHandler(this.cbEraser_CheckedChanged);
            // 
            // cbColor12
            // 
            this.cbColor12.AutoSize = true;
            this.cbColor12.Location = new System.Drawing.Point(216, 70);
            this.cbColor12.Name = "cbColor12";
            this.cbColor12.Size = new System.Drawing.Size(88, 29);
            this.cbColor12.TabIndex = 8;
            this.cbColor12.Text = "สี 12 สี";
            this.cbColor12.UseVisualStyleBackColor = true;
            this.cbColor12.CheckedChanged += new System.EventHandler(this.cbColor12_CheckedChanged);
            // 
            // tbNotebook
            // 
            this.tbNotebook.Enabled = false;
            this.tbNotebook.Location = new System.Drawing.Point(148, 31);
            this.tbNotebook.Name = "tbNotebook";
            this.tbNotebook.Size = new System.Drawing.Size(31, 31);
            this.tbNotebook.TabIndex = 9;
            this.tbNotebook.Text = "0";
            this.tbNotebook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPen
            // 
            this.tbPen.Enabled = false;
            this.tbPen.Location = new System.Drawing.Point(148, 68);
            this.tbPen.Name = "tbPen";
            this.tbPen.Size = new System.Drawing.Size(31, 31);
            this.tbPen.TabIndex = 10;
            this.tbPen.Text = "0";
            this.tbPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPencil
            // 
            this.tbPencil.Enabled = false;
            this.tbPencil.Location = new System.Drawing.Point(148, 105);
            this.tbPencil.Name = "tbPencil";
            this.tbPencil.Size = new System.Drawing.Size(31, 31);
            this.tbPencil.TabIndex = 11;
            this.tbPencil.Text = "0";
            this.tbPencil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRuler
            // 
            this.tbRuler.Enabled = false;
            this.tbRuler.Location = new System.Drawing.Point(148, 142);
            this.tbRuler.Name = "tbRuler";
            this.tbRuler.Size = new System.Drawing.Size(31, 31);
            this.tbRuler.TabIndex = 12;
            this.tbRuler.Text = "0";
            this.tbRuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEraser
            // 
            this.tbEraser.Enabled = false;
            this.tbEraser.Location = new System.Drawing.Point(148, 179);
            this.tbEraser.Name = "tbEraser";
            this.tbEraser.Size = new System.Drawing.Size(31, 31);
            this.tbEraser.TabIndex = 13;
            this.tbEraser.Text = "0";
            this.tbEraser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColor12
            // 
            this.tbColor12.Enabled = false;
            this.tbColor12.Location = new System.Drawing.Point(378, 72);
            this.tbColor12.Name = "tbColor12";
            this.tbColor12.Size = new System.Drawing.Size(31, 31);
            this.tbColor12.TabIndex = 14;
            this.tbColor12.Text = "0";
            this.tbColor12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbColor48
            // 
            this.cbColor48.AutoSize = true;
            this.cbColor48.Location = new System.Drawing.Point(216, 183);
            this.cbColor48.Name = "cbColor48";
            this.cbColor48.Size = new System.Drawing.Size(88, 29);
            this.cbColor48.TabIndex = 17;
            this.cbColor48.Text = "สี 48 สี";
            this.cbColor48.UseVisualStyleBackColor = true;
            this.cbColor48.CheckedChanged += new System.EventHandler(this.cbColor48_CheckedChanged);
            // 
            // cbColor36
            // 
            this.cbColor36.AutoSize = true;
            this.cbColor36.Location = new System.Drawing.Point(216, 146);
            this.cbColor36.Name = "cbColor36";
            this.cbColor36.Size = new System.Drawing.Size(88, 29);
            this.cbColor36.TabIndex = 18;
            this.cbColor36.Text = "สี 36 สี";
            this.cbColor36.UseVisualStyleBackColor = true;
            this.cbColor36.CheckedChanged += new System.EventHandler(this.cbColor36_CheckedChanged);
            // 
            // cbColor24
            // 
            this.cbColor24.AutoSize = true;
            this.cbColor24.Location = new System.Drawing.Point(216, 109);
            this.cbColor24.Name = "cbColor24";
            this.cbColor24.Size = new System.Drawing.Size(88, 29);
            this.cbColor24.TabIndex = 19;
            this.cbColor24.Text = "สี 24 สี";
            this.cbColor24.UseVisualStyleBackColor = true;
            this.cbColor24.CheckedChanged += new System.EventHandler(this.cbColor24_CheckedChanged);
            // 
            // tbColor24
            // 
            this.tbColor24.Enabled = false;
            this.tbColor24.Location = new System.Drawing.Point(378, 109);
            this.tbColor24.Name = "tbColor24";
            this.tbColor24.Size = new System.Drawing.Size(31, 31);
            this.tbColor24.TabIndex = 20;
            this.tbColor24.Text = "0";
            this.tbColor24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColor36
            // 
            this.tbColor36.Enabled = false;
            this.tbColor36.Location = new System.Drawing.Point(378, 146);
            this.tbColor36.Name = "tbColor36";
            this.tbColor36.Size = new System.Drawing.Size(31, 31);
            this.tbColor36.TabIndex = 21;
            this.tbColor36.Text = "0";
            this.tbColor36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColor48
            // 
            this.tbColor48.Enabled = false;
            this.tbColor48.Location = new System.Drawing.Point(378, 183);
            this.tbColor48.Name = "tbColor48";
            this.tbColor48.Size = new System.Drawing.Size(31, 31);
            this.tbColor48.TabIndex = 22;
            this.tbColor48.Text = "0";
            this.tbColor48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbLiquin
            // 
            this.cbLiquin.AutoSize = true;
            this.cbLiquin.Location = new System.Drawing.Point(216, 33);
            this.cbLiquin.Name = "cbLiquin";
            this.cbLiquin.Size = new System.Drawing.Size(143, 29);
            this.cbLiquin.TabIndex = 24;
            this.cbLiquin.Text = "ปากกาลบคําผิด";
            this.cbLiquin.UseVisualStyleBackColor = true;
            this.cbLiquin.CheckedChanged += new System.EventHandler(this.cbLiquin_CheckedChanged);
            // 
            // tbLiquid
            // 
            this.tbLiquid.Enabled = false;
            this.tbLiquid.Location = new System.Drawing.Point(378, 31);
            this.tbLiquid.Name = "tbLiquid";
            this.tbLiquid.Size = new System.Drawing.Size(31, 31);
            this.tbLiquid.TabIndex = 25;
            this.tbLiquid.Text = "0";
            this.tbLiquid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 518);
            this.Controls.Add(this.tbLiquid);
            this.Controls.Add(this.cbLiquin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbColor48);
            this.Controls.Add(this.tbColor36);
            this.Controls.Add(this.tbColor24);
            this.Controls.Add(this.cbColor24);
            this.Controls.Add(this.cbColor36);
            this.Controls.Add(this.cbColor48);
            this.Controls.Add(this.tbColor12);
            this.Controls.Add(this.tbEraser);
            this.Controls.Add(this.tbRuler);
            this.Controls.Add(this.tbPencil);
            this.Controls.Add(this.tbPen);
            this.Controls.Add(this.tbNotebook);
            this.Controls.Add(this.cbColor12);
            this.Controls.Add(this.cbEraser);
            this.Controls.Add(this.cbRuler);
            this.Controls.Add(this.cbPencil);
            this.Controls.Add(this.cbPen);
            this.Controls.Add(this.cbNotebook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private CheckBox cbNotebook;
        private CheckBox cbPen;
        private CheckBox cbPencil;
        private CheckBox cbRuler;
        private CheckBox cbEraser;
        private CheckBox cbColor12;
        private TextBox tbNotebook;
        private TextBox tbPen;
        private TextBox tbPencil;
        private TextBox tbRuler;
        private TextBox tbEraser;
        private TextBox tbColor12;
        private CheckBox cbColor48;
        private CheckBox cbColor36;
        private CheckBox cbColor24;
        private TextBox tbColor24;
        private TextBox tbColor36;
        private TextBox tbColor48;
        private Button button1;
        private CheckBox cbLiquin;
        private TextBox tbLiquid;
    }
}