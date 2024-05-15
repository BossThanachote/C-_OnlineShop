namespace ShopManagement
{
    partial class AddProduct
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
            this.ProdNameTb = new System.Windows.Forms.TextBox();
            this.ProdQtyTb = new System.Windows.Forms.TextBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BrandCb = new System.Windows.Forms.ComboBox();
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "เพิ่มสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 64);
            this.label2.TabIndex = 2;
            this.label2.Text = "ออกจากระบบ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Location = new System.Drawing.Point(101, 217);
            this.ProdNameTb.Multiline = true;
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(249, 41);
            this.ProdNameTb.TabIndex = 4;
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyTb.Location = new System.Drawing.Point(440, 217);
            this.ProdQtyTb.Multiline = true;
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(249, 41);
            this.ProdQtyTb.TabIndex = 5;
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(263, 423);
            this.PriceTb.Multiline = true;
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(249, 41);
            this.PriceTb.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(204, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(422, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BrandCb
            // 
            this.BrandCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandCb.FormattingEnabled = true;
            this.BrandCb.Items.AddRange(new object[] {
            "IPHONE",
            "SAMSUNG",
            "NOKIA",
            "SKIBIDI",
            "TOILET",
            "ROBLOX",
            "GUN"});
            this.BrandCb.Location = new System.Drawing.Point(101, 318);
            this.BrandCb.Name = "BrandCb";
            this.BrandCb.Size = new System.Drawing.Size(249, 33);
            this.BrandCb.TabIndex = 9;
            // 
            // CategoryCb
            // 
            this.CategoryCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Items.AddRange(new object[] {
            "PHONE",
            "BATCHROOM"});
            this.CategoryCb.Location = new System.Drawing.Point(440, 318);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(249, 33);
            this.CategoryCb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "ชื่อสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "แบรนด์สินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "ประเภทสินค้า";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "ราคาสินค้า";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(1, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 491);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(591, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 42);
            this.label8.TabIndex = 14;
            this.label8.Text = "กลับไปหน้าหลัก";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryCb);
            this.Controls.Add(this.BrandCb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.ProdQtyTb);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProdNameTb;
        private System.Windows.Forms.TextBox ProdQtyTb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox BrandCb;
        private System.Windows.Forms.ComboBox CategoryCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}