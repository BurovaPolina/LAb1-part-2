namespace LAb1_part_2
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
            this.valFirstTextBox = new LAb1_part_2.NumericTextBox();
            this.operTextBox = new LAb1_part_2.OperationTextBox();
            this.valSecondTextBox = new LAb1_part_2.NumericTextBox();
            this.labelResut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // valFirstTextBox
            // 
            this.valFirstTextBox.Location = new System.Drawing.Point(0, 18);
            this.valFirstTextBox.Name = "valFirstTextBox";
            this.valFirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.valFirstTextBox.TabIndex = 0;
            this.valFirstTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // operTextBox
            // 
            this.operTextBox.Location = new System.Drawing.Point(121, 18);
            this.operTextBox.Name = "operTextBox";
            this.operTextBox.Size = new System.Drawing.Size(100, 20);
            this.operTextBox.TabIndex = 1;
            this.operTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // valSecondTextBox
            // 
            this.valSecondTextBox.Location = new System.Drawing.Point(238, 18);
            this.valSecondTextBox.Name = "valSecondTextBox";
            this.valSecondTextBox.Size = new System.Drawing.Size(100, 20);
            this.valSecondTextBox.TabIndex = 2;
            this.valSecondTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelResut
            // 
            this.labelResut.AutoSize = true;
            this.labelResut.Location = new System.Drawing.Point(355, 25);
            this.labelResut.Name = "labelResut";
            this.labelResut.Size = new System.Drawing.Size(57, 13);
            this.labelResut.TabIndex = 3;
            this.labelResut.TabStop = true;
            this.labelResut.Text = "labelResut";
            this.labelResut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResut);
            this.Controls.Add(this.valSecondTextBox);
            this.Controls.Add(this.operTextBox);
            this.Controls.Add(this.valFirstTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel labelResut;
        private NumericTextBox valFirstTextBox;
        private OperationTextBox operTextBox;
        private NumericTextBox valSecondTextBox;
    }
}

