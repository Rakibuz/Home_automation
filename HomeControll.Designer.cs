namespace Final
{
    partial class HomeControll
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
            this.btn_led1_on = new System.Windows.Forms.Button();
            this.btn_led1_off = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_fan_on = new System.Windows.Forms.Button();
            this.btn_fan_off = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_led1_on
            // 
            this.btn_led1_on.Location = new System.Drawing.Point(38, 58);
            this.btn_led1_on.Name = "btn_led1_on";
            this.btn_led1_on.Size = new System.Drawing.Size(75, 23);
            this.btn_led1_on.TabIndex = 0;
            this.btn_led1_on.Text = "ON";
            this.btn_led1_on.UseVisualStyleBackColor = true;
            this.btn_led1_on.Click += new System.EventHandler(this.btn_led1_on_Click);
            // 
            // btn_led1_off
            // 
            this.btn_led1_off.Location = new System.Drawing.Point(38, 130);
            this.btn_led1_off.Name = "btn_led1_off";
            this.btn_led1_off.Size = new System.Drawing.Size(75, 23);
            this.btn_led1_off.TabIndex = 1;
            this.btn_led1_off.Text = "OFF";
            this.btn_led1_off.UseVisualStyleBackColor = true;
            this.btn_led1_off.Click += new System.EventHandler(this.btn_led1_off_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lights";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 292);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 11);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_fan_on
            // 
            this.btn_fan_on.Location = new System.Drawing.Point(217, 57);
            this.btn_fan_on.Name = "btn_fan_on";
            this.btn_fan_on.Size = new System.Drawing.Size(75, 23);
            this.btn_fan_on.TabIndex = 4;
            this.btn_fan_on.Text = "ON";
            this.btn_fan_on.UseVisualStyleBackColor = true;
            this.btn_fan_on.Click += new System.EventHandler(this.btn_fan_on_Click);
            // 
            // btn_fan_off
            // 
            this.btn_fan_off.Location = new System.Drawing.Point(217, 129);
            this.btn_fan_off.Name = "btn_fan_off";
            this.btn_fan_off.Size = new System.Drawing.Size(75, 24);
            this.btn_fan_off.TabIndex = 5;
            this.btn_fan_off.Text = "OFF";
            this.btn_fan_off.UseVisualStyleBackColor = true;
            this.btn_fan_off.Click += new System.EventHandler(this.btn_fan_off_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fan";
            // 
            // HomeControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fan_off);
            this.Controls.Add(this.btn_fan_on);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_led1_off);
            this.Controls.Add(this.btn_led1_on);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeControll";
            this.Text = "HomeControll";
            this.Load += new System.EventHandler(this.HomeControll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_led1_on;
        private System.Windows.Forms.Button btn_led1_off;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_fan_on;
        private System.Windows.Forms.Button btn_fan_off;
        private System.Windows.Forms.Label label2;
    }
}