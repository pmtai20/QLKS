using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLKS.UserControls
{
    partial class ThanhToanControl
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
            thanhToan = new Panel();
            thoat = new Button();
            inHoaDon = new Button();
            phuongThucTT = new Label();
            label4 = new Label();
            label8 = new Label();
            tongTIen = new Label();
            tienPhong = new Label();
            tienDV = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dataDV = new DataGridView();
            label1 = new Label();
            thanhToan.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDV).BeginInit();
            SuspendLayout();
            // 
            // thanhToan
            // 
            thanhToan.AutoScroll = true;
            thanhToan.AutoSize = true;
            thanhToan.Controls.Add(thoat);
            thanhToan.Controls.Add(inHoaDon);
            thanhToan.Controls.Add(phuongThucTT);
            thanhToan.Controls.Add(label4);
            thanhToan.Controls.Add(label8);
            thanhToan.Controls.Add(tongTIen);
            thanhToan.Controls.Add(tienPhong);
            thanhToan.Controls.Add(tienDV);
            thanhToan.Controls.Add(label3);
            thanhToan.Controls.Add(label2);
            thanhToan.Controls.Add(groupBox1);
            thanhToan.Controls.Add(label1);
            thanhToan.Dock = DockStyle.Fill;
            thanhToan.Location = new Point(0, 0);
            thanhToan.Name = "thanhToan";
            thanhToan.Size = new Size(822, 541);
            thanhToan.TabIndex = 0;
            // 
            // thoat
            // 
            thoat.BackColor = SystemColors.ActiveCaption;
            thoat.Location = new Point(459, 495);
            thoat.Name = "thoat";
            thoat.Size = new Size(118, 43);
            thoat.TabIndex = 13;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = false;
            thoat.Click += thoat_Click;
            // 
            // inHoaDon
            // 
            inHoaDon.BackColor = SystemColors.ActiveCaption;
            inHoaDon.Location = new Point(238, 495);
            inHoaDon.Name = "inHoaDon";
            inHoaDon.Size = new Size(118, 43);
            inHoaDon.TabIndex = 12;
            inHoaDon.Text = "In hóa đơn";
            inHoaDon.UseVisualStyleBackColor = false;
            // 
            // phuongThucTT
            // 
            phuongThucTT.AutoSize = true;
            phuongThucTT.Location = new Point(660, 447);
            phuongThucTT.Name = "phuongThucTT";
            phuongThucTT.Size = new Size(67, 20);
            phuongThucTT.TabIndex = 11;
            phuongThucTT.Text = "Tiền mặt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(483, 447);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 10;
            label4.Text = "Phương thức thanh toán:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(493, 410);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
            label8.TabIndex = 8;
            label8.Text = "Tổng tiền thanh toán:";
            // 
            // tongTIen
            // 
            tongTIen.AutoSize = true;
            tongTIen.Location = new Point(696, 410);
            tongTIen.Name = "tongTIen";
            tongTIen.Size = new Size(17, 20);
            tongTIen.TabIndex = 7;
            tongTIen.Text = "0";
            tongTIen.TextAlign = ContentAlignment.TopRight;
            tongTIen.Click += tongTIen_Click;
            // 
            // tienPhong
            // 
            tienPhong.AutoSize = true;
            tienPhong.Location = new Point(696, 374);
            tienPhong.Name = "tienPhong";
            tienPhong.Size = new Size(17, 20);
            tienPhong.TabIndex = 5;
            tienPhong.Text = "0";
            tienPhong.TextAlign = ContentAlignment.TopRight;
            tienPhong.Click += tienPhong_Click;
            // 
            // tienDV
            // 
            tienDV.AutoSize = true;
            tienDV.Location = new Point(696, 338);
            tienDV.Name = "tienDV";
            tienDV.Size = new Size(17, 20);
            tienDV.TabIndex = 4;
            tienDV.Text = "0";
            tienDV.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 338);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "Tiền dịch vụ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 374);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Tiền phòng:";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataDV);
            groupBox1.Location = new Point(55, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 256);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách dịch vụ";
            // 
            // dataDV
            // 
            dataDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDV.Location = new Point(6, 30);
            dataDV.Name = "dataDV";
            dataDV.RowHeadersWidth = 51;
            dataDV.RowTemplate.Height = 29;
            dataDV.Size = new Size(694, 220);
            dataDV.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(327, 13);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 0;
            label1.Text = "THANH TOÁN";
            label1.Click += label1_Click;
            // 
            // ThanhToanControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(thanhToan);
            Name = "ThanhToanControl";
            Size = new Size(822, 541);
            Load += ThanhToanControl_Load;
            thanhToan.ResumeLayout(false);
            thanhToan.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel thanhToan;
        private System.Windows.Forms.DataGridView dataDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tongTIen;
        private System.Windows.Forms.Label tienPhong;
        private System.Windows.Forms.Label tienDV;
        private System.Windows.Forms.Label phuongThucTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button inHoaDon;
    }
}
