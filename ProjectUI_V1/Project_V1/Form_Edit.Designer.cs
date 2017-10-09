namespace Project_V1
{
    partial class Form_Edit
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
            this.grpbox_edit = new System.Windows.Forms.GroupBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numbox_qty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_price = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.grpbox_start = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.boxYear = new System.Windows.Forms.ComboBox();
            this.boxMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_editsel = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.grpbox_list = new System.Windows.Forms.GroupBox();
            this.lbl_listdate = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grpbox_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_qty)).BeginInit();
            this.grpbox_start.SuspendLayout();
            this.grpbox_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_edit
            // 
            this.grpbox_edit.Controls.Add(this.lbl_date);
            this.grpbox_edit.Controls.Add(this.lbl_name);
            this.grpbox_edit.Controls.Add(this.btn_delete);
            this.grpbox_edit.Controls.Add(this.btn_save);
            this.grpbox_edit.Controls.Add(this.label1);
            this.grpbox_edit.Controls.Add(this.label4);
            this.grpbox_edit.Controls.Add(this.numbox_qty);
            this.grpbox_edit.Controls.Add(this.label3);
            this.grpbox_edit.Controls.Add(this.label2);
            this.grpbox_edit.Controls.Add(this.txtbox_price);
            this.grpbox_edit.Location = new System.Drawing.Point(21, 358);
            this.grpbox_edit.Name = "grpbox_edit";
            this.grpbox_edit.Size = new System.Drawing.Size(532, 165);
            this.grpbox_edit.TabIndex = 7;
            this.grpbox_edit.TabStop = false;
            this.grpbox_edit.Text = "Edit/Add Sales Record:";
            this.grpbox_edit.Visible = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(125, 31);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(75, 13);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "DD-MM-YYYY";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(125, 46);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(72, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "ProductName";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(377, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(111, 43);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete Item";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(377, 103);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(111, 43);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date and Time: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name: ";
            // 
            // numbox_qty
            // 
            this.numbox_qty.Location = new System.Drawing.Point(128, 74);
            this.numbox_qty.Name = "numbox_qty";
            this.numbox_qty.Size = new System.Drawing.Size(129, 20);
            this.numbox_qty.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Qty:";
            // 
            // txtbox_price
            // 
            this.txtbox_price.Location = new System.Drawing.Point(128, 100);
            this.txtbox_price.Name = "txtbox_price";
            this.txtbox_price.Size = new System.Drawing.Size(129, 20);
            this.txtbox_price.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(47, 584);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(210, 27);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(299, 584);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(210, 27);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // grpbox_start
            // 
            this.grpbox_start.Controls.Add(this.label6);
            this.grpbox_start.Controls.Add(this.btn_confirm);
            this.grpbox_start.Controls.Add(this.boxYear);
            this.grpbox_start.Controls.Add(this.boxMonth);
            this.grpbox_start.Controls.Add(this.label7);
            this.grpbox_start.Controls.Add(this.btn_Search);
            this.grpbox_start.Controls.Add(this.label8);
            this.grpbox_start.Controls.Add(this.label9);
            this.grpbox_start.Controls.Add(this.listBox1);
            this.grpbox_start.Location = new System.Drawing.Point(21, 12);
            this.grpbox_start.Name = "grpbox_start";
            this.grpbox_start.Size = new System.Drawing.Size(532, 176);
            this.grpbox_start.TabIndex = 10;
            this.grpbox_start.TabStop = false;
            this.grpbox_start.Text = "Select a transaction to edit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "List of Transactions:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(377, 113);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(111, 43);
            this.btn_confirm.TabIndex = 24;
            this.btn_confirm.Text = "Continue";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Visible = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // boxYear
            // 
            this.boxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxYear.FormattingEnabled = true;
            this.boxYear.Location = new System.Drawing.Point(245, 19);
            this.boxYear.Name = "boxYear";
            this.boxYear.Size = new System.Drawing.Size(70, 21);
            this.boxYear.TabIndex = 22;
            // 
            // boxMonth
            // 
            this.boxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMonth.FormattingEnabled = true;
            this.boxMonth.Location = new System.Drawing.Point(147, 19);
            this.boxMonth.Name = "boxMonth";
            this.boxMonth.Size = new System.Drawing.Size(53, 21);
            this.boxMonth.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Search:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(377, 40);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 43);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Month";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Year";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 95);
            this.listBox1.TabIndex = 11;
            // 
            // btn_editsel
            // 
            this.btn_editsel.Location = new System.Drawing.Point(377, 29);
            this.btn_editsel.Name = "btn_editsel";
            this.btn_editsel.Size = new System.Drawing.Size(111, 43);
            this.btn_editsel.TabIndex = 18;
            this.btn_editsel.Text = "Edit";
            this.btn_editsel.UseVisualStyleBackColor = true;
            this.btn_editsel.Click += new System.EventHandler(this.btn_editsel_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(19, 45);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(299, 95);
            this.listBox2.TabIndex = 24;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // grpbox_list
            // 
            this.grpbox_list.Controls.Add(this.lbl_listdate);
            this.grpbox_list.Controls.Add(this.btn_add);
            this.grpbox_list.Controls.Add(this.label10);
            this.grpbox_list.Controls.Add(this.listBox2);
            this.grpbox_list.Controls.Add(this.btn_editsel);
            this.grpbox_list.Location = new System.Drawing.Point(21, 194);
            this.grpbox_list.Name = "grpbox_list";
            this.grpbox_list.Size = new System.Drawing.Size(532, 158);
            this.grpbox_list.TabIndex = 26;
            this.grpbox_list.TabStop = false;
            this.grpbox_list.Text = "Select an Item to edit: ";
            this.grpbox_list.Visible = false;
            this.grpbox_list.Enter += new System.EventHandler(this.grpbox_list_Enter);
            // 
            // lbl_listdate
            // 
            this.lbl_listdate.AutoSize = true;
            this.lbl_listdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listdate.Location = new System.Drawing.Point(179, 29);
            this.lbl_listdate.Name = "lbl_listdate";
            this.lbl_listdate.Size = new System.Drawing.Size(14, 13);
            this.lbl_listdate.TabIndex = 27;
            this.lbl_listdate.Text = "_";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(377, 97);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 43);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Add New Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "List of Product in a Transaction:";
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 623);
            this.Controls.Add(this.grpbox_list);
            this.Controls.Add(this.grpbox_start);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.grpbox_edit);
            this.Controls.Add(this.btn_back);
            this.Name = "Form_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Edit";
            this.grpbox_edit.ResumeLayout(false);
            this.grpbox_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_qty)).EndInit();
            this.grpbox_start.ResumeLayout(false);
            this.grpbox_start.PerformLayout();
            this.grpbox_list.ResumeLayout(false);
            this.grpbox_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numbox_qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_price;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox grpbox_start;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_editsel;
        private System.Windows.Forms.ComboBox boxYear;
        private System.Windows.Forms.ComboBox boxMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox grpbox_list;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_listdate;
    }
}