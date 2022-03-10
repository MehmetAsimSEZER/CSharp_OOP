namespace Abstraction_Example
{
    partial class EstatePage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_create = new System.Windows.Forms.GroupBox();
            this.cmb_create = new System.Windows.Forms.ComboBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.txtCreate_Price = new System.Windows.Forms.TextBox();
            this.txtCreate_Adress = new System.Windows.Forms.TextBox();
            this.txtCreate_Description = new System.Windows.Forms.TextBox();
            this.txt_create_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_update = new System.Windows.Forms.GroupBox();
            this.cmb_update = new System.Windows.Forms.ComboBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdate_Price = new System.Windows.Forms.TextBox();
            this.txtUpdate_Adress = new System.Windows.Forms.TextBox();
            this.txtUpdate_Description = new System.Windows.Forms.TextBox();
            this.txt_find_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grp_delete = new System.Windows.Forms.GroupBox();
            this.txt_delete_Id = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_getDescription = new System.Windows.Forms.TextBox();
            this.btn_getDescription = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cmb_getPropertyRental = new System.Windows.Forms.ComboBox();
            this.btn_Price = new System.Windows.Forms.Button();
            this.btn_rental = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_create.SuspendLayout();
            this.grp_update.SuspendLayout();
            this.grp_delete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // grp_create
            // 
            this.grp_create.Controls.Add(this.cmb_create);
            this.grp_create.Controls.Add(this.btn_Create);
            this.grp_create.Controls.Add(this.txtCreate_Price);
            this.grp_create.Controls.Add(this.txtCreate_Adress);
            this.grp_create.Controls.Add(this.txtCreate_Description);
            this.grp_create.Controls.Add(this.txt_create_Id);
            this.grp_create.Controls.Add(this.label5);
            this.grp_create.Controls.Add(this.label4);
            this.grp_create.Controls.Add(this.label3);
            this.grp_create.Controls.Add(this.label2);
            this.grp_create.Controls.Add(this.label1);
            this.grp_create.Location = new System.Drawing.Point(12, 12);
            this.grp_create.Name = "grp_create";
            this.grp_create.Size = new System.Drawing.Size(248, 220);
            this.grp_create.TabIndex = 1;
            this.grp_create.TabStop = false;
            this.grp_create.Text = "Create Estate";
            // 
            // cmb_create
            // 
            this.cmb_create.FormattingEnabled = true;
            this.cmb_create.Location = new System.Drawing.Point(142, 55);
            this.cmb_create.Name = "cmb_create";
            this.cmb_create.Size = new System.Drawing.Size(100, 21);
            this.cmb_create.TabIndex = 11;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(167, 163);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 10;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txtCreate_Price
            // 
            this.txtCreate_Price.Location = new System.Drawing.Point(142, 137);
            this.txtCreate_Price.Name = "txtCreate_Price";
            this.txtCreate_Price.Size = new System.Drawing.Size(100, 20);
            this.txtCreate_Price.TabIndex = 9;
            // 
            // txtCreate_Adress
            // 
            this.txtCreate_Adress.Location = new System.Drawing.Point(142, 109);
            this.txtCreate_Adress.Name = "txtCreate_Adress";
            this.txtCreate_Adress.Size = new System.Drawing.Size(100, 20);
            this.txtCreate_Adress.TabIndex = 8;
            // 
            // txtCreate_Description
            // 
            this.txtCreate_Description.Location = new System.Drawing.Point(142, 81);
            this.txtCreate_Description.Name = "txtCreate_Description";
            this.txtCreate_Description.Size = new System.Drawing.Size(100, 20);
            this.txtCreate_Description.TabIndex = 7;
            // 
            // txt_create_Id
            // 
            this.txt_create_Id.Location = new System.Drawing.Point(142, 26);
            this.txt_create_Id.Name = "txt_create_Id";
            this.txt_create_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_create_Id.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Property Rental:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // grp_update
            // 
            this.grp_update.Controls.Add(this.cmb_update);
            this.grp_update.Controls.Add(this.btn_Find);
            this.grp_update.Controls.Add(this.btn_Update);
            this.grp_update.Controls.Add(this.label10);
            this.grp_update.Controls.Add(this.txtUpdate_Price);
            this.grp_update.Controls.Add(this.txtUpdate_Adress);
            this.grp_update.Controls.Add(this.txtUpdate_Description);
            this.grp_update.Controls.Add(this.txt_find_Id);
            this.grp_update.Controls.Add(this.label6);
            this.grp_update.Controls.Add(this.label7);
            this.grp_update.Controls.Add(this.label8);
            this.grp_update.Controls.Add(this.label9);
            this.grp_update.Location = new System.Drawing.Point(266, 12);
            this.grp_update.Name = "grp_update";
            this.grp_update.Size = new System.Drawing.Size(259, 220);
            this.grp_update.TabIndex = 2;
            this.grp_update.TabStop = false;
            this.grp_update.Text = "Update Estate";
            // 
            // cmb_update
            // 
            this.cmb_update.FormattingEnabled = true;
            this.cmb_update.Location = new System.Drawing.Point(130, 55);
            this.cmb_update.Name = "cmb_update";
            this.cmb_update.Size = new System.Drawing.Size(100, 21);
            this.cmb_update.TabIndex = 18;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(169, 23);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(61, 23);
            this.btn_Find.TabIndex = 17;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(155, 163);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Id:";
            // 
            // txtUpdate_Price
            // 
            this.txtUpdate_Price.Location = new System.Drawing.Point(130, 137);
            this.txtUpdate_Price.Name = "txtUpdate_Price";
            this.txtUpdate_Price.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate_Price.TabIndex = 14;
            // 
            // txtUpdate_Adress
            // 
            this.txtUpdate_Adress.Location = new System.Drawing.Point(130, 109);
            this.txtUpdate_Adress.Name = "txtUpdate_Adress";
            this.txtUpdate_Adress.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate_Adress.TabIndex = 13;
            // 
            // txtUpdate_Description
            // 
            this.txtUpdate_Description.Location = new System.Drawing.Point(130, 81);
            this.txtUpdate_Description.Name = "txtUpdate_Description";
            this.txtUpdate_Description.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate_Description.TabIndex = 12;
            // 
            // txt_find_Id
            // 
            this.txt_find_Id.Location = new System.Drawing.Point(130, 26);
            this.txt_find_Id.Name = "txt_find_Id";
            this.txt_find_Id.Size = new System.Drawing.Size(33, 20);
            this.txt_find_Id.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adress:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Property Rental:";
            // 
            // grp_delete
            // 
            this.grp_delete.Controls.Add(this.txt_delete_Id);
            this.grp_delete.Controls.Add(this.btn_Delete);
            this.grp_delete.Controls.Add(this.label11);
            this.grp_delete.Location = new System.Drawing.Point(531, 12);
            this.grp_delete.Name = "grp_delete";
            this.grp_delete.Size = new System.Drawing.Size(257, 101);
            this.grp_delete.TabIndex = 3;
            this.grp_delete.TabStop = false;
            this.grp_delete.Text = "Delete Estate";
            // 
            // txt_delete_Id
            // 
            this.txt_delete_Id.Location = new System.Drawing.Point(120, 29);
            this.txt_delete_Id.Name = "txt_delete_Id";
            this.txt_delete_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_delete_Id.TabIndex = 18;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(145, 58);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_getDescription);
            this.groupBox1.Controls.Add(this.txt_getDescription);
            this.groupBox1.Location = new System.Drawing.Point(531, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Description";
            // 
            // txt_getDescription
            // 
            this.txt_getDescription.Location = new System.Drawing.Point(120, 19);
            this.txt_getDescription.Name = "txt_getDescription";
            this.txt_getDescription.Size = new System.Drawing.Size(100, 20);
            this.txt_getDescription.TabIndex = 0;
            // 
            // btn_getDescription
            // 
            this.btn_getDescription.Location = new System.Drawing.Point(145, 56);
            this.btn_getDescription.Name = "btn_getDescription";
            this.btn_getDescription.Size = new System.Drawing.Size(75, 23);
            this.btn_getDescription.TabIndex = 19;
            this.btn_getDescription.Text = "Get";
            this.btn_getDescription.UseVisualStyleBackColor = true;
            this.btn_getDescription.Click += new System.EventHandler(this.btn_getDescription_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Description:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_Price);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Location = new System.Drawing.Point(794, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Price ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btn_rental);
            this.groupBox3.Controls.Add(this.cmb_getPropertyRental);
            this.groupBox3.Location = new System.Drawing.Point(794, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 113);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Property Rental";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(130, 20);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 0;
            // 
            // cmb_getPropertyRental
            // 
            this.cmb_getPropertyRental.FormattingEnabled = true;
            this.cmb_getPropertyRental.Location = new System.Drawing.Point(115, 29);
            this.cmb_getPropertyRental.Name = "cmb_getPropertyRental";
            this.cmb_getPropertyRental.Size = new System.Drawing.Size(121, 21);
            this.cmb_getPropertyRental.TabIndex = 0;
            // 
            // btn_Price
            // 
            this.btn_Price.Location = new System.Drawing.Point(155, 52);
            this.btn_Price.Name = "btn_Price";
            this.btn_Price.Size = new System.Drawing.Size(75, 23);
            this.btn_Price.TabIndex = 1;
            this.btn_Price.Text = "Get";
            this.btn_Price.UseVisualStyleBackColor = true;
            this.btn_Price.Click += new System.EventHandler(this.btn_Price_Click);
            // 
            // btn_rental
            // 
            this.btn_rental.Location = new System.Drawing.Point(161, 56);
            this.btn_rental.Name = "btn_rental";
            this.btn_rental.Size = new System.Drawing.Size(75, 23);
            this.btn_rental.TabIndex = 1;
            this.btn_rental.Text = "Get";
            this.btn_rental.UseVisualStyleBackColor = true;
            this.btn_rental.Click += new System.EventHandler(this.btn_rental_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Property Rental:";
            // 
            // EstatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_delete);
            this.Controls.Add(this.grp_update);
            this.Controls.Add(this.grp_create);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EstatePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EstatePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_create.ResumeLayout(false);
            this.grp_create.PerformLayout();
            this.grp_update.ResumeLayout(false);
            this.grp_update.PerformLayout();
            this.grp_delete.ResumeLayout(false);
            this.grp_delete.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grp_create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_update;
        private System.Windows.Forms.GroupBox grp_delete;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txtCreate_Price;
        private System.Windows.Forms.TextBox txtCreate_Adress;
        private System.Windows.Forms.TextBox txtCreate_Description;
        private System.Windows.Forms.TextBox txt_create_Id;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdate_Price;
        private System.Windows.Forms.TextBox txtUpdate_Adress;
        private System.Windows.Forms.TextBox txtUpdate_Description;
        private System.Windows.Forms.TextBox txt_find_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_delete_Id;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_create;
        private System.Windows.Forms.ComboBox cmb_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_getDescription;
        private System.Windows.Forms.TextBox txt_getDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Price;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_rental;
        private System.Windows.Forms.ComboBox cmb_getPropertyRental;
    }
}

