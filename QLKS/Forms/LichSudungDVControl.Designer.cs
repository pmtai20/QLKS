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
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label4 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            sttdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(813, 331);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(112, 34);
            button4.TabIndex = 21;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(813, 423);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 34);
            button3.TabIndex = 20;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(561, 131);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(138, 51);
            button2.TabIndex = 19;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { sttdv, tendv, soluong, gia, giamgia, Column1 });
            dataGridView1.Location = new System.Drawing.Point(30, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(748, 248);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(221, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            dateTimePicker1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(45, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 25);
            label1.TabIndex = 23;
            label1.Text = "Số người tham gia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 25);
            label2.TabIndex = 24;
            label2.Text = "Thời gian sử dụng";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(221, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 31);
            textBox1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 136);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(154, 25);
            label3.TabIndex = 26;
            label3.Text = "Chú thích đặc biệt";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(221, 136);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(300, 46);
            textBox2.TabIndex = 27;
            // 
            // sttdv
            // 
            sttdv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            sttdv.HeaderText = "STT";
            sttdv.MinimumWidth = 8;
            sttdv.Name = "sttdv";
            sttdv.Width = 76;
            // 
            // tendv
            // 
            tendv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            tendv.HeaderText = "Thời gian sử dụng";
            tendv.MinimumWidth = 8;
            tendv.Name = "tendv";
            tendv.Width = 138;
            // 
            // soluong
            // 
            soluong.HeaderText = "Số người";
            soluong.MinimumWidth = 8;
            soluong.Name = "soluong";
            soluong.Width = 150;
            // 
            // gia
            // 
            gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            gia.HeaderText = "NgayDK";
            gia.MinimumWidth = 8;
            gia.Name = "gia";
            gia.Width = 113;
            // 
            // giamgia
            // 
            giamgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            giamgia.HeaderText = "Chú Thích";
            giamgia.MinimumWidth = 8;
            giamgia.Name = "giamgia";
            giamgia.Width = 116;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Chọn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Column1.Width = 90;
            // 
            // LichSudungDVControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1039, 553);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Name = "LichSudungDVControl";
            Text = "LichSudungDVControl";
            Load += LichSudungDVControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}