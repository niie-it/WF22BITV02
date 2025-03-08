namespace MyControlLibrary
{
    partial class UserControl1
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
            components = new System.ComponentModel.Container();
            lblDongHo = new Label();
            btnStartStop = new Button();
            btnLAP = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDongHo
            // 
            lblDongHo.AutoSize = true;
            lblDongHo.Font = new Font("Tahoma", 25.9000015F);
            lblDongHo.ForeColor = Color.Blue;
            lblDongHo.Location = new Point(98, 18);
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Size = new Size(557, 105);
            lblDongHo.TabIndex = 0;
            lblDongHo.Text = "00:00:00 000";
            // 
            // btnStartStop
            // 
            btnStartStop.Font = new Font("Tahoma", 15.9000006F);
            btnStartStop.Location = new Point(39, 146);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(294, 103);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "START";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnLAP
            // 
            btnLAP.Enabled = false;
            btnLAP.Font = new Font("Tahoma", 15.9000006F);
            btnLAP.Location = new Point(413, 146);
            btnLAP.Name = "btnLAP";
            btnLAP.Size = new Size(294, 103);
            btnLAP.TabIndex = 1;
            btnLAP.Text = "LAP";
            btnLAP.UseVisualStyleBackColor = true;
            btnLAP.Click += btnLAP_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLAP);
            Controls.Add(btnStartStop);
            Controls.Add(lblDongHo);
            Name = "UserControl1";
            Size = new Size(800, 294);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDongHo;
        private Button btnStartStop;
        private Button btnLAP;
        private System.Windows.Forms.Timer timer1;
    }
}
