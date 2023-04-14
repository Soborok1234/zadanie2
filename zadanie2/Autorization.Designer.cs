namespace zadanie2
{
    partial class Autorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_autor_textBox1 = new System.Windows.Forms.TextBox();
            this.pass_autor_textBox2 = new System.Windows.Forms.TextBox();
            this.enter_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // log_autor_textBox1
            // 
            this.log_autor_textBox1.Location = new System.Drawing.Point(10, 35);
            this.log_autor_textBox1.Name = "log_autor_textBox1";
            this.log_autor_textBox1.Size = new System.Drawing.Size(186, 20);
            this.log_autor_textBox1.TabIndex = 2;
            this.log_autor_textBox1.TextChanged += new System.EventHandler(this.log_autor_textBox1_TextChanged);
            // 
            // pass_autor_textBox2
            // 
            this.pass_autor_textBox2.Location = new System.Drawing.Point(10, 103);
            this.pass_autor_textBox2.Name = "pass_autor_textBox2";
            this.pass_autor_textBox2.PasswordChar = '*';
            this.pass_autor_textBox2.Size = new System.Drawing.Size(186, 20);
            this.pass_autor_textBox2.TabIndex = 3;
            this.pass_autor_textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // enter_button1
            // 
            this.enter_button1.Location = new System.Drawing.Point(10, 129);
            this.enter_button1.Name = "enter_button1";
            this.enter_button1.Size = new System.Drawing.Size(186, 27);
            this.enter_button1.TabIndex = 4;
            this.enter_button1.Text = "Войти";
            this.enter_button1.UseVisualStyleBackColor = true;
            this.enter_button1.Click += new System.EventHandler(this.enter_button1_Click);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 168);
            this.Controls.Add(this.enter_button1);
            this.Controls.Add(this.pass_autor_textBox2);
            this.Controls.Add(this.log_autor_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Autorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_autor_textBox2;
        private System.Windows.Forms.Button enter_button1;
        public System.Windows.Forms.TextBox log_autor_textBox1;
    }
}