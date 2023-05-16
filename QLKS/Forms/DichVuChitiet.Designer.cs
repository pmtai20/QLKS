namespace QLKS.Forms
{
    partial class DichVuChitiet
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
            button5 = new System.Windows.Forms.Button();
            btn_Sua = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            btn_Them = new System.Windows.Forms.Button();
            gv_KhachHang = new System.Windows.Forms.DataGridView();
            stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gv_DSDichVu = new System.Windows.Forms.DataGridView();
            sttdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SOLUONGDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GIATHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TENNGUOIDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            txt_NgayDi = new System.Windows.Forms.TextBox();
            txt_NgayDen = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_MaPhong = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btn_TroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)gv_KhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv_DSDichVu).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(712, 321);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(177, 34);
            button5.TabIndex = 47;
            button5.Text = "Xem lịch sử dụng";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_XemLich_Clicked;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new System.Drawing.Point(575, 320);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new System.Drawing.Size(112, 34);
            btn_Sua.TabIndex = 46;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Clicked;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(437, 320);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 34);
            button3.TabIndex = 45;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_Xoa_Clicked;
            // 
            // btn_Them
            // 
            btn_Them.Location = new System.Drawing.Point(303, 321);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new System.Drawing.Size(112, 34);
            btn_Them.TabIndex = 44;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Clicked;
            // 
            // gv_KhachHang
            // 
            gv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, TenKH, sdt, cmnd });
            gv_KhachHang.Location = new System.Drawing.Point(75, 97);
            gv_KhachHang.Name = "gv_KhachHang";
            gv_KhachHang.RowHeadersWidth = 62;
            gv_KhachHang.RowTemplate.Height = 33;
            gv_KhachHang.Size = new System.Drawing.Size(738, 192);
            gv_KhachHang.TabIndex = 43;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 75;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKHCN";
            TenKH.HeaderText = "Họ Tên";
            TenKH.MinimumWidth = 8;
            TenKH.Name = "TenKH";
            TenKH.Width = 300;
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
            // gv_DSDichVu
            // 
            gv_DSDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            gv_DSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_DSDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { sttdv, TENSP, SOLUONGDV, GIATHANH, giamgia, TENNGUOIDK });
            gv_DSDichVu.Location = new System.Drawing.Point(12, 361);
            gv_DSDichVu.Name = "gv_DSDichVu";
            gv_DSDichVu.RowHeadersWidth = 62;
            gv_DSDichVu.RowTemplate.Height = 33;
            gv_DSDichVu.Size = new System.Drawing.Size(984, 248);
            gv_DSDichVu.TabIndex = 42;
            gv_DSDichVu.CellValueChanged += gv_DSDVDATHEM_CellValueChanged;
            // 
            // sttdv
            // 
            sttdv.HeaderText = "STT";
            sttdv.MinimumWidth = 8;
            sttdv.Name = "sttdv";
            sttdv.Width = 150;
            // 
            // TENSP
            // 
            TENSP.DataPropertyName = "TENSP";
            TENSP.HeaderText = "Tên dịch vụ";
            TENSP.MinimumWidth = 8;
            TENSP.Name = "TENSP";
            TENSP.Width = 150;
            // 
            // SOLUONGDV
            // 
            SOLUONGDV.DataPropertyName = "SOLUONG";
            SOLUONGDV.HeaderText = "SL";
            SOLUONGDV.MinimumWidth = 8;
            SOLUONGDV.Name = "SOLUONGDV";
            SOLUONGDV.Width = 150;
            // 
            // GIATHANH
            // 
            GIATHANH.DataPropertyName = "GIATHANH";
            GIATHANH.HeaderText = "Giá tiền";
            GIATHANH.MinimumWidth = 8;
            GIATHANH.Name = "GIATHANH";
            GIATHANH.Width = 150;
            // 
            // giamgia
            // 
            giamgia.DataPropertyName = "GIAMGIA";
            giamgia.HeaderText = "Giảm giá";
            giamgia.MinimumWidth = 8;
            giamgia.Name = "giamgia";
            giamgia.Width = 125;
            // 
            // TENNGUOIDK
            // 
            TENNGUOIDK.DataPropertyName = "TENNGUOIDK";
            TENNGUOIDK.FillWeight = 225F;
            TENNGUOIDK.HeaderText = "Người ĐK";
            TENNGUOIDK.MinimumWidth = 8;
            TENNGUOIDK.Name = "TENNGUOIDK";
            TENNGUOIDK.Width = 200;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(76, 322);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(221, 25);
            label4.TabIndex = 41;
            label4.Text = "Thông tin dịch vụ đã thêm";
            // 
            // txt_NgayDi
            // 
            txt_NgayDi.Location = new System.Drawing.Point(702, 51);
            txt_NgayDi.Name = "txt_NgayDi";
            txt_NgayDi.Size = new System.Drawing.Size(150, 31);
            txt_NgayDi.TabIndex = 54;
            // 
            // txt_NgayDen
            // 
            txt_NgayDen.Location = new System.Drawing.Point(457, 51);
            txt_NgayDen.Name = "txt_NgayDen";
            txt_NgayDen.Size = new System.Drawing.Size(150, 31);
            txt_NgayDen.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(622, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 25);
            label3.TabIndex = 52;
            label3.Text = "Ngày đi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(362, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 25);
            label2.TabIndex = 51;
            label2.Text = "Ngày đến";
            // 
            // txt_MaPhong
            // 
            txt_MaPhong.Location = new System.Drawing.Point(180, 54);
            txt_MaPhong.Name = "txt_MaPhong";
            txt_MaPhong.Size = new System.Drawing.Size(150, 31);
            txt_MaPhong.TabIndex = 49;
            txt_MaPhong.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(78, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 25);
            label1.TabIndex = 48;
            label1.Text = "Tên phòng";
            // 
            // btn_TroVe
            // 
            btn_TroVe.Location = new System.Drawing.Point(12, 15);
            btn_TroVe.Name = "btn_TroVe";
            btn_TroVe.Size = new System.Drawing.Size(115, 34);
            btn_TroVe.TabIndex = 55;
            btn_TroVe.Text = "Trở Về";
            btn_TroVe.UseVisualStyleBackColor = true;
            btn_TroVe.Click += btn_TroVe_Clicked;
            // 
            // DichVuChitiet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1027, 621);
            Controls.Add(btn_TroVe);
            Controls.Add(txt_NgayDi);
            Controls.Add(txt_NgayDen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_MaPhong);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(btn_Sua);
            Controls.Add(button3);
            Controls.Add(btn_Them);
            Controls.Add(gv_KhachHang);
            Controls.Add(gv_DSDichVu);
            Controls.Add(label4);
            Name = "DichVuChitiet";
            Text = "DichVuChitiet";
            Load += DichVuChitiet_Load;
            ((System.ComponentModel.ISupportInitialize)gv_KhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv_DSDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView gv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridView gv_DSDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.TextBox txt_NgayDi;
        private System.Windows.Forms.TextBox txt_NgayDen;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUOIDK;
        private System.Windows.Forms.Button btn_Sua;
    }
}