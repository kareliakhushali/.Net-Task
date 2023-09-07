
namespace GUITask
{
    partial class UserForm
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.nupnum1 = new System.Windows.Forms.NumericUpDown();
            this.nupnum2 = new System.Windows.Forms.NumericUpDown();
            this.lblsingle = new System.Windows.Forms.Label();
            this.cmbSingle = new System.Windows.Forms.ComboBox();
            this.lblDouble = new System.Windows.Forms.Label();
            this.cmbDouble = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupnum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupnum2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(118, 81);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(105, 25);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Number 1";
            this.lblNum1.Click += new System.EventHandler(this.lblNum1_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(118, 124);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(105, 25);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Number 2";
            // 
            // nupnum1
            // 
            this.nupnum1.Location = new System.Drawing.Point(242, 81);
            this.nupnum1.Name = "nupnum1";
            this.nupnum1.Size = new System.Drawing.Size(227, 26);
            this.nupnum1.TabIndex = 2;
            // 
            // nupnum2
            // 
            this.nupnum2.Location = new System.Drawing.Point(242, 126);
            this.nupnum2.Name = "nupnum2";
            this.nupnum2.Size = new System.Drawing.Size(227, 26);
            this.nupnum2.TabIndex = 3;
            // 
            // lblsingle
            // 
            this.lblsingle.AutoSize = true;
            this.lblsingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsingle.Location = new System.Drawing.Point(132, 169);
            this.lblsingle.Name = "lblsingle";
            this.lblsingle.Size = new System.Drawing.Size(73, 25);
            this.lblsingle.TabIndex = 4;
            this.lblsingle.Text = "Single";
            // 
            // cmbSingle
            // 
            this.cmbSingle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSingle.FormattingEnabled = true;
            this.cmbSingle.Items.AddRange(new object[] {
            "Prime",
            "Armstrong",
            "Palindrome"});
            this.cmbSingle.Location = new System.Drawing.Point(242, 170);
            this.cmbSingle.Name = "cmbSingle";
            this.cmbSingle.Size = new System.Drawing.Size(227, 28);
            this.cmbSingle.TabIndex = 5;
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDouble.Location = new System.Drawing.Point(132, 218);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(80, 25);
            this.lblDouble.TabIndex = 6;
            this.lblDouble.Text = "Double";
            // 
            // cmbDouble
            // 
            this.cmbDouble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDouble.FormattingEnabled = true;
            this.cmbDouble.Items.AddRange(new object[] {
            "Maximum",
            "Minimum",
            "Equal",
            "Power",
            ""});
            this.cmbDouble.Location = new System.Drawing.Point(242, 219);
            this.cmbDouble.Name = "cmbDouble";
            this.cmbDouble.Size = new System.Drawing.Size(227, 28);
            this.cmbDouble.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Location = new System.Drawing.Point(268, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(162, 53);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput1.Location = new System.Drawing.Point(586, 87);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(0, 20);
            this.lblOutput1.TabIndex = 9;
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(589, 222);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(0, 20);
            this.lblOutput2.TabIndex = 10;
            // 
            // UserForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbDouble);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.cmbSingle);
            this.Controls.Add(this.lblsingle);
            this.Controls.Add(this.nupnum2);
            this.Controls.Add(this.nupnum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "UserForm";
            this.Text = "UserInputTask";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupnum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupnum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.NumericUpDown nupnum1;
        private System.Windows.Forms.NumericUpDown nupnum2;
        private System.Windows.Forms.Label lblsingle;
        private System.Windows.Forms.ComboBox cmbSingle;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.ComboBox cmbDouble;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblOutput2;
    }
}

