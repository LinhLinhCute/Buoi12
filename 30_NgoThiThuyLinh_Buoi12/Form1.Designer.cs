namespace _30_NgoThiThuyLinh_Buoi12
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
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.cbB_Thaotac = new System.Windows.Forms.ComboBox();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.gB_ThongTin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_tenLop = new System.Windows.Forms.TextBox();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.gB_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Location = new System.Drawing.Point(1, 123);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.Size = new System.Drawing.Size(628, 175);
            this.dgv_SinhVien.TabIndex = 0;
            // 
            // cbB_Thaotac
            // 
            this.cbB_Thaotac.FormattingEnabled = true;
            this.cbB_Thaotac.Location = new System.Drawing.Point(415, 33);
            this.cbB_Thaotac.Name = "cbB_Thaotac";
            this.cbB_Thaotac.Size = new System.Drawing.Size(121, 21);
            this.cbB_Thaotac.TabIndex = 1;
            // 
            // btn_Chon
            // 
            this.btn_Chon.Location = new System.Drawing.Point(554, 29);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(75, 23);
            this.btn_Chon.TabIndex = 2;
            this.btn_Chon.Text = "Chọn ";
            this.btn_Chon.UseVisualStyleBackColor = true;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // gB_ThongTin
            // 
            this.gB_ThongTin.Controls.Add(this.txt_DiaChi);
            this.gB_ThongTin.Controls.Add(this.txt_NgaySinh);
            this.gB_ThongTin.Controls.Add(this.txt_tenLop);
            this.gB_ThongTin.Controls.Add(this.txt_ten);
            this.gB_ThongTin.Controls.Add(this.txt_MaSV);
            this.gB_ThongTin.Controls.Add(this.label5);
            this.gB_ThongTin.Controls.Add(this.label4);
            this.gB_ThongTin.Controls.Add(this.label3);
            this.gB_ThongTin.Controls.Add(this.label2);
            this.gB_ThongTin.Controls.Add(this.label1);
            this.gB_ThongTin.Location = new System.Drawing.Point(12, 12);
            this.gB_ThongTin.Name = "gB_ThongTin";
            this.gB_ThongTin.Size = new System.Drawing.Size(384, 105);
            this.gB_ThongTin.TabIndex = 3;
            this.gB_ThongTin.TabStop = false;
            this.gB_ThongTin.Text = "Thông tin";
            this.gB_ThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Lớp: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ: ";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(59, 19);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(132, 20);
            this.txt_MaSV.TabIndex = 5;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(59, 45);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(132, 20);
            this.txt_ten.TabIndex = 6;
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Location = new System.Drawing.Point(59, 72);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Size = new System.Drawing.Size(195, 20);
            this.txt_tenLop.TabIndex = 7;
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(269, 19);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(100, 20);
            this.txt_NgaySinh.TabIndex = 8;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(269, 42);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(100, 20);
            this.txt_DiaChi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thao tác:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 295);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gB_ThongTin);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.cbB_Thaotac);
            this.Controls.Add(this.dgv_SinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.gB_ThongTin.ResumeLayout(false);
            this.gB_ThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.ComboBox cbB_Thaotac;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.GroupBox gB_ThongTin;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.TextBox txt_tenLop;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}

