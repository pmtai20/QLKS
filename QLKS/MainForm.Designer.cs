
namespace QLKS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            datPhongControl1 = new UserControls.DatPhongControl();
            DatPhongControl = new UserControls.DatPhongControl();
            tabPage2 = new System.Windows.Forms.TabPage();
            TimPhongControl = new UserControls.TimPhongControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            dichVuControl1 = new UserControls.DichVuControl();
            tabPage4 = new System.Windows.Forms.TabPage();
            tourControl1 = new UserControls.TourControl();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new System.Drawing.Point(14, 15);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1507, 1183);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(datPhongControl1);
            tabPage1.Controls.Add(DatPhongControl);
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(1499, 1145);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đặt phòng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // datPhongControl1
            // 
            datPhongControl1.Location = new System.Drawing.Point(0, 0);
            datPhongControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            datPhongControl1.Name = "datPhongControl1";
            datPhongControl1.Size = new System.Drawing.Size(2260, 1730);
            datPhongControl1.TabIndex = 1;
            // 
            // DatPhongControl
            // 
            DatPhongControl.Dock = System.Windows.Forms.DockStyle.Fill;
            DatPhongControl.Location = new System.Drawing.Point(4, 3);
            DatPhongControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            DatPhongControl.Name = "DatPhongControl";
            DatPhongControl.Size = new System.Drawing.Size(1491, 1139);
            DatPhongControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TimPhongControl);
            tabPage2.Location = new System.Drawing.Point(4, 34);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Size = new System.Drawing.Size(1499, 1145);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tìm phòng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TimPhongControl
            // 
            TimPhongControl.Location = new System.Drawing.Point(-5, 7);
            TimPhongControl.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            TimPhongControl.Name = "TimPhongControl";
            TimPhongControl.Size = new System.Drawing.Size(1210, 690);
            TimPhongControl.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dichVuControl1);
            tabPage3.Location = new System.Drawing.Point(4, 34);
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Size = new System.Drawing.Size(1499, 1145);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dịch vụ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dichVuControl1
            // 
            dichVuControl1.Location = new System.Drawing.Point(7, 6);
            dichVuControl1.Name = "dichVuControl1";
            dichVuControl1.Size = new System.Drawing.Size(1450, 1008);
            dichVuControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tourControl1);
            tabPage4.Location = new System.Drawing.Point(4, 34);
            tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Size = new System.Drawing.Size(1499, 1145);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tour";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tourControl1
            // 
            tourControl1.Location = new System.Drawing.Point(3, 6);
            tourControl1.Name = "tourControl1";
            tourControl1.Size = new System.Drawing.Size(1552, 1030);
            tourControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1135, 719);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Quan Ly Khach San";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private UserControls.TimPhongControl TimPhongControl;
        private UserControls.DatPhongControl DatPhongControl;
        private UserControls.DichVuControl dichVuControl1;
        private UserControls.TourControl tourControl1;
        private UserControls.DatPhongControl datPhongControl1;
    }
}

