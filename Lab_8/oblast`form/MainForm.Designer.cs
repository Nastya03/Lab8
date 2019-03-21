namespace oblast_form
{
    partial class fMain
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
            this.bAddA = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tMain = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAddA
            // 
            this.bAddA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bAddA.Location = new System.Drawing.Point(21, 357);
            this.bAddA.Name = "bAddA";
            this.bAddA.Size = new System.Drawing.Size(185, 64);
            this.bAddA.TabIndex = 1;
            this.bAddA.Text = "Додати область";
            this.bAddA.UseVisualStyleBackColor = true;
            this.bAddA.Click += new System.EventHandler(this.bAddA_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bExit.Location = new System.Drawing.Point(384, 357);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(185, 64);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Вихід";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tMain
            // 
            this.tMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tMain.FormattingEnabled = true;
            this.tMain.ItemHeight = 20;
            this.tMain.Location = new System.Drawing.Point(21, 20);
            this.tMain.Name = "tMain";
            this.tMain.Size = new System.Drawing.Size(548, 304);
            this.tMain.TabIndex = 4;
            this.tMain.SelectedIndexChanged += new System.EventHandler(this.tMain_SelectedIndexChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.tMain);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bAddA);
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабараторна робота №8";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bAddA;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ListBox tMain;
    }
}

