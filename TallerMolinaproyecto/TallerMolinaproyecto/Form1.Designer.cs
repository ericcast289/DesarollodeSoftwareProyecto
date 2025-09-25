namespace TallerMolinaproyecto
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
            lbl = new Label();
            lab = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLab = new LinkLabel();
            linkLab1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(108, 256);
            lbl.Name = "lbl";
            lbl.Size = new Size(83, 28);
            lbl.TabIndex = 1;
            lbl.Text = "Usuario:";
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab.Location = new Point(98, 343);
            lab.Name = "lab";
            lab.Size = new Size(114, 28);
            lab.TabIndex = 2;
            lab.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 25);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 25);
            textBox2.TabIndex = 4;
            // 
            // linkLab
            // 
            linkLab.AutoSize = true;
            linkLab.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLab.Location = new Point(98, 421);
            linkLab.Name = "linkLab";
            linkLab.Size = new Size(153, 17);
            linkLab.TabIndex = 5;
            linkLab.TabStop = true;
            linkLab.Text = "Olvidaste tu Contraseña?";
            // 
            // linkLab1
            // 
            linkLab1.AutoSize = true;
            linkLab1.Location = new Point(98, 482);
            linkLab1.Name = "linkLab1";
            linkLab1.Size = new Size(84, 17);
            linkLab1.TabIndex = 6;
            linkLab1.TabStop = true;
            linkLab1.Text = "Crear Cuenta";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1073, 687);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1235, 686);
            button2.Name = "button2";
            button2.Size = new Size(94, 30);
            button2.TabIndex = 8;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 174);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(515, 20);
            label1.Name = "label1";
            label1.Size = new Size(345, 54);
            label1.TabIndex = 0;
            label1.Text = "Taller Molina";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_09_23_at_11_10_53_PM;
            pictureBox1.Location = new Point(1046, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 741);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLab1);
            Controls.Add(linkLab);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lab);
            Controls.Add(lbl);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl;
        private Label lab;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLab;
        private LinkLabel linkLab1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
