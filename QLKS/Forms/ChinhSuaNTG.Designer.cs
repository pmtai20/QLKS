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
            button1 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            chon1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(270, 78);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 33;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, tenkh, sdt, cmnd, chon1 });
            dataGridView1.Location = new System.Drawing.Point(38, 406);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(811, 225);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, chon });
            dataGridView2.Location = new System.Drawing.Point(38, 115);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new System.Drawing.Size(811, 225);
            dataGridView2.TabIndex = 34;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "SĐT";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "CMND";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // chon
            // 
            chon.HeaderText = "Chọn";
            chon.MinimumWidth = 8;
            chon.Name = "chon";
            chon.Width = 75;
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
            tenkh.HeaderText = "Họ Tên";
            tenkh.MinimumWidth = 8;
            tenkh.Name = "tenkh";
            tenkh.Width = 300;
            // 
            // sdt
            // 
            sdt.HeaderText = "SĐT";
            sdt.MinimumWidth = 8;
            sdt.Name = "sdt";
            sdt.Width = 150;
            // 
            // cmnd
            // 
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
            // button2
            // 
            button2.Location = new System.Drawing.Point(268, 362);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 34);
            button2.TabIndex = 36;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(38, 21);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(231, 34);
            button3.TabIndex = 37;
            button3.Text = "Load danh sách khách hàng";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(869, 500);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(125, 90);
            button4.TabIndex = 38;
            button4.Text = "Xác nhận";
            button4.UseVisualStyleBackColor = true;
            // 
            // ChinhSuaNTG
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1006, 648);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Name = "ChinhSuaNTG";
            Text = "ChinhSuaNTG";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}