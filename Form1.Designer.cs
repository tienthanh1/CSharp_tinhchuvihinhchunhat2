namespace CSharp_tinhchuvihinhchunhat2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblngang = new System.Windows.Forms.Label();
            this.txtngang = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.lvldoc = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndientich = new System.Windows.Forms.Button();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.rdbChuvi = new System.Windows.Forms.RadioButton();
            this.rdbDientich = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblngang
            // 
            this.lblngang.AutoSize = true;
            this.lblngang.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngang.Location = new System.Drawing.Point(85, 70);
            this.lblngang.Name = "lblngang";
            this.lblngang.Size = new System.Drawing.Size(114, 23);
            this.lblngang.TabIndex = 0;
            this.lblngang.Text = "chiều ngang";
            // 
            // txtngang
            // 
            this.txtngang.Location = new System.Drawing.Point(257, 70);
            this.txtngang.Name = "txtngang";
            this.txtngang.Size = new System.Drawing.Size(100, 20);
            this.txtngang.TabIndex = 1;
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(257, 132);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(100, 20);
            this.txtdoc.TabIndex = 3;
            // 
            // lvldoc
            // 
            this.lvldoc.AutoSize = true;
            this.lvldoc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvldoc.Location = new System.Drawing.Point(85, 132);
            this.lvldoc.Name = "lvldoc";
            this.lvldoc.Size = new System.Drawing.Size(89, 23);
            this.lvldoc.TabIndex = 2;
            this.lvldoc.Text = "chiều dọc";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(257, 192);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 5;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(85, 189);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(70, 23);
            this.lblketqua.TabIndex = 4;
            this.lblketqua.Text = "kết quả";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(257, 395);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(102, 43);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndientich
            // 
            this.btndientich.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndientich.Location = new System.Drawing.Point(448, 316);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(95, 36);
            this.btndientich.TabIndex = 8;
            this.btndientich.Text = "diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnchuvi
            // 
            this.btnchuvi.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuvi.Location = new System.Drawing.Point(79, 316);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(95, 36);
            this.btnchuvi.TabIndex = 9;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // rdbChuvi
            // 
            this.rdbChuvi.AutoSize = true;
            this.rdbChuvi.Location = new System.Drawing.Point(15, 21);
            this.rdbChuvi.Name = "rdbChuvi";
            this.rdbChuvi.Size = new System.Drawing.Size(55, 17);
            this.rdbChuvi.TabIndex = 10;
            this.rdbChuvi.TabStop = true;
            this.rdbChuvi.Text = "Chu vi";
            this.rdbChuvi.UseVisualStyleBackColor = true;
            this.rdbChuvi.CheckedChanged += new System.EventHandler(this.rdbChuvi_CheckedChanged);
            // 
            // rdbDientich
            // 
            this.rdbDientich.AutoSize = true;
            this.rdbDientich.Location = new System.Drawing.Point(15, 44);
            this.rdbDientich.Name = "rdbDientich";
            this.rdbDientich.Size = new System.Drawing.Size(69, 17);
            this.rdbDientich.TabIndex = 11;
            this.rdbDientich.TabStop = true;
            this.rdbDientich.Text = "Diện tích";
            this.rdbDientich.UseVisualStyleBackColor = true;
            this.rdbDientich.CheckedChanged += new System.EventHandler(this.rdbDientich_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChuvi);
            this.groupBox1.Controls.Add(this.rdbDientich);
            this.groupBox1.Location = new System.Drawing.Point(424, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(468, 180);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 13;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.lvldoc);
            this.Controls.Add(this.txtngang);
            this.Controls.Add(this.lblngang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblngang;
        private System.Windows.Forms.TextBox txtngang;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.Label lvldoc;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.RadioButton rdbChuvi;
        private System.Windows.Forms.RadioButton rdbDientich;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntinh;
    }
}

