using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLKS.Forms
{
    partial class CheckOutForm : Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            checkout = new Panel();
            groupBox1 = new GroupBox();
            label22 = new Label();
            soNguoiTrongDoanKH = new Label();
            label20 = new Label();
            tenDoanKH = new Label();
            khachDoan = new CheckBox();
            khachLe = new CheckBox();
            label17 = new Label();
            DSPhong = new GroupBox();
            dataPhong = new DataGridView();
            sdtKH = new Label();
            DSKhachHang = new GroupBox();
            dataKH = new DataGridView();
            soDemLuuTruKH = new Label();
            ngayNhanPhongKH = new Label();
            cmndKH = new Label();
            diaChiKH = new Label();
            emailKH = new Label();
            ngayTraPhongKH = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tenKH = new Label();
            thanhToan = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkout.SuspendLayout();
            groupBox1.SuspendLayout();
            DSPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPhong).BeginInit();
            DSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataKH).BeginInit();
            SuspendLayout();
            // 
            // checkout
            // 
            checkout.AutoScroll = true;
            checkout.Controls.Add(groupBox1);
            checkout.Controls.Add(khachDoan);
            checkout.Controls.Add(khachLe);
            checkout.Controls.Add(label17);
            checkout.Controls.Add(DSPhong);
            checkout.Controls.Add(sdtKH);
            checkout.Controls.Add(DSKhachHang);
            checkout.Controls.Add(soDemLuuTruKH);
            checkout.Controls.Add(ngayNhanPhongKH);
            checkout.Controls.Add(cmndKH);
            checkout.Controls.Add(diaChiKH);
            checkout.Controls.Add(emailKH);
            checkout.Controls.Add(ngayTraPhongKH);
            checkout.Controls.Add(label9);
            checkout.Controls.Add(label8);
            checkout.Controls.Add(label7);
            checkout.Controls.Add(tenKH);
            checkout.Controls.Add(thanhToan);
            checkout.Controls.Add(label1);
            checkout.Controls.Add(label2);
            checkout.Controls.Add(label5);
            checkout.Controls.Add(label3);
            checkout.Controls.Add(label4);
            checkout.Dock = DockStyle.Fill;
            checkout.Location = new Point(0, 0);
            checkout.Name = "checkout";
            checkout.Size = new Size(804, 494);
            checkout.TabIndex = 0;
            checkout.Paint += checkout_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(soNguoiTrongDoanKH);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(tenDoanKH);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(40, 264);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 78);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "ĐOÀN KHÁCH";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label22.Location = new Point(338, 40);
            label22.Name = "label22";
            label22.Size = new Size(150, 20);
            label22.TabIndex = 28;
            label22.Text = "Số người trong đoàn:";
            // 
            // soNguoiTrongDoanKH
            // 
            soNguoiTrongDoanKH.AutoSize = true;
            soNguoiTrongDoanKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            soNguoiTrongDoanKH.Location = new Point(494, 40);
            soNguoiTrongDoanKH.Name = "soNguoiTrongDoanKH";
            soNguoiTrongDoanKH.Size = new Size(17, 20);
            soNguoiTrongDoanKH.TabIndex = 25;
            soNguoiTrongDoanKH.Text = "4";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label20.Location = new Point(47, 40);
            label20.Name = "label20";
            label20.Size = new Size(73, 20);
            label20.TabIndex = 26;
            label20.Text = "Tên đoàn:";
            // 
            // tenDoanKH
            // 
            tenDoanKH.AutoSize = true;
            tenDoanKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tenDoanKH.Location = new Point(126, 40);
            tenDoanKH.Name = "tenDoanKH";
            tenDoanKH.Size = new Size(88, 20);
            tenDoanKH.TabIndex = 27;
            tenDoanKH.Text = "Đoàn KHTN";
            // 
            // khachDoan
            // 
            khachDoan.AutoSize = true;
            khachDoan.Location = new Point(147, 210);
            khachDoan.Name = "khachDoan";
            khachDoan.Size = new Size(109, 24);
            khachDoan.TabIndex = 31;
            khachDoan.Text = "Khách đoàn";
            khachDoan.UseVisualStyleBackColor = true;
            // 
            // khachLe
            // 
            khachLe.AutoSize = true;
            khachLe.Checked = true;
            khachLe.CheckState = CheckState.Checked;
            khachLe.Location = new Point(40, 210);
            khachLe.Name = "khachLe";
            khachLe.Size = new Size(87, 24);
            khachLe.TabIndex = 30;
            khachLe.Text = "Khách lẻ";
            khachLe.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label17.Location = new Point(378, 210);
            label17.Name = "label17";
            label17.Size = new Size(110, 20);
            label17.TabIndex = 23;
            label17.Text = "Số đêm lưu trú:";
            // 
            // DSPhong
            // 
            DSPhong.Controls.Add(dataPhong);
            DSPhong.Location = new Point(77, 360);
            DSPhong.Name = "DSPhong";
            DSPhong.Size = new Size(628, 253);
            DSPhong.TabIndex = 10;
            DSPhong.TabStop = false;
            DSPhong.Text = "Danh sách phòng";
            // 
            // dataPhong
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataPhong.DefaultCellStyle = dataGridViewCellStyle2;
            dataPhong.Location = new Point(6, 32);
            dataPhong.Name = "dataPhong";
            dataPhong.RowHeadersWidth = 51;
            dataPhong.RowTemplate.Height = 29;
            dataPhong.Size = new Size(616, 215);
            dataPhong.TabIndex = 10;
            // 
            // sdtKH
            // 
            sdtKH.AutoSize = true;
            sdtKH.Location = new Point(484, 68);
            sdtKH.Name = "sdtKH";
            sdtKH.Size = new Size(81, 20);
            sdtKH.TabIndex = 22;
            sdtKH.Text = "03xxxxxxxx";
            // 
            // DSKhachHang
            // 
            DSKhachHang.Controls.Add(dataKH);
            DSKhachHang.Location = new Point(77, 657);
            DSKhachHang.Name = "DSKhachHang";
            DSKhachHang.Size = new Size(628, 253);
            DSKhachHang.TabIndex = 9;
            DSKhachHang.TabStop = false;
            DSKhachHang.Text = "Danh sách khách hàng";
            // 
            // dataKH
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataKH.DefaultCellStyle = dataGridViewCellStyle4;
            dataKH.Location = new Point(6, 26);
            dataKH.Name = "dataKH";
            dataKH.RowHeadersWidth = 51;
            dataKH.RowTemplate.Height = 29;
            dataKH.Size = new Size(616, 221);
            dataKH.TabIndex = 10;
            // 
            // soDemLuuTruKH
            // 
            soDemLuuTruKH.AutoSize = true;
            soDemLuuTruKH.Location = new Point(494, 210);
            soDemLuuTruKH.Name = "soDemLuuTruKH";
            soDemLuuTruKH.Size = new Size(25, 20);
            soDemLuuTruKH.TabIndex = 21;
            soDemLuuTruKH.Text = "11";
            // 
            // ngayNhanPhongKH
            // 
            ngayNhanPhongKH.AutoSize = true;
            ngayNhanPhongKH.Location = new Point(176, 160);
            ngayNhanPhongKH.Name = "ngayNhanPhongKH";
            ngayNhanPhongKH.Size = new Size(161, 20);
            ngayNhanPhongKH.TabIndex = 20;
            ngayNhanPhongKH.Text = "Monday, April 09, 2023";
            // 
            // cmndKH
            // 
            cmndKH.AutoSize = true;
            cmndKH.Location = new Point(666, 68);
            cmndKH.Name = "cmndKH";
            cmndKH.Size = new Size(95, 20);
            cmndKH.TabIndex = 19;
            cmndKH.Text = "07xxxxxxxxxx";
            // 
            // diaChiKH
            // 
            diaChiKH.AutoSize = true;
            diaChiKH.Location = new Point(442, 112);
            diaChiKH.Name = "diaChiKH";
            diaChiKH.Size = new Size(58, 20);
            diaChiKH.TabIndex = 18;
            diaChiKH.Text = "TPHCM";
            // 
            // emailKH
            // 
            emailKH.AutoSize = true;
            emailKH.Location = new Point(95, 112);
            emailKH.Name = "emailKH";
            emailKH.Size = new Size(117, 20);
            emailKH.TabIndex = 17;
            emailKH.Text = "test@gmail.com";
            // 
            // ngayTraPhongKH
            // 
            ngayTraPhongKH.AutoSize = true;
            ngayTraPhongKH.Location = new Point(500, 160);
            ngayTraPhongKH.Name = "ngayTraPhongKH";
            ngayTraPhongKH.Size = new Size(161, 20);
            ngayTraPhongKH.TabIndex = 16;
            ngayTraPhongKH.Text = "Monday, April 09, 2023";
            ngayTraPhongKH.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(378, 160);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 15;
            label9.Text = "Ngày trả phòng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(40, 160);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 14;
            label8.Text = "Ngày nhận phòng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(378, 112);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 13;
            label7.Text = "Địa chỉ:";
            // 
            // tenKH
            // 
            tenKH.AutoSize = true;
            tenKH.Location = new Point(103, 68);
            tenKH.Name = "tenKH";
            tenKH.Size = new Size(30, 20);
            tenKH.TabIndex = 12;
            tenKH.Text = "Vie";
            // 
            // thanhToan
            // 
            thanhToan.BackColor = SystemColors.ActiveCaption;
            thanhToan.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            thanhToan.Location = new Point(613, 926);
            thanhToan.Name = "thanhToan";
            thanhToan.Size = new Size(146, 43);
            thanhToan.TabIndex = 11;
            thanhToan.Text = "Thanh toán";
            thanhToan.UseVisualStyleBackColor = false;
            thanhToan.Click += thanhToan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 31);
            label1.TabIndex = 7;
            label1.Text = "CHECK OUT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(378, 68);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(604, 68);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "CMND:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(40, 68);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(40, 112);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // CheckOutForm
            // 
            //AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(804, 494);
            Controls.Add(checkout);
            Name = "CheckOutForm";
            Text = "CheckOutForm";
            Load += CheckOutForm_Load;
            checkout.ResumeLayout(false);
            checkout.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            DSPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataPhong).EndInit();
            DSKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataKH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel checkout;
        private System.Windows.Forms.GroupBox DSPhong;
        private System.Windows.Forms.DataGridView dataPhong;
        private System.Windows.Forms.GroupBox DSKhachHang;
        private System.Windows.Forms.DataGridView dataKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thanhToan;
        private Label label22;
        private Label tenDoanKH;
        private Label label20;
        private Label soNguoiTrongDoanKH;
        private Label label17;
        private Label sdtKH;
        private Label soDemLuuTruKH;
        private Label ngayNhanPhongKH;
        private Label cmndKH;
        private Label diaChiKH;
        private Label emailKH;
        private Label ngayTraPhongKH;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label tenKH;
        private CheckBox khachDoan;
        private CheckBox khachLe;
        private GroupBox groupBox1;
    }
}
