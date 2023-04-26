
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLKS.UserControls
{
    partial class DatPhongControl
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
            dvgDSPT = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnDSPT_TimKiem = new System.Windows.Forms.Button();
            cbxDSPT_LoaiPhong = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dtDSPT_Date = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            btnDSPT_DatPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dvgDSPT).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dvgDSPT
            // 
            dvgDSPT.AllowUserToAddRows = false;
            dvgDSPT.AllowUserToDeleteRows = false;
            dvgDSPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dvgDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDSPT.Location = new System.Drawing.Point(4, 53);
            dvgDSPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dvgDSPT.Name = "dvgDSPT";
            dvgDSPT.ReadOnly = true;
            dvgDSPT.RowHeadersVisible = false;
            dvgDSPT.RowHeadersWidth = 51;
            dvgDSPT.RowTemplate.Height = 29;
            dvgDSPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dvgDSPT.Size = new System.Drawing.Size(674, 592);
            dvgDSPT.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dvgDSPT);
            panel1.Location = new System.Drawing.Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(683, 652);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(266, 31);
            label1.TabIndex = 5;
            label1.Text = "Danh sách phòng trống";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDSPT_TimKiem);
            panel2.Controls.Add(cbxDSPT_LoaiPhong);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtDSPT_Date);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(729, 213);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(295, 180);
            panel2.TabIndex = 6;
            // 
            // btnDSPT_TimKiem
            // 
            btnDSPT_TimKiem.Location = new System.Drawing.Point(187, 123);
            btnDSPT_TimKiem.Name = "btnDSPT_TimKiem";
            btnDSPT_TimKiem.Size = new System.Drawing.Size(88, 28);
            btnDSPT_TimKiem.TabIndex = 11;
            btnDSPT_TimKiem.Text = "Tìm kiếm";
            btnDSPT_TimKiem.UseVisualStyleBackColor = true;
            // 
            // cbxDSPT_LoaiPhong
            // 
            cbxDSPT_LoaiPhong.FormattingEnabled = true;
            cbxDSPT_LoaiPhong.Items.AddRange(new object[] { "Standard", "Deluxe" });
            cbxDSPT_LoaiPhong.Location = new System.Drawing.Point(21, 127);
            cbxDSPT_LoaiPhong.Name = "cbxDSPT_LoaiPhong";
            cbxDSPT_LoaiPhong.Size = new System.Drawing.Size(109, 23);
            cbxDSPT_LoaiPhong.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(21, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Loại phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(21, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Ngày";
            // 
            // dtDSPT_Date
            // 
            dtDSPT_Date.Location = new System.Drawing.Point(21, 68);
            dtDSPT_Date.Name = "dtDSPT_Date";
            dtDSPT_Date.Size = new System.Drawing.Size(254, 23);
            dtDSPT_Date.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 28);
            label2.TabIndex = 6;
            label2.Text = "Tìm kiếm";
            // 
            // btnDSPT_DatPhong
            // 
            btnDSPT_DatPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDSPT_DatPhong.Location = new System.Drawing.Point(917, 427);
            btnDSPT_DatPhong.Name = "btnDSPT_DatPhong";
            btnDSPT_DatPhong.Size = new System.Drawing.Size(107, 32);
            btnDSPT_DatPhong.TabIndex = 7;
            btnDSPT_DatPhong.Text = "Đặt phòng";
            btnDSPT_DatPhong.UseVisualStyleBackColor = true;
            // 
            // DatPhongControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnDSPT_DatPhong);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "DatPhongControl";
            Size = new System.Drawing.Size(1055, 692);
            Load += DatPhongControl_Load;
            Click += DatPhongControl_Load;
            ((System.ComponentModel.ISupportInitialize)dvgDSPT).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDSPT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDSPT_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDSPT_TimKiem;
        private System.Windows.Forms.ComboBox cbxDSPT_LoaiPhong;
        private System.Windows.Forms.Button btnDSPT_DatPhong;
    }
}
