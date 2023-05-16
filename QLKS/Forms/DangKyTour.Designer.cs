namespace QLKS.Forms
{
    partial class DangKyTour
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
            label1 = new System.Windows.Forms.Label();
            txt_MaTour = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            txt_SoLuong = new System.Windows.Forms.TextBox();
            cbb_DuaDon = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txt_YeuCau = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            cbb_KetQua = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            txt_TongTien = new System.Windows.Forms.TextBox();
            gv_ThamGia = new System.Windows.Forms.DataGridView();
            stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label8 = new System.Windows.Forms.Label();
            btn_ChinhSua = new System.Windows.Forms.Button();
            btn_XacNhan = new System.Windows.Forms.Button();
            btn_TroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)gv_ThamGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Tour";
            // 
            // txt_MaTour
            // 
            txt_MaTour.Location = new System.Drawing.Point(137, 59);
            txt_MaTour.Name = "txt_MaTour";
            txt_MaTour.Size = new System.Drawing.Size(150, 31);
            txt_MaTour.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(334, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(168, 25);
            label2.TabIndex = 2;
            label2.Text = "Thời gian khởi hành";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(542, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(43, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 25);
            label3.TabIndex = 4;
            label3.Text = "Số lượng";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new System.Drawing.Point(137, 107);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new System.Drawing.Size(150, 31);
            txt_SoLuong.TabIndex = 5;
            // 
            // cbb_DuaDon
            // 
            cbb_DuaDon.FormattingEnabled = true;
            cbb_DuaDon.Location = new System.Drawing.Point(542, 107);
            cbb_DuaDon.Name = "cbb_DuaDon";
            cbb_DuaDon.Size = new System.Drawing.Size(182, 33);
            cbb_DuaDon.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(334, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(144, 25);
            label4.TabIndex = 7;
            label4.Text = "Dịch vụ đưa đón";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(43, 158);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 25);
            label5.TabIndex = 8;
            label5.Text = "Yêu cầu đặc biệt";
            // 
            // txt_YeuCau
            // 
            txt_YeuCau.Location = new System.Drawing.Point(203, 155);
            txt_YeuCau.Multiline = true;
            txt_YeuCau.Name = "txt_YeuCau";
            txt_YeuCau.Size = new System.Drawing.Size(639, 77);
            txt_YeuCau.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(552, 257);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 25);
            label6.TabIndex = 10;
            label6.Text = "Kết quả";
            // 
            // cbb_KetQua
            // 
            cbb_KetQua.FormattingEnabled = true;
            cbb_KetQua.Location = new System.Drawing.Point(660, 254);
            cbb_KetQua.Name = "cbb_KetQua";
            cbb_KetQua.Size = new System.Drawing.Size(182, 33);
            cbb_KetQua.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(48, 248);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 25);
            label7.TabIndex = 12;
            label7.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new System.Drawing.Point(137, 248);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new System.Drawing.Size(150, 31);
            txt_TongTien.TabIndex = 13;
            // 
            // gv_ThamGia
            // 
            gv_ThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_ThamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, tenkh, sdt, cmnd });
            gv_ThamGia.Location = new System.Drawing.Point(48, 369);
            gv_ThamGia.Name = "gv_ThamGia";
            gv_ThamGia.RowHeadersWidth = 62;
            gv_ThamGia.RowTemplate.Height = 33;
            gv_ThamGia.Size = new System.Drawing.Size(738, 225);
            gv_ThamGia.TabIndex = 14;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 75;
            // 
            // tenkh
            // 
            tenkh.DataPropertyName = "TENKHCN";
            tenkh.HeaderText = "Họ Tên";
            tenkh.MinimumWidth = 8;
            tenkh.Name = "tenkh";
            tenkh.Width = 300;
            // 
            // sdt
            // 
            sdt.DataPropertyName = "SDT";
            sdt.HeaderText = "SĐT";
            sdt.MinimumWidth = 8;
            sdt.Name = "sdt";
            sdt.Width = 150;
            // 
            // cmnd
            // 
            cmnd.DataPropertyName = "CMND";
            cmnd.HeaderText = "CMND";
            cmnd.MinimumWidth = 8;
            cmnd.Name = "cmnd";
            cmnd.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(48, 325);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(215, 25);
            label8.TabIndex = 15;
            label8.Text = "Thông tin người tham gia";
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new System.Drawing.Point(295, 325);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new System.Drawing.Size(112, 34);
            btn_ChinhSua.TabIndex = 16;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            btn_ChinhSua.Click += btn_ChinhSua_Clicked;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new System.Drawing.Point(851, 531);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new System.Drawing.Size(135, 63);
            btn_XacNhan.TabIndex = 17;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            // 
            // btn_TroVe
            // 
            btn_TroVe.Location = new System.Drawing.Point(43, 12);
            btn_TroVe.Name = "btn_TroVe";
            btn_TroVe.Size = new System.Drawing.Size(112, 34);
            btn_TroVe.TabIndex = 18;
            btn_TroVe.Text = "Trở Về";
            btn_TroVe.UseVisualStyleBackColor = true;
            btn_TroVe.Click += btn_TroVe_Clicked;
            // 
            // DangKyTour
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1033, 636);
            Controls.Add(btn_TroVe);
            Controls.Add(btn_XacNhan);
            Controls.Add(btn_ChinhSua);
            Controls.Add(label8);
            Controls.Add(gv_ThamGia);
            Controls.Add(txt_TongTien);
            Controls.Add(label7);
            Controls.Add(cbb_KetQua);
            Controls.Add(label6);
            Controls.Add(txt_YeuCau);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbb_DuaDon);
            Controls.Add(txt_SoLuong);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txt_MaTour);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "DangKyTour";
            Text = "DangKyTour";
            Load += DangKyTour_Load;
            ((System.ComponentModel.ISupportInitialize)gv_ThamGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.ComboBox cbb_DuaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_YeuCau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_KetQua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_ChinhSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridView gv_ThamGia;
    }
}