using System.Data;
using System.Data.SqlClient;

namespace QLKS.UserControls
{
    partial class DichVuControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string connectionString = "Server=localhost;Database=QLKS;Trusted_Connection=True;";

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
            label1 = new System.Windows.Forms.Label();
            txt_TenPhong = new System.Windows.Forms.TextBox();
            button_Tim = new System.Windows.Forms.Button();
            gv_Phong = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gv_Phong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 25);
            label1.TabIndex = 29;
            label1.Text = "Tên phòng";
            // 
            // txt_TenPhong
            // 
            txt_TenPhong.Location = new System.Drawing.Point(151, 38);
            txt_TenPhong.Name = "txt_TenPhong";
            txt_TenPhong.Size = new System.Drawing.Size(150, 31);
            txt_TenPhong.TabIndex = 30;
            // 
            // button_Tim
            // 
            button_Tim.Location = new System.Drawing.Point(319, 35);
            button_Tim.Name = "button_Tim";
            button_Tim.Size = new System.Drawing.Size(112, 34);
            button_Tim.TabIndex = 31;
            button_Tim.Text = "Tìm";
            button_Tim.UseVisualStyleBackColor = true;
            button_Tim.Click += btn_Tim_Clicked;
            // 
            // gv_Phong
            // 
            gv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_Phong.Location = new System.Drawing.Point(49, 113);
            gv_Phong.Name = "gv_Phong";
            gv_Phong.RowHeadersWidth = 62;
            gv_Phong.Size = new System.Drawing.Size(863, 539);
            gv_Phong.TabIndex = 32;
            gv_Phong.CellDoubleClick += gv_Phong_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(248, 25);
            label2.TabIndex = 33;
            label2.Text = "Thông tin Phòng đang lưu trú";
            label2.Click += label2_Click;
            // 
            // DichVuControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(gv_Phong);
            Controls.Add(button_Tim);
            Controls.Add(txt_TenPhong);
            Controls.Add(label1);
            Name = "DichVuControl";
            Size = new System.Drawing.Size(967, 672);
            Load += MH_Load;
            ((System.ComponentModel.ISupportInitialize)gv_Phong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.DataGridView gv_Phong;
        private System.Windows.Forms.Label label2;
    }
}
