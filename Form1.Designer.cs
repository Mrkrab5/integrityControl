namespace integrityControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.entryMassenge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.choseMethod = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сообщение для формирования";
            // 
            // entryMassenge
            // 
            this.entryMassenge.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryMassenge.Location = new System.Drawing.Point(12, 48);
            this.entryMassenge.Name = "entryMassenge";
            this.entryMassenge.Size = new System.Drawing.Size(776, 35);
            this.entryMassenge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(257, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор варианта проверки";
            // 
            // choseMethod
            // 
            this.choseMethod.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choseMethod.FormattingEnabled = true;
            this.choseMethod.Items.AddRange(new object[] {
            "Биты чётности",
            "IMEI-коды",
            "контрольные суммы(CRC)"});
            this.choseMethod.Location = new System.Drawing.Point(225, 154);
            this.choseMethod.Name = "choseMethod";
            this.choseMethod.Size = new System.Drawing.Size(334, 35);
            this.choseMethod.TabIndex = 3;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(12, 204);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(776, 158);
            this.result.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(333, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.choseMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entryMassenge);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entryMassenge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox choseMethod;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
    }
}

