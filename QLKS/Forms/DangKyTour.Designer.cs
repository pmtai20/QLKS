namespace QLKS.Forms
{
    partial class DangKyTour
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
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label8 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Tour";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(137, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(334, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(168, 25);
            label2.TabIndex = 2;
            label2.Text = "Thời gian khởi hành";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(542, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(43, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 25);
            label3.TabIndex = 4;
            label3.Text = "Số lượng";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(137, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(542, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(182, 33);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(334, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(144, 25);
            label4.TabIndex = 7;
            label4.Text = "Dịch vụ đưa đón";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(43, 158);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 25);
            label5.TabIndex = 8;
            label5.Text = "Yêu cầu đặc biệt";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(203, 155);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(639, 77);
            textBox3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(552, 257);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 25);
            label6.TabIndex = 10;
            label6.Text = "Kết quả";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(660, 254);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(182, 33);
            comboBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(48, 248);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 25);
            label7.TabIndex = 12;
            label7.Text = "Tổng tiền";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(137, 248);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(150, 31);
            textBox4.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, tenkh, sdt, cmnd });
            dataGridView1.Location = new System.Drawing.Point(48, 369);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(738, 225);
            dataGridView1.TabIndex = 14;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(48, 325);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(215, 25);
            label8.TabIndex = 15;
            label8.Text = "Thông tin người tham gia";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(295, 325);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 16;
            button1.Text = "Chỉnh sửa";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(851, 531);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 63);
            button2.TabIndex = 17;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = true;
            // 
            // DangKyTour
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1033, 636);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "DangKyTour";
            Text = "DangKyTour";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}