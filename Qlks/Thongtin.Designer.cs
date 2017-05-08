namespace Qlks
{
    partial class Thongtin
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.bt_go = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1183, 615);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(157, 14);
            this.txt_dc.Multiline = true;
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(888, 25);
            this.txt_dc.TabIndex = 1;
            this.txt_dc.Text = "Http://";
            // 
            // bt_go
            // 
            this.bt_go.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_go.ForeColor = System.Drawing.Color.Transparent;
            this.bt_go.Location = new System.Drawing.Point(1071, 9);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(101, 30);
            this.bt_go.TabIndex = 2;
            this.bt_go.Text = "Go";
            this.bt_go.UseVisualStyleBackColor = false;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_1.ForeColor = System.Drawing.Color.Transparent;
            this.bt_1.Location = new System.Drawing.Point(5, 11);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(40, 30);
            this.bt_1.TabIndex = 3;
            this.bt_1.Text = "<";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_2.ForeColor = System.Drawing.Color.Transparent;
            this.bt_2.Location = new System.Drawing.Point(54, 11);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(40, 30);
            this.bt_2.TabIndex = 4;
            this.bt_2.Text = ">";
            this.bt_2.UseVisualStyleBackColor = false;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_3.ForeColor = System.Drawing.Color.Transparent;
            this.bt_3.Location = new System.Drawing.Point(103, 12);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(40, 30);
            this.bt_3.TabIndex = 5;
            this.bt_3.Text = "<>";
            this.bt_3.UseVisualStyleBackColor = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // Thongtin
            // 
            this.AcceptButton = this.bt_go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_go);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.webBrowser1);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Thongtin";
            this.Text = "Thongtin";
            this.Load += new System.EventHandler(this.Thongtin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bt_go;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.TextBox txt_dc;
    }
}