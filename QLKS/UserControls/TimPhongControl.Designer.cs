namespace QLKS.UserControls
{
    partial class TimPhongControl
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
            button2 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            MADP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TENKHCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NGAYNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NGAYDATPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(381, 212);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(178, 48);
            button2.TabIndex = 13;
            button2.Text = "Cập nhật phiếu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { MADP, TENKHCN, NGAYNHAN, NGAYTRA, NGAYDATPHONG, LOAIPHONG, TRANGTHAI });
            dataGridView1.Location = new System.Drawing.Point(40, 268);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1051, 391);
            dataGridView1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(658, 164);
            dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(344, 31);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new System.DateTime(2023, 5, 31, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(150, 164);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(338, 31);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 164);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 25);
            label2.TabIndex = 15;
            label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(529, 170);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 25);
            label3.TabIndex = 16;
            label3.Text = "Đến ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(647, 92);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 25);
            label4.TabIndex = 18;
            label4.Text = "Trang Thai";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "all", "processing", "check in", "check out" });
            comboBox2.Location = new System.Drawing.Point(771, 89);
            comboBox2.Margin = new System.Windows.Forms.Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(150, 33);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(150, 92);
            textBox1.Margin = new System.Windows.Forms.Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(169, 31);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(44, 92);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 25);
            label5.TabIndex = 20;
            label5.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(46, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(333, 38);
            label1.TabIndex = 21;
            label1.Text = "TÌM PHIẾU ĐẶT PHÒNG";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(348, 92);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(126, 25);
            label6.TabIndex = 23;
            label6.Text = "Mã đặt phòng";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(499, 92);
            textBox2.Margin = new System.Windows.Forms.Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(110, 31);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(590, 212);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(178, 48);
            button1.TabIndex = 24;
            button1.Text = "Check Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(161, 212);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(178, 48);
            button3.TabIndex = 25;
            button3.Text = "Check In";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(46, 224);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 25);
            label7.TabIndex = 26;
            label7.Text = "Chức năng";
            // 
            // MADP
            // 
            MADP.DataPropertyName = "MADP";
            MADP.HeaderText = "MADP";
            MADP.MinimumWidth = 8;
            MADP.Name = "MADP";
            MADP.Width = 75;
            // 
            // TENKHCN
            // 
            TENKHCN.DataPropertyName = "TENKHCN";
            TENKHCN.HeaderText = "TENKH";
            TENKHCN.MinimumWidth = 8;
            TENKHCN.Name = "TENKHCN";
            TENKHCN.Width = 300;
            // 
            // NGAYNHAN
            // 
            NGAYNHAN.DataPropertyName = "NGAYNHAN";
            NGAYNHAN.HeaderText = "NGAYNHAN";
            NGAYNHAN.MinimumWidth = 8;
            NGAYNHAN.Name = "NGAYNHAN";
            NGAYNHAN.Width = 125;
            // 
            // NGAYTRA
            // 
            NGAYTRA.DataPropertyName = "NGAYTRA";
            NGAYTRA.HeaderText = "NGAYTRA";
            NGAYTRA.MinimumWidth = 8;
            NGAYTRA.Name = "NGAYTRA";
            NGAYTRA.Width = 125;
            // 
            // NGAYDATPHONG
            // 
            NGAYDATPHONG.DataPropertyName = "NGAYDATPHONG";
            NGAYDATPHONG.HeaderText = "NGAYDAT";
            NGAYDATPHONG.MinimumWidth = 8;
            NGAYDATPHONG.Name = "NGAYDATPHONG";
            NGAYDATPHONG.Width = 125;
            // 
            // LOAIPHONG
            // 
            LOAIPHONG.DataPropertyName = "LOAIPHONG";
            LOAIPHONG.HeaderText = "LOAIPHONG";
            LOAIPHONG.MinimumWidth = 8;
            LOAIPHONG.Name = "LOAIPHONG";
            LOAIPHONG.Width = 125;
            // 
            // TRANGTHAI
            // 
            TRANGTHAI.DataPropertyName = "TRANGTHAI";
            TRANGTHAI.HeaderText = "TRANGTHAI";
            TRANGTHAI.MinimumWidth = 8;
            TRANGTHAI.Name = "TRANGTHAI";
            TRANGTHAI.Width = 125;
            // 
            // TimPhongControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "TimPhongControl";
            Size = new System.Drawing.Size(1505, 698);
            Load += TimPhongControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDATPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
    }
}
