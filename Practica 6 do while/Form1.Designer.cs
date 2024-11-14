namespace Practica_6_do_while
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            BtnVerifica = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 21);
            label1.Name = "label1";
            label1.Size = new Size(337, 30);
            label1.TabIndex = 0;
            label1.Text = "Verificar si un número es par ó impar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 101);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 1;
            label2.Text = "Escribe un número";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(413, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 28);
            textBox1.TabIndex = 2;
            // 
            // BtnVerifica
            // 
            BtnVerifica.BackColor = Color.FromArgb(255, 128, 0);
            BtnVerifica.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVerifica.Location = new Point(412, 158);
            BtnVerifica.Name = "BtnVerifica";
            BtnVerifica.Size = new Size(103, 37);
            BtnVerifica.TabIndex = 3;
            BtnVerifica.Text = "Verificar";
            BtnVerifica.UseVisualStyleBackColor = false;
            BtnVerifica.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(604, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(146, 280);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(BtnVerifica);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Par o impar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button BtnVerifica;
        private ListBox listBox1;
    }
}
