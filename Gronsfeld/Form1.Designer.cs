namespace Gronsfeld
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Coder = new System.Windows.Forms.TextBox();
            this.StartCoder = new System.Windows.Forms.Button();
            this.Encoder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Coder
            // 
            this.Coder.Location = new System.Drawing.Point(161, 102);
            this.Coder.Name = "Coder";
            this.Coder.Size = new System.Drawing.Size(232, 20);
            this.Coder.TabIndex = 0;
            this.Coder.TextChanged += new System.EventHandler(this.Coder_TextChanged);
            // 
            // StartCoder
            // 
            this.StartCoder.Location = new System.Drawing.Point(161, 133);
            this.StartCoder.Name = "StartCoder";
            this.StartCoder.Size = new System.Drawing.Size(232, 32);
            this.StartCoder.TabIndex = 1;
            this.StartCoder.Text = "Закодировать";
            this.StartCoder.UseVisualStyleBackColor = true;
            this.StartCoder.Click += new System.EventHandler(this.StartCoder_Click);
            // 
            // Encoder
            // 
            this.Encoder.Location = new System.Drawing.Point(161, 196);
            this.Encoder.Name = "Encoder";
            this.Encoder.Size = new System.Drawing.Size(232, 20);
            this.Encoder.TabIndex = 2;
            this.Encoder.TextChanged += new System.EventHandler(this.Encoder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите текст:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шифр:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Encoder);
            this.Controls.Add(this.StartCoder);
            this.Controls.Add(this.Coder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Coder;
        private System.Windows.Forms.Button StartCoder;
        private System.Windows.Forms.TextBox Encoder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

