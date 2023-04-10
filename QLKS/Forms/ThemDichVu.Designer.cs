namespace QLKS.Forms
{
    partial class ThemDichVu
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
            button1 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            textBox4 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            sttdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            button2 = new System.Windows.Forms.Button();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên dịch vụ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(195, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(367, 45);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(666, 626);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(112, 34);
            button6.TabIndex = 23;
            button6.Text = "Xác nhận";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(613, 573);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(229, 31);
            textBox4.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(520, 579);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 25);
            label5.TabIndex = 21;
            label5.Text = "Tổng tiền";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { sttdv, tendv, soluong, gia, giamgia });
            dataGridView1.Location = new System.Drawing.Point(29, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(813, 248);
            dataGridView1.TabIndex = 20;
            // 
            // sttdv
            // 
            sttdv.HeaderText = "STT";
            sttdv.MinimumWidth = 8;
            sttdv.Name = "sttdv";
            sttdv.Width = 150;
            // 
            // tendv
            // 
            tendv.HeaderText = "Tên dịch vụ";
            tendv.MinimumWidth = 8;
            tendv.Name = "tendv";
            tendv.Width = 150;
            // 
            // soluong
            // 
            soluong.HeaderText = "SL";
            soluong.MinimumWidth = 8;
            soluong.Name = "soluong";
            soluong.Width = 150;
            // 
            // gia
            // 
            gia.HeaderText = "Giá tiền";
            gia.MinimumWidth = 8;
            gia.Name = "gia";
            gia.Width = 150;
            // 
            // giamgia
            // 
            giamgia.HeaderText = "Giảm giá";
            giamgia.MinimumWidth = 8;
            giamgia.Name = "giamgia";
            giamgia.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(221, 25);
            label4.TabIndex = 19;
            label4.Text = "Thông tin dịch vụ đã thêm";
            label4.Click += label4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, Column1 });
            dataGridView2.Location = new System.Drawing.Point(29, 99);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new System.Drawing.Size(608, 178);
            dataGridView2.TabIndex = 24;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(870, 171);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(73, 34);
            button2.TabIndex = 25;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
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
            dataGridViewTextBoxColumn2.HeaderText = "Tên dịch vụ";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 275;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Giá tiền";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Chọn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // listView1
            // 
            listView1.Location = new System.Drawing.Point(643, 95);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(199, 182);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ThemDichVu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(977, 672);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ThemDichVu";
            Text = "ThemDichVu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ListView listView1;
    }
}