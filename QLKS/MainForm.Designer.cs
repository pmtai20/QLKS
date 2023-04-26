
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
            tabPage2 = new System.Windows.Forms.TabPage();
            TimPhongControl = new UserControls.TimPhongControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            tabPage1 = new System.Windows.Forms.TabPage();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new System.Drawing.Point(10, 9);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1055, 710);
            tabControl1.TabIndex = 0;
            tabControl1.Controls.Add(tabPage1);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TimPhongControl);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage2.Size = new System.Drawing.Size(837, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Phiếu đặt phòng";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Margin = new System.Windows.Forms.Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage1.Size = new System.Drawing.Size(1047, 682);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "example tab";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // TimPhongControl
            // 
            TimPhongControl.Location = new System.Drawing.Point(39, 1);
            TimPhongControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TimPhongControl.Name = "TimPhongControl";
            TimPhongControl.Size = new System.Drawing.Size(781, 414);
            TimPhongControl.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage3.Size = new System.Drawing.Size(838, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dịch vụ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage4.Size = new System.Drawing.Size(838, 412);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tour";
            tabPage4.UseVisualStyleBackColor = true;
            // 
<<<<<<<

=======
            // tabPage5
            // 
            tabPage5.Location = new System.Drawing.Point(4, 24);
            tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage5.Size = new System.Drawing.Size(838, 412);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Thanh toán";
            tabPage5.UseVisualStyleBackColor = true;
            // 
>>>>>>>
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1067, 724);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Quan Ly Khach San";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
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
        private DatPhongControl DatPhongControl;
    }
}

