namespace ShopManagement
{
    partial class ProdNameID
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
            this.label3 = new System.Windows.Forms.Label();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.ProdNameTb = new System.Windows.Forms.TextBox();
            this.ProdQtyTb = new System.Windows.Forms.TextBox();
            this.ProdPriceTb = new System.Windows.Forms.TextBox();
            this.ProdBrandCb = new System.Windows.Forms.ComboBox();
            this.ProdCatCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProdIdTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(898, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "ออกจากระบบ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProductDGV
            // 
            this.ProductDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(210, 316);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDGV.Size = new System.Drawing.Size(638, 285);
            this.ProductDGV.TabIndex = 5;
            this.ProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV_CellContentClick);
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Location = new System.Drawing.Point(25, 132);
            this.ProdNameTb.Multiline = true;
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(161, 41);
            this.ProdNameTb.TabIndex = 20;
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.Location = new System.Drawing.Point(249, 132);
            this.ProdQtyTb.Multiline = true;
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(161, 41);
            this.ProdQtyTb.TabIndex = 20;
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.Location = new System.Drawing.Point(845, 132);
            this.ProdPriceTb.Multiline = true;
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(161, 41);
            this.ProdPriceTb.TabIndex = 20;
            // 
            // ProdBrandCb
            // 
            this.ProdBrandCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdBrandCb.FormattingEnabled = true;
            this.ProdBrandCb.Items.AddRange(new object[] {
            "IPHONE",
            "SAMSUNG",
            "NOKIA",
            "SKIBIDI",
            "TOILET",
            "ROBLOX",
            "GUN"});
            this.ProdBrandCb.Location = new System.Drawing.Point(437, 136);
            this.ProdBrandCb.Name = "ProdBrandCb";
            this.ProdBrandCb.Size = new System.Drawing.Size(169, 33);
            this.ProdBrandCb.TabIndex = 20;
            // 
            // ProdCatCb
            // 
            this.ProdCatCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdCatCb.FormattingEnabled = true;
            this.ProdCatCb.Items.AddRange(new object[] {
            "PHONE",
            "BATCHROOM"});
            this.ProdCatCb.Location = new System.Drawing.Point(640, 136);
            this.ProdCatCb.Name = "ProdCatCb";
            this.ProdCatCb.Size = new System.Drawing.Size(169, 33);
            this.ProdCatCb.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "แบรนด์สินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "ประเภทสินค้า";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(838, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "ราคาสินค้า";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 63);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(409, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 63);
            this.button2.TabIndex = 17;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(663, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 63);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.Location = new System.Drawing.Point(25, 207);
            this.ProdIdTb.Multiline = true;
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.Size = new System.Drawing.Size(119, 23);
            this.ProdIdTb.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "รหัสสินค้า";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-8, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1056, 73);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(826, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 42);
            this.label8.TabIndex = 21;
            this.label8.Text = "กลับไปหน้าหลัก";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ProdNameID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 613);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdCatCb);
            this.Controls.Add(this.ProdBrandCb);
            this.Controls.Add(this.ProdPriceTb);
            this.Controls.Add(this.ProdQtyTb);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.ProductDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ProdNameID";
            this.Text = "ViewStock";
            this.Load += new System.EventHandler(this.ViewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.TextBox ProdNameTb;
        private System.Windows.Forms.TextBox ProdQtyTb;
        private System.Windows.Forms.TextBox ProdPriceTb;
        private System.Windows.Forms.ComboBox ProdBrandCb;
        private System.Windows.Forms.ComboBox ProdCatCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ProdIdTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}