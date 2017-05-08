namespace Qlks
{
    partial class HuongDan
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
            this.components = new System.ComponentModel.Container();
            this.lb_ch = new System.Windows.Forms.Label();
            this.bt_sai = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.lb_cd = new System.Windows.Forms.Label();
            this.bt_choi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_m = new System.Windows.Forms.Label();
            this.bt_dung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tg = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_ch
            // 
            this.lb_ch.AutoSize = true;
            this.lb_ch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ch.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_ch.Location = new System.Drawing.Point(13, 109);
            this.lb_ch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ch.Name = "lb_ch";
            this.lb_ch.Size = new System.Drawing.Size(80, 25);
            this.lb_ch.TabIndex = 0;
            this.lb_ch.Text = "Cau hoi";
            // 
            // bt_sai
            // 
            this.bt_sai.Image = global::Qlks.Properties.Resources.x;
            this.bt_sai.Location = new System.Drawing.Point(176, 166);
            this.bt_sai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_sai.MaximumSize = new System.Drawing.Size(100, 100);
            this.bt_sai.MinimumSize = new System.Drawing.Size(100, 100);
            this.bt_sai.Name = "bt_sai";
            this.bt_sai.Size = new System.Drawing.Size(100, 100);
            this.bt_sai.TabIndex = 2;
            this.bt_sai.Text = "sai";
            this.bt_sai.UseVisualStyleBackColor = true;
            this.bt_sai.Click += new System.EventHandler(this.bt_sai_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb.Location = new System.Drawing.Point(13, 289);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(109, 17);
            this.lb.TabIndex = 3;
            this.lb.Text = "Số câu đúng: ";
            // 
            // lb_cd
            // 
            this.lb_cd.AutoSize = true;
            this.lb_cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_cd.Location = new System.Drawing.Point(174, 289);
            this.lb_cd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cd.Name = "lb_cd";
            this.lb_cd.Size = new System.Drawing.Size(17, 17);
            this.lb_cd.TabIndex = 4;
            this.lb_cd.Text = "0";
            // 
            // bt_choi
            // 
            this.bt_choi.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_choi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_choi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_choi.Location = new System.Drawing.Point(199, 52);
            this.bt_choi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_choi.Name = "bt_choi";
            this.bt_choi.Size = new System.Drawing.Size(77, 37);
            this.bt_choi.TabIndex = 5;
            this.bt_choi.Text = "Chơi";
            this.bt_choi.UseVisualStyleBackColor = false;
            this.bt_choi.Click += new System.EventHandler(this.bt_choi_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_m
            // 
            this.lb_m.AutoSize = true;
            this.lb_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_m.ForeColor = System.Drawing.Color.Red;
            this.lb_m.Location = new System.Drawing.Point(15, 52);
            this.lb_m.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_m.Name = "lb_m";
            this.lb_m.Size = new System.Drawing.Size(66, 17);
            this.lb_m.TabIndex = 6;
            this.lb_m.Text = "Mang: 3";
            // 
            // bt_dung
            // 
            this.bt_dung.Image = global::Qlks.Properties.Resources.tich;
            this.bt_dung.Location = new System.Drawing.Point(15, 166);
            this.bt_dung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_dung.MaximumSize = new System.Drawing.Size(100, 100);
            this.bt_dung.MinimumSize = new System.Drawing.Size(100, 100);
            this.bt_dung.Name = "bt_dung";
            this.bt_dung.Size = new System.Drawing.Size(100, 100);
            this.bt_dung.TabIndex = 1;
            this.bt_dung.Text = "đúng";
            this.bt_dung.UseVisualStyleBackColor = true;
            this.bt_dung.Click += new System.EventHandler(this.bt_dung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Vui";
            // 
            // lb_tg
            // 
            this.lb_tg.AutoSize = true;
            this.lb_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tg.ForeColor = System.Drawing.Color.Red;
            this.lb_tg.Location = new System.Drawing.Point(56, 81);
            this.lb_tg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tg.Name = "lb_tg";
            this.lb_tg.Size = new System.Drawing.Size(95, 17);
            this.lb_tg.TabIndex = 8;
            this.lb_tg.Text = "Thời gian: 3";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // HuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 322);
            this.Controls.Add(this.lb_tg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_m);
            this.Controls.Add(this.bt_choi);
            this.Controls.Add(this.lb_cd);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.bt_sai);
            this.Controls.Add(this.bt_dung);
            this.Controls.Add(this.lb_ch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HuongDan";
            this.Text = "HuongDan";
            this.Load += new System.EventHandler(this.HuongDan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ch;
        private System.Windows.Forms.Button bt_dung;
        private System.Windows.Forms.Button bt_sai;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb_cd;
        private System.Windows.Forms.Button bt_choi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_m;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tg;
        private System.Windows.Forms.Timer timer2;
    }
}