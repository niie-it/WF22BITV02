﻿namespace DemoMdi
{
    partial class FrmChild
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.1F);
            label1.Location = new Point(329, 21);
            label1.Name = "label1";
            label1.Size = new Size(149, 57);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.1F);
            label2.Location = new Point(89, 107);
            label2.Name = "label2";
            label2.Size = new Size(149, 57);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.1F);
            label3.Location = new Point(104, 200);
            label3.Name = "label3";
            label3.Size = new Size(149, 57);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 14.1F);
            textBox1.Location = new Point(285, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 64);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 14.1F);
            textBox2.Location = new Point(285, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 64);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 14.1F);
            button1.Location = new Point(269, 294);
            button1.Name = "button1";
            button1.Size = new Size(266, 131);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmChild
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmChild";
            Text = "FrmChild";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}