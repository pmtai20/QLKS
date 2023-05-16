namespace QLKS.Forms
{
    partial class LichSudungDVControl
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
            btn_Sua = new System.Windows.Forms.Button();
            btn_Xoa = new System.Windows.Forms.Button();
            btn_Them = new System.Windows.Forms.Button();
            gv_LichSuDung = new System.Windows.Forms.DataGridView();
            sttdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TGSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SOLUONGTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NGAYDANGKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            YEUCAUDACBIET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            thoigiansudung = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_SoNguoi = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txt_ChuThich = new System.Windows.Forms.TextBox();
            btn_TroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)gv_LichSuDung).BeginInit();
            SuspendLayout();
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new System.Drawing.Point(172, 230);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new System.Drawing.Size(112, 34);
            btn_Sua.TabIndex = 21;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Clicked;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new System.Drawing.Point(318, 230);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new System.Drawing.Size(112, 34);
            btn_Xoa.TabIndex = 20;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Clicked;
            // 
            // btn_Them
            // 
            btn_Them.Location = new System.Drawing.Point(561, 171);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new System.Drawing.Size(138, 51);
            btn_Them.TabIndex = 19;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Clicked;
            // 
            // gv_LichSuDung
            // 
            gv_LichSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_LichSuDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { sttdv, TGSD, SOLUONGTG, NGAYDANGKY, YEUCAUDACBIET });
            gv_LichSuDung.Location = new System.Drawing.Point(30, 277);
            gv_LichSuDung.Name = "gv_LichSuDung";
            gv_LichSuDung.RowHeadersWidth = 62;
            gv_LichSuDung.RowTemplate.Height = 33;
            gv_LichSuDung.Size = new System.Drawing.Size(889, 248);
            gv_LichSuDung.TabIndex = 18;
            gv_LichSuDung.CellContentClick += dataGridView1_CellContentClick;
            gv_LichSuDung.CellValueChanged += gv_LichSuDung_CellValuedChanged;
            // 
            // sttdv
            // 
            sttdv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            sttdv.HeaderText = "STT";
            sttdv.MinimumWidth = 8;
            sttdv.Name = "sttdv";
            sttdv.Width = 50;
            // 
            // TGSD
            // 
            TGSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            TGSD.DataPropertyName = "THOIGIANSUDUNG";
            TGSD.HeaderText = "Thời gian sử dụng";
            TGSD.MinimumWidth = 8;
            TGSD.Name = "TGSD";
            TGSD.Width = 138;
            // 
            // SOLUONGTG
            // 
            SOLUONGTG.DataPropertyName = "SOLUONG";
            SOLUONGTG.HeaderText = "Số người";
            SOLUONGTG.MinimumWidth = 8;
            SOLUONGTG.Name = "SOLUONGTG";
            SOLUONGTG.Width = 80;
            // 
            // NGAYDANGKY
            // 
            NGAYDANGKY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            NGAYDANGKY.DataPropertyName = "NGAYDANGKY";
            NGAYDANGKY.HeaderText = "NgayDK";
            NGAYDANGKY.MinimumWidth = 8;
            NGAYDANGKY.Name = "NGAYDANGKY";
            NGAYDANGKY.Width = 113;
            // 
            // YEUCAUDACBIET
            // 
            YEUCAUDACBIET.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            YEUCAUDACBIET.DataPropertyName = "YEUCAUDACBIET";
            YEUCAUDACBIET.HeaderText = "Chú Thích";
            YEUCAUDACBIET.MinimumWidth = 8;
            YEUCAUDACBIET.Name = "YEUCAUDACBIET";
            YEUCAUDACBIET.Width = 300;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(30, 235);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 25);
            label4.TabIndex = 17;
            label4.Text = "Lịch sử dụng";
            label4.Click += label4_Click;
            // 
            // thoigiansudung
            // 
            thoigiansudung.Location = new System.Drawing.Point(221, 122);
            thoigiansudung.Name = "thoigiansudung";
            thoigiansudung.Size = new System.Drawing.Size(300, 31);
            thoigiansudung.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(45, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 25);
            label1.TabIndex = 23;
            label1.Text = "Số người tham gia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 25);
            label2.TabIndex = 24;
            label2.Text = "Thời gian sử dụng";
            // 
            // txt_SoNguoi
            // 
            txt_SoNguoi.Location = new System.Drawing.Point(221, 73);
            txt_SoNguoi.Name = "txt_SoNguoi";
            txt_SoNguoi.Size = new System.Drawing.Size(150, 31);
            txt_SoNguoi.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 176);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(154, 25);
            label3.TabIndex = 26;
            label3.Text = "Chú thích đặc biệt";
            // 
            // txt_ChuThich
            // 
            txt_ChuThich.Location = new System.Drawing.Point(221, 176);
            txt_ChuThich.Multiline = true;
            txt_ChuThich.Name = "txt_ChuThich";
            txt_ChuThich.Size = new System.Drawing.Size(300, 46);
            txt_ChuThich.TabIndex = 27;
            // 
            // btn_TroVe
            // 
            btn_TroVe.Location = new System.Drawing.Point(45, 12);
            btn_TroVe.Name = "btn_TroVe";
            btn_TroVe.Size = new System.Drawing.Size(112, 34);
            btn_TroVe.TabIndex = 28;
            btn_TroVe.Text = "Trở về";
            btn_TroVe.UseVisualStyleBackColor = true;
            btn_TroVe.Click += btn_TroVe_Clicked;
            // 
            // LichSudungDVControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1119, 553);
            Controls.Add(btn_TroVe);
            Controls.Add(txt_ChuThich);
            Controls.Add(label3);
            Controls.Add(txt_SoNguoi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(thoigiansudung);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(gv_LichSuDung);
            Controls.Add(label4);
            Name = "LichSudungDVControl";
            Text = "LichSudungDVControl";
            Load += LichSudungDVControl_Load;
            ((System.ComponentModel.ISupportInitialize)gv_LichSuDung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gv_LichSuDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker thoigiansudung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoNguoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ChuThich;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDANGKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEUCAUDACBIET;
    }
}