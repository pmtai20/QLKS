namespace QLKS.Forms
{
    partial class ThemDichVu
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
            txt_TenDV = new System.Windows.Forms.TextBox();
            btn_Tim = new System.Windows.Forms.Button();
            btn_XacNhan = new System.Windows.Forms.Button();
            txt_TongTien = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            gv_KQTimDV = new System.Windows.Forms.DataGridView();
            stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GIASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            btn_Them = new System.Windows.Forms.Button();
            btn_Tro_Ve = new System.Windows.Forms.Button();
            btn_Xoa = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cbb_NguoiDK = new System.Windows.Forms.ComboBox();
            gv_DichVuDaThem = new System.Windows.Forms.DataGridView();
            sttdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GIATHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TENNGUOIDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gv_KQTimDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv_DichVuDaThem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 25);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // txt_TenDV
            // 
            txt_TenDV.Location = new System.Drawing.Point(195, 48);
            txt_TenDV.Name = "txt_TenDV";
            txt_TenDV.Size = new System.Drawing.Size(150, 31);
            txt_TenDV.TabIndex = 1;
            // 
            // btn_Tim
            // 
            btn_Tim.Location = new System.Drawing.Point(367, 45);
            btn_Tim.Name = "btn_Tim";
            btn_Tim.Size = new System.Drawing.Size(112, 34);
            btn_Tim.TabIndex = 2;
            btn_Tim.Text = "Tìm";
            btn_Tim.UseVisualStyleBackColor = true;
            btn_Tim.Click += btn_Tim_Clicked;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new System.Drawing.Point(303, 579);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new System.Drawing.Size(112, 34);
            btn_XacNhan.TabIndex = 23;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new System.Drawing.Point(613, 573);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new System.Drawing.Size(229, 31);
            txt_TongTien.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(520, 579);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 25);
            label5.TabIndex = 21;
            label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(221, 25);
            label4.TabIndex = 19;
            label4.Text = "Thông tin dịch vụ đã thêm";
            label4.Click += label4_Click;
            // 
            // gv_KQTimDV
            // 
            gv_KQTimDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_KQTimDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, TENSP, GIASP, check });
            gv_KQTimDV.Location = new System.Drawing.Point(29, 99);
            gv_KQTimDV.Name = "gv_KQTimDV";
            gv_KQTimDV.RowHeadersWidth = 62;
            gv_KQTimDV.RowTemplate.Height = 33;
            gv_KQTimDV.Size = new System.Drawing.Size(638, 178);
            gv_KQTimDV.TabIndex = 24;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 75;
            // 
            // TENSP
            // 
            TENSP.DataPropertyName = "TENSP";
            TENSP.HeaderText = "Tên dịch vụ";
            TENSP.MinimumWidth = 8;
            TENSP.Name = "TENSP";
            TENSP.Width = 275;
            // 
            // GIASP
            // 
            GIASP.DataPropertyName = "GIASP";
            GIASP.HeaderText = "Giá tiền";
            GIASP.MinimumWidth = 8;
            GIASP.Name = "GIASP";
            GIASP.Width = 125;
            // 
            // check
            // 
            check.DataPropertyName = "check";
            check.HeaderText = "Chọn";
            check.MinimumWidth = 8;
            check.Name = "check";
            check.Width = 75;
            // 
            // btn_Them
            // 
            btn_Them.Location = new System.Drawing.Point(676, 243);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new System.Drawing.Size(73, 34);
            btn_Them.TabIndex = 25;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Clicked;
            // 
            // btn_Tro_Ve
            // 
            btn_Tro_Ve.Location = new System.Drawing.Point(29, 11);
            btn_Tro_Ve.Name = "btn_Tro_Ve";
            btn_Tro_Ve.Size = new System.Drawing.Size(112, 34);
            btn_Tro_Ve.TabIndex = 26;
            btn_Tro_Ve.Text = "Trở Về";
            btn_Tro_Ve.UseVisualStyleBackColor = true;
            btn_Tro_Ve.Click += btn_TroVe_Clicked;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new System.Drawing.Point(29, 579);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new System.Drawing.Size(244, 34);
            btn_Xoa.TabIndex = 27;
            btn_Xoa.Text = "Xóa Dịch Vụ Đã chọn";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Clicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(520, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 25);
            label2.TabIndex = 28;
            label2.Text = "Người Đăng Ký";
            // 
            // cbb_NguoiDK
            // 
            cbb_NguoiDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_NguoiDK.FormattingEnabled = true;
            cbb_NguoiDK.Location = new System.Drawing.Point(666, 45);
            cbb_NguoiDK.Name = "cbb_NguoiDK";
            cbb_NguoiDK.Size = new System.Drawing.Size(182, 33);
            cbb_NguoiDK.TabIndex = 29;
            // 
            // gv_DichVuDaThem
            // 
            gv_DichVuDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_DichVuDaThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { sttdv, TENDV, soluong, GIATHANH, giamgia, TENNGUOIDK, checkbox });
            gv_DichVuDaThem.Location = new System.Drawing.Point(22, 308);
            gv_DichVuDaThem.Name = "gv_DichVuDaThem";
            gv_DichVuDaThem.RowHeadersWidth = 62;
            gv_DichVuDaThem.RowTemplate.Height = 33;
            gv_DichVuDaThem.Size = new System.Drawing.Size(984, 248);
            gv_DichVuDaThem.TabIndex = 43;
            gv_DichVuDaThem.CellValueChanged += gv_DVDT_CellValueChanged;
            // 
            // sttdv
            // 
            sttdv.DataPropertyName = "STTDV";
            sttdv.HeaderText = "STT";
            sttdv.MinimumWidth = 8;
            sttdv.Name = "sttdv";
            sttdv.Width = 150;
            // 
            // TENDV
            // 
            TENDV.DataPropertyName = "TENDV";
            TENDV.HeaderText = "Tên dịch vụ";
            TENDV.MinimumWidth = 8;
            TENDV.Name = "TENDV";
            TENDV.Width = 150;
            // 
            // soluong
            // 
            soluong.DataPropertyName = "SOLUONG";
            soluong.HeaderText = "SL";
            soluong.MinimumWidth = 8;
            soluong.Name = "soluong";
            soluong.Width = 75;
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
            // checkbox
            // 
            checkbox.HeaderText = "Chọn";
            checkbox.MinimumWidth = 8;
            checkbox.Name = "checkbox";
            checkbox.Width = 75;
            // 
            // ThemDichVu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1018, 672);
            Controls.Add(gv_DichVuDaThem);
            Controls.Add(cbb_NguoiDK);
            Controls.Add(label2);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Tro_Ve);
            Controls.Add(btn_Them);
            Controls.Add(gv_KQTimDV);
            Controls.Add(btn_XacNhan);
            Controls.Add(txt_TongTien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_Tim);
            Controls.Add(txt_TenDV);
            Controls.Add(label1);
            Name = "ThemDichVu";
            Text = "ThemDichVu";
            Load += ThemDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)gv_KQTimDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv_DichVuDaThem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenDV;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gv_KQTimDV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Tro_Ve;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_NguoiDK;
        private System.Windows.Forms.DataGridView gv_DichVuDaThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIASP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUOIDK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
    }
}