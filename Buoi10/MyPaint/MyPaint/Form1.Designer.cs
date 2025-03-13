namespace MyPaint
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            btnFillColor = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            nudBorderSize = new NumericUpDown();
            label3 = new Label();
            btnBorderColor = new Button();
            label2 = new Label();
            cboType = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBorderSize).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(cboType);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.MouseDown += splitContainer1_Panel2_MouseDown;
            splitContainer1.Panel2.MouseUp += splitContainer1_Panel2_MouseUp;
            splitContainer1.Size = new Size(1654, 1026);
            splitContainer1.SplitterDistance = 550;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFillColor);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Tahoma", 12F);
            groupBox2.Location = new Point(12, 525);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 182);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fill";
            // 
            // btnFillColor
            // 
            btnFillColor.BackColor = Color.Black;
            btnFillColor.FlatStyle = FlatStyle.Flat;
            btnFillColor.Location = new Point(166, 63);
            btnFillColor.Name = "btnFillColor";
            btnFillColor.Size = new Size(188, 58);
            btnFillColor.TabIndex = 1;
            btnFillColor.UseVisualStyleBackColor = false;
            btnFillColor.Click += btnFillColor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 72);
            label5.Name = "label5";
            label5.Size = new Size(111, 48);
            label5.TabIndex = 0;
            label5.Text = "Color";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudBorderSize);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnBorderColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tahoma", 12F);
            groupBox1.Location = new Point(12, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 270);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Border";
            // 
            // nudBorderSize
            // 
            nudBorderSize.Location = new Point(166, 174);
            nudBorderSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBorderSize.Name = "nudBorderSize";
            nudBorderSize.Size = new Size(188, 56);
            nudBorderSize.TabIndex = 3;
            nudBorderSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 180);
            label3.Name = "label3";
            label3.Size = new Size(90, 48);
            label3.TabIndex = 2;
            label3.Text = "Size";
            // 
            // btnBorderColor
            // 
            btnBorderColor.BackColor = Color.Black;
            btnBorderColor.FlatStyle = FlatStyle.Flat;
            btnBorderColor.Location = new Point(166, 63);
            btnBorderColor.Name = "btnBorderColor";
            btnBorderColor.Size = new Size(188, 58);
            btnBorderColor.TabIndex = 1;
            btnBorderColor.UseVisualStyleBackColor = false;
            btnBorderColor.Click += btnBorderColor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 72);
            label2.Name = "label2";
            label2.Size = new Size(111, 48);
            label2.TabIndex = 0;
            label2.Text = "Color";
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Font = new Font("Tahoma", 12F);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Draw Line", "Draw Rectangle", "Draw Eclipse", "Fill Rectangle", "Fill Eclipse" });
            cboType.Location = new Point(22, 106);
            cboType.Name = "cboType";
            cboType.Size = new Size(492, 56);
            cboType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(106, 48);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1654, 1026);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "MY PAINT";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBorderSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox cboType;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnFillColor;
        private Label label5;
        private GroupBox groupBox1;
        private NumericUpDown nudBorderSize;
        private Label label3;
        private Button btnBorderColor;
        private Label label2;
    }
}
