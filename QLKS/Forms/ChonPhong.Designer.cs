namespace QLKS.Forms
{
    partial class ChonPhong
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
            label2 = new System.Windows.Forms.Label();
            button_Tim = new System.Windows.Forms.Button();
            txt_TenPhong = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            gv_Phong = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gv_Phong).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(-31, -46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(248, 25);
            label2.TabIndex = 38;
            label2.Text = "Thông tin Phòng đang lưu trú";
            // 
            // button_Tim
            // 
            button_Tim.Location = new System.Drawing.Point(239, -83);
            button_Tim.Name = "button_Tim";
            button_Tim.Size = new System.Drawing.Size(112, 34);
            button_Tim.TabIndex = 36;
            button_Tim.Text = "Tìm";
            button_Tim.UseVisualStyleBackColor = true;
            // 
            // txt_TenPhong
            // 
            txt_TenPhong.Location = new System.Drawing.Point(71, -80);
            txt_TenPhong.Name = "txt_TenPhong";
            txt_TenPhong.Size = new System.Drawing.Size(150, 31);
            txt_TenPhong.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(-31, -80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 25);
            label1.TabIndex = 34;
            label1.Text = "Tên phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(69, 60);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(248, 25);
            label3.TabIndex = 43;
            label3.Text = "Thông tin Phòng đang lưu trú";
            // 
            // gv_Phong
            // 
            gv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_Phong.Location = new System.Drawing.Point(69, 101);
            gv_Phong.Name = "gv_Phong";
            gv_Phong.RowHeadersWidth = 62;
            gv_Phong.Size = new System.Drawing.Size(863, 539);
            gv_Phong.TabIndex = 42;
            gv_Phong.CellDoubleClick += gv_Phong_cellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(339, 23);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 41;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Tim_Clicked;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(171, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 31);
            textBox1.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(69, 26);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 25);
            label4.TabIndex = 39;
            label4.Text = "Tên phòng";
            // 
            // ChonPhong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1001, 663);
            Controls.Add(label3);
            Controls.Add(gv_Phong);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button_Tim);
            Controls.Add(txt_TenPhong);
            Controls.Add(label1);
            Name = "ChonPhong";
            Text = "ChonPhong";
            Load += ChonPhong_Load;
            ((System.ComponentModel.ISupportInitialize)gv_Phong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gv_Phong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}