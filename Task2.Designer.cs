namespace Lab_5
{
    partial class Task2
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
            textBoxX1 = new TextBox();
            textBoxX2 = new TextBox();
            textBoxY2 = new TextBox();
            textBoxY1 = new TextBox();
            textBoxK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(38, 12);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(125, 27);
            textBoxX1.TabIndex = 0;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(38, 68);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(125, 27);
            textBoxX2.TabIndex = 1;
            // 
            // textBoxY2
            // 
            textBoxY2.Location = new Point(228, 68);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(125, 27);
            textBoxY2.TabIndex = 2;
            // 
            // textBoxY1
            // 
            textBoxY1.Location = new Point(228, 12);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.Size = new Size(125, 27);
            textBoxY1.TabIndex = 3;
            // 
            // textBoxK
            // 
            textBoxK.Location = new Point(429, 40);
            textBoxK.Name = "textBoxK";
            textBoxK.Size = new Size(125, 27);
            textBoxK.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 5;
            label1.Text = "X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 43);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 6;
            label2.Text = "K";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 71);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 7;
            label3.Text = "Y2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 15);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 8;
            label4.Text = "Y1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 9;
            label5.Text = "X2";
            // 
            // button1
            // 
            button1.Location = new Point(596, 38);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 458);
            panel1.TabIndex = 11;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 646);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxK);
            Controls.Add(textBoxY1);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxX1);
            Name = "Task2";
            Text = "Task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX1;
        private TextBox textBoxX2;
        private TextBox textBoxY2;
        private TextBox textBoxY1;
        private TextBox textBoxK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Panel panel1;
    }
}