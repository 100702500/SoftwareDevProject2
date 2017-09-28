namespace Project_V1
{
    partial class Form_MainMenu
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
            this.cont_Report = new System.Windows.Forms.GroupBox();
            this.btn_GenWeek = new System.Windows.Forms.Button();
            this.btn_GenMonth = new System.Windows.Forms.Button();
            this.cont_Transaction = new System.Windows.Forms.GroupBox();
            this.btn_DisplayRec = new System.Windows.Forms.Button();
            this.btn_EditRec = new System.Windows.Forms.Button();
            this.btn_AddRec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cont_Report.SuspendLayout();
            this.cont_Transaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // cont_Report
            // 
            this.cont_Report.Controls.Add(this.btn_GenWeek);
            this.cont_Report.Controls.Add(this.btn_GenMonth);
            this.cont_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_Report.Location = new System.Drawing.Point(23, 316);
            this.cont_Report.Name = "cont_Report";
            this.cont_Report.Size = new System.Drawing.Size(518, 254);
            this.cont_Report.TabIndex = 4;
            this.cont_Report.TabStop = false;
            this.cont_Report.Text = "Generate Reports: ";
            // 
            // btn_GenWeek
            // 
            this.btn_GenWeek.Location = new System.Drawing.Point(43, 180);
            this.btn_GenWeek.Name = "btn_GenWeek";
            this.btn_GenWeek.Size = new System.Drawing.Size(422, 48);
            this.btn_GenWeek.TabIndex = 4;
            this.btn_GenWeek.Text = "Weekly Report";
            this.btn_GenWeek.UseVisualStyleBackColor = true;
            // 
            // btn_GenMonth
            // 
            this.btn_GenMonth.Location = new System.Drawing.Point(43, 86);
            this.btn_GenMonth.Name = "btn_GenMonth";
            this.btn_GenMonth.Size = new System.Drawing.Size(422, 48);
            this.btn_GenMonth.TabIndex = 3;
            this.btn_GenMonth.Text = "Montly Report";
            this.btn_GenMonth.UseVisualStyleBackColor = true;
            // 
            // cont_Transaction
            // 
            this.cont_Transaction.Controls.Add(this.btn_DisplayRec);
            this.cont_Transaction.Controls.Add(this.btn_EditRec);
            this.cont_Transaction.Controls.Add(this.btn_AddRec);
            this.cont_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_Transaction.Location = new System.Drawing.Point(23, 12);
            this.cont_Transaction.Name = "cont_Transaction";
            this.cont_Transaction.Size = new System.Drawing.Size(518, 298);
            this.cont_Transaction.TabIndex = 3;
            this.cont_Transaction.TabStop = false;
            this.cont_Transaction.Text = "Transactions:";
            // 
            // btn_DisplayRec
            // 
            this.btn_DisplayRec.Location = new System.Drawing.Point(43, 198);
            this.btn_DisplayRec.Name = "btn_DisplayRec";
            this.btn_DisplayRec.Size = new System.Drawing.Size(422, 48);
            this.btn_DisplayRec.TabIndex = 2;
            this.btn_DisplayRec.Text = "Display Sales Record";
            this.btn_DisplayRec.UseVisualStyleBackColor = true;
            this.btn_DisplayRec.Click += new System.EventHandler(this.btn_DisplayRec_Click);
            // 
            // btn_EditRec
            // 
            this.btn_EditRec.Location = new System.Drawing.Point(43, 125);
            this.btn_EditRec.Name = "btn_EditRec";
            this.btn_EditRec.Size = new System.Drawing.Size(422, 48);
            this.btn_EditRec.TabIndex = 1;
            this.btn_EditRec.Text = "Edit Sales Record";
            this.btn_EditRec.UseVisualStyleBackColor = true;
            this.btn_EditRec.Click += new System.EventHandler(this.btn_EditRec_Click);
            // 
            // btn_AddRec
            // 
            this.btn_AddRec.Location = new System.Drawing.Point(43, 48);
            this.btn_AddRec.Name = "btn_AddRec";
            this.btn_AddRec.Size = new System.Drawing.Size(422, 48);
            this.btn_AddRec.TabIndex = 0;
            this.btn_AddRec.Text = "Add Sales Record";
            this.btn_AddRec.UseVisualStyleBackColor = true;
            this.btn_AddRec.Click += new System.EventHandler(this.btn_AddRec_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cont_Report);
            this.Controls.Add(this.cont_Transaction);
            this.Name = "Form_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHP-SREP ";
            this.Load += new System.EventHandler(this.Form_MainMenu_Load);
            this.cont_Report.ResumeLayout(false);
            this.cont_Transaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cont_Report;
        private System.Windows.Forms.Button btn_GenWeek;
        private System.Windows.Forms.Button btn_GenMonth;
        private System.Windows.Forms.GroupBox cont_Transaction;
        private System.Windows.Forms.Button btn_DisplayRec;
        private System.Windows.Forms.Button btn_EditRec;
        private System.Windows.Forms.Button btn_AddRec;
        private System.Windows.Forms.Button button2;
    }
}