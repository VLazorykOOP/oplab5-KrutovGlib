namespace Lab_5
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
            txtX1 = new TextBox();
            txtY1 = new TextBox();
            txtX2 = new TextBox();
            txtY2 = new TextBox();
            txtVy1 = new TextBox();
            txtVx1 = new TextBox();
            txtVy2 = new TextBox();
            txtVx2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtX1
            // 
            txtX1.Location = new Point(130, 29);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(92, 27);
            txtX1.TabIndex = 0;
            // 
            // txtY1
            // 
            txtY1.Location = new Point(228, 29);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(92, 27);
            txtY1.TabIndex = 1;
            // 
            // txtX2
            // 
            txtX2.Location = new Point(130, 73);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(92, 27);
            txtX2.TabIndex = 3;
            // 
            // txtY2
            // 
            txtY2.Location = new Point(228, 73);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(92, 27);
            txtY2.TabIndex = 2;
            // 
            // txtVy1
            // 
            txtVy1.Location = new Point(228, 122);
            txtVy1.Name = "txtVy1";
            txtVy1.Size = new Size(92, 27);
            txtVy1.TabIndex = 5;
            // 
            // txtVx1
            // 
            txtVx1.Location = new Point(130, 122);
            txtVx1.Name = "txtVx1";
            txtVx1.Size = new Size(92, 27);
            txtVx1.TabIndex = 4;
            txtVx1.Text = "                ";
            // 
            // txtVy2
            // 
            txtVy2.Location = new Point(228, 167);
            txtVy2.Name = "txtVy2";
            txtVy2.Size = new Size(92, 27);
            txtVy2.TabIndex = 7;
            // 
            // txtVx2
            // 
            txtVx2.Location = new Point(130, 167);
            txtVx2.Name = "txtVx2";
            txtVx2.Size = new Size(92, 27);
            txtVx2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 8;
            label1.Text = "P1 (X1, Y1)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 9;
            label2.Text = "P2 (X2, Y2)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 122);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 10;
            label3.Text = "V1 (Vx1, Vy1)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 167);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 11;
            label4.Text = "V2 (Vx2, Vy2)";
            // 
            // panel1
            // 
            panel1.Location = new Point(354, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 604);
            panel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(128, 239);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(128, 566);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Task 2.1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 628);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtVy2);
            Controls.Add(txtVx2);
            Controls.Add(txtVy1);
            Controls.Add(txtVx1);
            Controls.Add(txtX2);
            Controls.Add(txtY2);
            Controls.Add(txtY1);
            Controls.Add(txtX1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtX1;
        private TextBox txtY1;
        private TextBox txtX2;
        private TextBox txtY2;
        private TextBox txtVy1;
        private TextBox txtVx1;
        private TextBox txtVy2;
        private TextBox txtVx2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button button1;
        private Button button2;
    }
}
