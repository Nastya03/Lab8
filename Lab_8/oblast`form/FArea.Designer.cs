namespace oblast_form
{
    partial class FArea
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbPop = new System.Windows.Forms.TextBox();
            this.tbCenter = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chAir = new System.Windows.Forms.CheckBox();
            this.chPort = new System.Windows.Forms.CheckBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSquare);
            this.groupBox1.Controls.Add(this.tbHeight);
            this.groupBox1.Controls.Add(this.tbPop);
            this.groupBox1.Controls.Add(this.tbCenter);
            this.groupBox1.Controls.Add(this.tbCountry);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbSquare
            // 
            this.tbSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSquare.Location = new System.Drawing.Point(136, 294);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(179, 24);
            this.tbSquare.TabIndex = 11;
            this.tbSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSquare_KeyPress);
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbHeight.Location = new System.Drawing.Point(136, 244);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(179, 24);
            this.tbHeight.TabIndex = 10;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            // 
            // tbPop
            // 
            this.tbPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbPop.Location = new System.Drawing.Point(136, 189);
            this.tbPop.Name = "tbPop";
            this.tbPop.Size = new System.Drawing.Size(179, 24);
            this.tbPop.TabIndex = 9;
            this.tbPop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPop_KeyPress);
            // 
            // tbCenter
            // 
            this.tbCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbCenter.Location = new System.Drawing.Point(136, 137);
            this.tbCenter.Name = "tbCenter";
            this.tbCenter.Size = new System.Drawing.Size(179, 24);
            this.tbCenter.TabIndex = 8;
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbCountry.Location = new System.Drawing.Point(136, 83);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(179, 24);
            this.tbCountry.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbName.Location = new System.Drawing.Point(136, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 24);
            this.tbName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(5, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Площа(кв.км):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(5, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Найвища точка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(5, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Населення(тис.):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(5, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адмін. центр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Країна:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва області:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chAir);
            this.groupBox2.Controls.Add(this.chPort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Транспорт";
            // 
            // chAir
            // 
            this.chAir.AutoSize = true;
            this.chAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chAir.Location = new System.Drawing.Point(24, 84);
            this.chAir.Name = "chAir";
            this.chAir.Size = new System.Drawing.Size(188, 22);
            this.chAir.TabIndex = 1;
            this.chAir.Text = "Область має аеропорт";
            this.chAir.UseVisualStyleBackColor = true;
            // 
            // chPort
            // 
            this.chPort.AutoSize = true;
            this.chPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chPort.Location = new System.Drawing.Point(24, 39);
            this.chPort.Name = "chPort";
            this.chPort.Size = new System.Drawing.Size(155, 22);
            this.chPort.TabIndex = 0;
            this.chPort.Text = "Область має порт";
            this.chPort.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bAdd.Location = new System.Drawing.Point(343, 28);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(133, 56);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Додати область";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bCancel.Location = new System.Drawing.Point(342, 98);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(133, 56);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Скасувати";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // FArea
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(488, 525);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FArea";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про область";
            this.Load += new System.EventHandler(this.fArea_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbPop;
        private System.Windows.Forms.TextBox tbCenter;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chAir;
        private System.Windows.Forms.CheckBox chPort;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
    }
}