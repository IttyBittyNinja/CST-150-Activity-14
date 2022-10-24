namespace _ABRAMS__CST_150_Activity_14
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
            this.employee1Radio = new System.Windows.Forms.RadioButton();
            this.employee2Radio = new System.Windows.Forms.RadioButton();
            this.generateBtn = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.nameChk = new System.Windows.Forms.CheckBox();
            this.doeChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // employee1Radio
            // 
            this.employee1Radio.AutoSize = true;
            this.employee1Radio.Location = new System.Drawing.Point(12, 12);
            this.employee1Radio.Name = "employee1Radio";
            this.employee1Radio.Size = new System.Drawing.Size(86, 19);
            this.employee1Radio.TabIndex = 0;
            this.employee1Radio.TabStop = true;
            this.employee1Radio.Text = "Employee 1";
            this.employee1Radio.UseVisualStyleBackColor = true;
            // 
            // employee2Radio
            // 
            this.employee2Radio.AutoSize = true;
            this.employee2Radio.Location = new System.Drawing.Point(12, 37);
            this.employee2Radio.Name = "employee2Radio";
            this.employee2Radio.Size = new System.Drawing.Size(86, 19);
            this.employee2Radio.TabIndex = 1;
            this.employee2Radio.TabStop = true;
            this.employee2Radio.Text = "Employee 2";
            this.employee2Radio.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(12, 113);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.ItemHeight = 15;
            this.outputBox.Location = new System.Drawing.Point(153, 12);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(142, 124);
            this.outputBox.TabIndex = 3;
            // 
            // nameChk
            // 
            this.nameChk.AutoSize = true;
            this.nameChk.Location = new System.Drawing.Point(12, 62);
            this.nameChk.Name = "nameChk";
            this.nameChk.Size = new System.Drawing.Size(58, 19);
            this.nameChk.TabIndex = 4;
            this.nameChk.Text = "Name";
            this.nameChk.UseVisualStyleBackColor = true;
            // 
            // doeChk
            // 
            this.doeChk.AutoSize = true;
            this.doeChk.Location = new System.Drawing.Point(12, 87);
            this.doeChk.Name = "doeChk";
            this.doeChk.Size = new System.Drawing.Size(135, 19);
            this.doeChk.TabIndex = 5;
            this.doeChk.Text = "Date of Employment";
            this.doeChk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(311, 150);
            this.Controls.Add(this.doeChk);
            this.Controls.Add(this.nameChk);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.employee2Radio);
            this.Controls.Add(this.employee1Radio);
            this.Name = "Form1";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton employee1Radio;
        private RadioButton employee2Radio;
        private Button generateBtn;
        private ListBox outputBox;
        private CheckBox nameChk;
        private CheckBox doeChk;
    }
}