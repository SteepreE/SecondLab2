namespace SecondLab2
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
            this.DepositInput = new System.Windows.Forms.TextBox();
            this.PercentInput = new System.Windows.Forms.TextBox();
            this.DepositLabel = new System.Windows.Forms.Label();
            this.PrecentLabel = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.DepositLimitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IncrementLimitInput = new System.Windows.Forms.TextBox();
            this.DepLimitInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DepositInput
            // 
            this.DepositInput.Location = new System.Drawing.Point(12, 29);
            this.DepositInput.Name = "DepositInput";
            this.DepositInput.Size = new System.Drawing.Size(111, 20);
            this.DepositInput.TabIndex = 0;
            // 
            // PercentInput
            // 
            this.PercentInput.Location = new System.Drawing.Point(12, 96);
            this.PercentInput.Name = "PercentInput";
            this.PercentInput.Size = new System.Drawing.Size(111, 20);
            this.PercentInput.TabIndex = 1;
            // 
            // DepositLabel
            // 
            this.DepositLabel.AutoSize = true;
            this.DepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DepositLabel.Location = new System.Drawing.Point(12, 9);
            this.DepositLabel.Name = "DepositLabel";
            this.DepositLabel.Size = new System.Drawing.Size(111, 17);
            this.DepositLabel.TabIndex = 2;
            this.DepositLabel.Text = "Размер вклада:";
            // 
            // PrecentLabel
            // 
            this.PrecentLabel.AutoSize = true;
            this.PrecentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PrecentLabel.Location = new System.Drawing.Point(12, 76);
            this.PrecentLabel.Name = "PrecentLabel";
            this.PrecentLabel.Size = new System.Drawing.Size(123, 17);
            this.PrecentLabel.TabIndex = 3;
            this.PrecentLabel.Text = "Процент вклада: ";
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(413, 34);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(128, 87);
            this.ResultButton.TabIndex = 4;
            this.ResultButton.Text = "Рассчитать";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MainLabel.Location = new System.Drawing.Point(278, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(149, 17);
            this.MainLabel.TabIndex = 5;
            this.MainLabel.Text = "Граничные значения";
            // 
            // DepositLimitLabel
            // 
            this.DepositLimitLabel.AutoSize = true;
            this.DepositLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DepositLimitLabel.Location = new System.Drawing.Point(210, 34);
            this.DepositLimitLabel.Name = "DepositLimitLabel";
            this.DepositLimitLabel.Size = new System.Drawing.Size(119, 17);
            this.DepositLimitLabel.TabIndex = 6;
            this.DepositLimitLabel.Text = "Размера вклада:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(210, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eжемесячного увеличения:";
            // 
            // IncrementLimitInput
            // 
            this.IncrementLimitInput.Location = new System.Drawing.Point(213, 96);
            this.IncrementLimitInput.Name = "IncrementLimitInput";
            this.IncrementLimitInput.Size = new System.Drawing.Size(159, 20);
            this.IncrementLimitInput.TabIndex = 8;
            // 
            // DepLimitInput
            // 
            this.DepLimitInput.Location = new System.Drawing.Point(213, 54);
            this.DepLimitInput.Name = "DepLimitInput";
            this.DepLimitInput.Size = new System.Drawing.Size(159, 20);
            this.DepLimitInput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 152);
            this.Controls.Add(this.DepLimitInput);
            this.Controls.Add(this.IncrementLimitInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepositLimitLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.PrecentLabel);
            this.Controls.Add(this.DepositLabel);
            this.Controls.Add(this.PercentInput);
            this.Controls.Add(this.DepositInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DepositInput;
        private System.Windows.Forms.TextBox PercentInput;
        private System.Windows.Forms.Label DepositLabel;
        private System.Windows.Forms.Label PrecentLabel;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label DepositLimitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IncrementLimitInput;
        private System.Windows.Forms.TextBox DepLimitInput;
    }
}

