namespace Project_V1
{
    partial class Form_Report
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Montly = new System.Windows.Forms.Button();
            this.btn_Weekly = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_type);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Montly);
            this.groupBox1.Controls.Add(this.btn_Weekly);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Report:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 306);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(534, 212);
            this.listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 95);
            this.listBox1.TabIndex = 2;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(162, 86);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(14, 13);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output:";
            // 
            // btn_Montly
            // 
            this.btn_Montly.Location = new System.Drawing.Point(285, 31);
            this.btn_Montly.Name = "btn_Montly";
            this.btn_Montly.Size = new System.Drawing.Size(210, 43);
            this.btn_Montly.TabIndex = 0;
            this.btn_Montly.Text = "Monthly Report";
            this.btn_Montly.UseVisualStyleBackColor = true;
            this.btn_Montly.Click += new System.EventHandler(this.btn_Montly_Click);
            // 
            // btn_Weekly
            // 
            this.btn_Weekly.Location = new System.Drawing.Point(43, 31);
            this.btn_Weekly.Name = "btn_Weekly";
            this.btn_Weekly.Size = new System.Drawing.Size(210, 43);
            this.btn_Weekly.TabIndex = 0;
            this.btn_Weekly.Text = "Weekly Report";
            this.btn_Weekly.UseVisualStyleBackColor = true;
            this.btn_Weekly.Click += new System.EventHandler(this.btn_Weekly_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(55, 589);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(210, 27);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(297, 589);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(210, 27);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a Report to Display: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Display Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 637);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Montly;
        private System.Windows.Forms.Button btn_Weekly;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}