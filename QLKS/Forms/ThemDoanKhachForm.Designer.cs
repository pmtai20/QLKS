namespace QLKS.Forms
{
    partial class ThemDoanKhachForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            TENKHCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TENKHCN, CMND });
            dataGridView1.Location = new System.Drawing.Point(79, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(653, 296);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(234, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(312, 31);
            label1.TabIndex = 1;
            label1.Text = "Thêm thông tin đoàn khách";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(219, 399);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(152, 29);
            button1.TabIndex = 2;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(431, 399);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(162, 29);
            button2.TabIndex = 3;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // TENKHCN
            // 
            TENKHCN.HeaderText = "TENKHCN";
            TENKHCN.MinimumWidth = 6;
            TENKHCN.Name = "TENKHCN";
            TENKHCN.Width = 300;
            // 
            // CMND
            // 
            CMND.HeaderText = "CMND";
            CMND.MinimumWidth = 6;
            CMND.Name = "CMND";
            CMND.Width = 300;
            // 
            // ThemDoanKhachForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ThemDoanKhachForm";
            Text = "ThemDoanKhachForm";
            Load += ThemDoanKhachForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
    }
}