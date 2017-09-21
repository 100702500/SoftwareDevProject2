namespace DP2_V1
{
    partial class form_Mainmenu
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
            this.cont_Transaction = new System.Windows.Forms.GroupBox();
            this.btn_DisplayRec = new System.Windows.Forms.Button();
            this.btn_EditRec = new System.Windows.Forms.Button();
            this.btn_AddRec = new System.Windows.Forms.Button();
            this.cont_Report = new System.Windows.Forms.GroupBox();
            this.btn_GenWeek = new System.Windows.Forms.Button();
            this.btn_GenMonth = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.cont_Transaction.SuspendLayout();
            this.cont_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // cont_Transaction
            // 
            this.cont_Transaction.Controls.Add(this.btn_DisplayRec);
            this.cont_Transaction.Controls.Add(this.btn_EditRec);
            this.cont_Transaction.Controls.Add(this.btn_AddRec);
            this.cont_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_Transaction.Location = new System.Drawing.Point(15, 82);
            this.cont_Transaction.Name = "cont_Transaction";
            this.cont_Transaction.Size = new System.Drawing.Size(436, 267);
            this.cont_Transaction.TabIndex = 0;
            this.cont_Transaction.TabStop = false;
            this.cont_Transaction.Text = "Transactions:";
            // 
            // btn_DisplayRec
            // 
            this.btn_DisplayRec.Location = new System.Drawing.Point(57, 187);
            this.btn_DisplayRec.Name = "btn_DisplayRec";
            this.btn_DisplayRec.Size = new System.Drawing.Size(323, 30);
            this.btn_DisplayRec.TabIndex = 2;
            this.btn_DisplayRec.Text = "Display Sales Record";
            this.btn_DisplayRec.UseVisualStyleBackColor = true;
            this.btn_DisplayRec.Click += new System.EventHandler(this.btn_DisplayRec_Click);
            // 
            // btn_EditRec
            // 
            this.btn_EditRec.Location = new System.Drawing.Point(57, 118);
            this.btn_EditRec.Name = "btn_EditRec";
            this.btn_EditRec.Size = new System.Drawing.Size(323, 30);
            this.btn_EditRec.TabIndex = 1;
            this.btn_EditRec.Text = "Edit Sales Record";
            this.btn_EditRec.UseVisualStyleBackColor = true;
            this.btn_EditRec.Click += new System.EventHandler(this.btn_EditRec_Click);
            // 
            // btn_AddRec
            // 
            this.btn_AddRec.Location = new System.Drawing.Point(56, 50);
            this.btn_AddRec.Name = "btn_AddRec";
            this.btn_AddRec.Size = new System.Drawing.Size(323, 30);
            this.btn_AddRec.TabIndex = 0;
            this.btn_AddRec.Text = "Add Sales Record";
            this.btn_AddRec.UseVisualStyleBackColor = true;
            this.btn_AddRec.Click += new System.EventHandler(this.btn_AddRec_Click);
            // 
            // cont_Report
            // 
            this.cont_Report.Controls.Add(this.btn_GenWeek);
            this.cont_Report.Controls.Add(this.btn_GenMonth);
            this.cont_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_Report.Location = new System.Drawing.Point(480, 82);
            this.cont_Report.Name = "cont_Report";
            this.cont_Report.Size = new System.Drawing.Size(436, 267);
            this.cont_Report.TabIndex = 1;
            this.cont_Report.TabStop = false;
            this.cont_Report.Text = "Generate Reports: ";
            // 
            // btn_GenWeek
            // 
            this.btn_GenWeek.Location = new System.Drawing.Point(59, 155);
            this.btn_GenWeek.Name = "btn_GenWeek";
            this.btn_GenWeek.Size = new System.Drawing.Size(323, 30);
            this.btn_GenWeek.TabIndex = 4;
            this.btn_GenWeek.Text = "Weekly Report";
            this.btn_GenWeek.UseVisualStyleBackColor = true;
            this.btn_GenWeek.Click += new System.EventHandler(this.btn_GenWeek_Click);
            // 
            // btn_GenMonth
            // 
            this.btn_GenMonth.Location = new System.Drawing.Point(59, 79);
            this.btn_GenMonth.Name = "btn_GenMonth";
            this.btn_GenMonth.Size = new System.Drawing.Size(323, 30);
            this.btn_GenMonth.TabIndex = 3;
            this.btn_GenMonth.Text = "Montly Report";
            this.btn_GenMonth.UseVisualStyleBackColor = true;
            this.btn_GenMonth.Click += new System.EventHandler(this.btn_GenMonth_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.Location = new System.Drawing.Point(841, 399);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(75, 23);
            this.BTN_EXIT.TabIndex = 2;
            this.BTN_EXIT.Text = "EXIT";
            this.BTN_EXIT.UseVisualStyleBackColor = true;
            // 
            // form_Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 484);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.cont_Report);
            this.Controls.Add(this.cont_Transaction);
            this.Name = "form_Mainmenu";
            this.Text = "PHP - SREP : Main Menu";
            this.cont_Transaction.ResumeLayout(false);
            this.cont_Report.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cont_Transaction;
        private System.Windows.Forms.Button btn_DisplayRec;
        private System.Windows.Forms.Button btn_EditRec;
        private System.Windows.Forms.Button btn_AddRec;
        private System.Windows.Forms.GroupBox cont_Report;
        private System.Windows.Forms.Button btn_GenWeek;
        private System.Windows.Forms.Button btn_GenMonth;
        private System.Windows.Forms.Button BTN_EXIT;
    }
}

