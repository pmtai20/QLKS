namespace QLKS.Forms
{
    partial class ChinhSuaNTG
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
            btn_Them = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            gv_ThamGia = new System.Windows.Forms.DataGridView();
            stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            chon1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label1 = new System.Windows.Forms.Label();
            btn_Xoa = new System.Windows.Forms.Button();
            btn_XacNhan = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txt_Phong = new System.Windows.Forms.TextBox();
            btn_TaiDuLieu = new System.Windows.Forms.Button();
            btn_TroVe = new System.Windows.Forms.Button();
            gv_KhachHang = new System.Windows.Forms.DataGridView();
            stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TENKHCN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sdt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmnd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gv_ThamGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv_KhachHang).BeginInit();
            SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.Location = new System.Drawing.Point(270, 78);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new System.Drawing.Size(112, 34);
            btn_Them.TabIndex = 33;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Clicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(38, 362);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(215, 25);
            label8.TabIndex = 32;
            label8.Text = "Thông tin người tham gia";
            label8.Click += label8_Click;
            // 
            // gv_ThamGia
            // 
            gv_ThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_ThamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, tenkh, sdt, cmnd, chon1 });
            gv_ThamGia.Location = new System.Drawing.Point(38, 406);
            gv_ThamGia.Name = "gv_ThamGia";
            gv_ThamGia.RowHeadersWidth = 62;
            gv_ThamGia.RowTemplate.Height = 33;
            gv_ThamGia.Size = new System.Drawing.Size(825, 225);
            gv_ThamGia.TabIndex = 31;
            gv_ThamGia.CellContentClick += dataGridView1_CellContentClick;
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
            // chon1
            // 
            chon1.HeaderText = "Chọn";
            chon1.MinimumWidth = 8;
            chon1.Name = "chon1";
            chon1.Width = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(184, 25);
            label1.TabIndex = 35;
            label1.Text = "Thông tin khách hàng";
            label1.Click += label1_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new System.Drawing.Point(268, 362);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new System.Drawing.Size(112, 34);
            btn_Xoa.TabIndex = 36;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Clicked;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new System.Drawing.Point(869, 500);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new System.Drawing.Size(125, 90);
            btn_XacNhan.TabIndex = 38;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Clicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(328, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 25);
            label2.TabIndex = 39;
            label2.Text = "Phòng";
            // 
            // txt_Phong
            // 
            txt_Phong.Location = new System.Drawing.Point(407, 18);
            txt_Phong.Name = "txt_Phong";
            txt_Phong.Size = new System.Drawing.Size(150, 31);
            txt_Phong.TabIndex = 40;
            // 
            // btn_TaiDuLieu
            // 
            btn_TaiDuLieu.Location = new System.Drawing.Point(584, 15);
            btn_TaiDuLieu.Name = "btn_TaiDuLieu";
            btn_TaiDuLieu.Size = new System.Drawing.Size(258, 34);
            btn_TaiDuLieu.TabIndex = 41;
            btn_TaiDuLieu.Text = "Tải Dữ Liệu Phòng";
            btn_TaiDuLieu.UseVisualStyleBackColor = true;
            btn_TaiDuLieu.Click += btn_TaiDuLieu_Clicked;
            // 
            // btn_TroVe
            // 
            btn_TroVe.Location = new System.Drawing.Point(38, 18);
            btn_TroVe.Name = "btn_TroVe";
            btn_TroVe.Size = new System.Drawing.Size(112, 34);
            btn_TroVe.TabIndex = 42;
            btn_TroVe.Text = "Trở Về";
            btn_TroVe.UseVisualStyleBackColor = true;
            btn_TroVe.Click += btn_TroVe_Clicked;
            // 
            // gv_KhachHang
            // 
            gv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt1, TENKHCN1, sdt1, cmnd1, check });
            gv_KhachHang.Location = new System.Drawing.Point(38, 118);
            gv_KhachHang.Name = "gv_KhachHang";
            gv_KhachHang.RowHeadersWidth = 62;
            gv_KhachHang.RowTemplate.Height = 33;
            gv_KhachHang.Size = new System.Drawing.Size(831, 238);
            gv_KhachHang.TabIndex = 44;
            // 
            // stt1
            // 
            stt1.HeaderText = "STT";
            stt1.MinimumWidth = 8;
            stt1.Name = "stt1";
            stt1.Width = 75;
            // 
            // TENKHCN1
            // 
            TENKHCN1.DataPropertyName = "TenKHCN";
            TENKHCN1.HeaderText = "Họ Tên";
            TENKHCN1.MinimumWidth = 8;
            TENKHCN1.Name = "TENKHCN1";
            TENKHCN1.Width = 300;
            // 
            // sdt1
            // 
            sdt1.DataPropertyName = "SDT";
            sdt1.HeaderText = "SĐT";
            sdt1.MinimumWidth = 8;
            sdt1.Name = "sdt1";
            sdt1.Width = 150;
            // 
            // cmnd1
            // 
            cmnd1.DataPropertyName = "CMND";
            cmnd1.HeaderText = "CMND";
            cmnd1.MinimumWidth = 8;
            cmnd1.Name = "cmnd1";
            cmnd1.Width = 150;
            // 
            // check
            // 
            check.HeaderText = "Chọn";
            check.MinimumWidth = 8;
            check.Name = "check";
            check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            check.Width = 75;
            // 
            // ChinhSuaNTG
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1006, 648);
            Controls.Add(gv_KhachHang);
            Controls.Add(btn_TroVe);
            Controls.Add(btn_TaiDuLieu);
            Controls.Add(txt_Phong);
            Controls.Add(label2);
            Controls.Add(btn_XacNhan);
            Controls.Add(btn_Xoa);
            Controls.Add(label1);
            Controls.Add(btn_Them);
            Controls.Add(label8);
            Controls.Add(gv_ThamGia);
            Name = "ChinhSuaNTG";
            Text = "ChinhSuaNTG";
            Load += ChinhSuaNTG_Load;
            ((System.ComponentModel.ISupportInitialize)gv_ThamGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv_KhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gv_ThamGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_TaiDuLieu;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.TextBox txt_Phong;
        private System.Windows.Forms.DataGridView gv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHCN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon1;
    }
}