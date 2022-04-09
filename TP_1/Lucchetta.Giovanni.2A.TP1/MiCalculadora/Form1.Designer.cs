
namespace MiCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConvBinary = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonConvDecimal = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 32.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(380, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 65);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExecute.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExecute.ForeColor = System.Drawing.Color.White;
            this.buttonExecute.Location = new System.Drawing.Point(42, 239);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(159, 51);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "Operar";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonClear.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(226, 239);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 51);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonClose.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(396, 239);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(159, 51);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonConvBinary
            // 
            this.buttonConvBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonConvBinary.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConvBinary.ForeColor = System.Drawing.Color.White;
            this.buttonConvBinary.Location = new System.Drawing.Point(42, 312);
            this.buttonConvBinary.Name = "buttonConvBinary";
            this.buttonConvBinary.Size = new System.Drawing.Size(241, 53);
            this.buttonConvBinary.TabIndex = 5;
            this.buttonConvBinary.Text = "Convertir a Binario";
            this.buttonConvBinary.UseVisualStyleBackColor = false;
            this.buttonConvBinary.Click += new System.EventHandler(this.buttonConvBinary_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 32.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(42, 86);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 65);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 32.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 59;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBox1.Location = new System.Drawing.Point(246, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 67);
            this.comboBox1.TabIndex = 7;
            // 
            // buttonConvDecimal
            // 
            this.buttonConvDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonConvDecimal.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConvDecimal.ForeColor = System.Drawing.Color.White;
            this.buttonConvDecimal.Location = new System.Drawing.Point(314, 312);
            this.buttonConvDecimal.Name = "buttonConvDecimal";
            this.buttonConvDecimal.Size = new System.Drawing.Size(241, 53);
            this.buttonConvDecimal.TabIndex = 8;
            this.buttonConvDecimal.Text = "Convertir a Decimal";
            this.buttonConvDecimal.UseVisualStyleBackColor = false;
            this.buttonConvDecimal.Click += new System.EventHandler(this.buttonConvDecimal_Click);
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.x.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x.ForeColor = System.Drawing.Color.White;
            this.x.FormattingEnabled = true;
            this.x.ItemHeight = 28;
            this.x.Location = new System.Drawing.Point(578, 53);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(205, 312);
            this.x.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(503, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 57);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(795, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x);
            this.Controls.Add(this.buttonConvDecimal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonConvBinary);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Giovanni Lucchetta del curso 2°A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConvBinary;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonConvDecimal;
        private System.Windows.Forms.ListBox x;
        private System.Windows.Forms.Label label1;
    }
}

