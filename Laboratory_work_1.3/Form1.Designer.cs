namespace Laboratory_work_1._3
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
            this.bYesNoCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.bAbortRetryIgnore = new System.Windows.Forms.Button();
            this.bFileOpen = new System.Windows.Forms.Button();
            this.bCustomDialog = new System.Windows.Forms.Button();
            this.bWhichOption = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bYesNoCancel
            // 
            this.bYesNoCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bYesNoCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bYesNoCancel.Location = new System.Drawing.Point(72, 53);
            this.bYesNoCancel.Name = "bYesNoCancel";
            this.bYesNoCancel.Size = new System.Drawing.Size(201, 33);
            this.bYesNoCancel.TabIndex = 0;
            this.bYesNoCancel.Text = "Yes, No, Cancel";
            this.bYesNoCancel.UseVisualStyleBackColor = true;
            this.bYesNoCancel.Click += new System.EventHandler(this.bYesNoCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dialog Result";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(246, 294);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(248, 22);
            this.textResult.TabIndex = 2;
            // 
            // bAbortRetryIgnore
            // 
            this.bAbortRetryIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAbortRetryIgnore.Location = new System.Drawing.Point(370, 53);
            this.bAbortRetryIgnore.Name = "bAbortRetryIgnore";
            this.bAbortRetryIgnore.Size = new System.Drawing.Size(222, 40);
            this.bAbortRetryIgnore.TabIndex = 3;
            this.bAbortRetryIgnore.Text = "Abort, Retry, Ignore";
            this.bAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.bAbortRetryIgnore.Click += new System.EventHandler(this.bAbortRetryIgnore_Click);
            // 
            // bFileOpen
            // 
            this.bFileOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFileOpen.Location = new System.Drawing.Point(246, 126);
            this.bFileOpen.Name = "bFileOpen";
            this.bFileOpen.Size = new System.Drawing.Size(137, 40);
            this.bFileOpen.TabIndex = 4;
            this.bFileOpen.Text = "File Open";
            this.bFileOpen.UseVisualStyleBackColor = true;
            this.bFileOpen.Click += new System.EventHandler(this.bFileOpen_Click);
            // 
            // bCustomDialog
            // 
            this.bCustomDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCustomDialog.Location = new System.Drawing.Point(41, 197);
            this.bCustomDialog.Name = "bCustomDialog";
            this.bCustomDialog.Size = new System.Drawing.Size(167, 39);
            this.bCustomDialog.TabIndex = 5;
            this.bCustomDialog.Text = "Custom Dialog";
            this.bCustomDialog.UseVisualStyleBackColor = true;
            this.bCustomDialog.Click += new System.EventHandler(this.bCustomDialog_Click);
            // 
            // bWhichOption
            // 
            this.bWhichOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bWhichOption.Location = new System.Drawing.Point(384, 197);
            this.bWhichOption.Name = "bWhichOption";
            this.bWhichOption.Size = new System.Drawing.Size(166, 43);
            this.bWhichOption.TabIndex = 6;
            this.bWhichOption.Text = "Which Option";
            this.bWhichOption.UseVisualStyleBackColor = true;
            this.bWhichOption.Click += new System.EventHandler(this.bWhichOption_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(313, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bWhichOption);
            this.Controls.Add(this.bCustomDialog);
            this.Controls.Add(this.bFileOpen);
            this.Controls.Add(this.bAbortRetryIgnore);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bYesNoCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory_work_1.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bYesNoCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button bAbortRetryIgnore;
        private System.Windows.Forms.Button bFileOpen;
        private System.Windows.Forms.Button bCustomDialog;
        private System.Windows.Forms.Button bWhichOption;
        private System.Windows.Forms.Button button1;
    }
}

