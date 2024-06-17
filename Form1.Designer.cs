
namespace Mini_project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.comb_Quantity = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Get = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.cmd_Pmode = new System.Windows.Forms.ComboBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(521, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing System\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(42, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(42, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(42, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 362);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(152, 99);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(121, 22);
            this.txt_ProductID.TabIndex = 8;
            this.txt_ProductID.TabIndexChanged += new System.EventHandler(this.Form1_Load);
            this.txt_ProductID.DoubleClick += new System.EventHandler(this.txt_ProductID_DoubleClick);
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Enabled = false;
            this.txt_ProductName.Location = new System.Drawing.Point(152, 156);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(121, 22);
            this.txt_ProductName.TabIndex = 9;
            // 
            // txt_Price
            // 
            this.txt_Price.Enabled = false;
            this.txt_Price.Location = new System.Drawing.Point(152, 212);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(121, 22);
            this.txt_Price.TabIndex = 10;
            // 
            // comb_Quantity
            // 
            this.comb_Quantity.FormattingEnabled = true;
            this.comb_Quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comb_Quantity.Location = new System.Drawing.Point(152, 264);
            this.comb_Quantity.Name = "comb_Quantity";
            this.comb_Quantity.Size = new System.Drawing.Size(121, 24);
            this.comb_Quantity.TabIndex = 11;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Delete.Location = new System.Drawing.Point(86, 460);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(135, 37);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Add.Location = new System.Drawing.Point(12, 349);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(128, 40);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add Product";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Clear.Location = new System.Drawing.Point(152, 349);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(135, 40);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear Details";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Update.Location = new System.Drawing.Point(12, 405);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(135, 40);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update Changes";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Get
            // 
            this.btn_Get.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Get.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Get.Location = new System.Drawing.Point(159, 407);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(128, 37);
            this.btn_Get.TabIndex = 17;
            this.btn_Get.Text = "Get details";
            this.btn_Get.UseVisualStyleBackColor = false;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(824, 462);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(0, 20);
            this.label_Total.TabIndex = 18;
            // 
            // cmd_Pmode
            // 
            this.cmd_Pmode.FormattingEnabled = true;
            this.cmd_Pmode.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "UPI Payment"});
            this.cmd_Pmode.Location = new System.Drawing.Point(818, 499);
            this.cmd_Pmode.Name = "cmd_Pmode";
            this.cmd_Pmode.Size = new System.Drawing.Size(121, 24);
            this.cmd_Pmode.TabIndex = 23;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.Black;
            this.btn_Print.Location = new System.Drawing.Point(1068, 460);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Print.Size = new System.Drawing.Size(163, 81);
            this.btn_Print.TabIndex = 24;
            this.btn_Print.Text = "Bill Generate";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Payment Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.cmd_Pmode);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.comb_Quantity);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "=";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.ComboBox comb_Quantity;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.ComboBox cmd_Pmode;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label6;
    }
}

