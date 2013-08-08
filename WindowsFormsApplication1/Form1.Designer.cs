namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.grpProductDetails = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TxtMarkUp = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMarkUp = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grpTransaction = new System.Windows.Forms.GroupBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpProductDetails.SuspendLayout();
            this.grpTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 14;
            this.lstProduct.Location = new System.Drawing.Point(12, 53);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(357, 326);
            this.lstProduct.TabIndex = 1;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // grpProductDetails
            // 
            this.grpProductDetails.Controls.Add(this.btnDelete);
            this.grpProductDetails.Controls.Add(this.btnAdd);
            this.grpProductDetails.Controls.Add(this.TxtMarkUp);
            this.grpProductDetails.Controls.Add(this.TxtDescription);
            this.grpProductDetails.Controls.Add(this.lblDescription);
            this.grpProductDetails.Controls.Add(this.lblMarkUp);
            this.grpProductDetails.Controls.Add(this.TxtID);
            this.grpProductDetails.Controls.Add(this.lblID);
            this.grpProductDetails.Location = new System.Drawing.Point(395, 53);
            this.grpProductDetails.Name = "grpProductDetails";
            this.grpProductDetails.Size = new System.Drawing.Size(306, 173);
            this.grpProductDetails.TabIndex = 2;
            this.grpProductDetails.TabStop = false;
            this.grpProductDetails.Text = "Product Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Processing Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Processing Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TxtMarkUp
            // 
            this.TxtMarkUp.Location = new System.Drawing.Point(141, 42);
            this.TxtMarkUp.Name = "TxtMarkUp";
            this.TxtMarkUp.Size = new System.Drawing.Size(100, 20);
            this.TxtMarkUp.TabIndex = 5;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(141, 68);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 20);
            this.TxtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(6, 65);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Product Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarkUp
            // 
            this.lblMarkUp.Location = new System.Drawing.Point(6, 39);
            this.lblMarkUp.Name = "lblMarkUp";
            this.lblMarkUp.Size = new System.Drawing.Size(100, 23);
            this.lblMarkUp.TabIndex = 2;
            this.lblMarkUp.Text = "Product Mark Up";
            this.lblMarkUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(141, 16);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(3, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Product ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpTransaction
            // 
            this.grpTransaction.Controls.Add(this.LblPrice);
            this.grpTransaction.Controls.Add(this.btnSell);
            this.grpTransaction.Controls.Add(this.btnBuy);
            this.grpTransaction.Controls.Add(this.TxtQty);
            this.grpTransaction.Controls.Add(this.lblSalePrice);
            this.grpTransaction.Controls.Add(this.lblQty);
            this.grpTransaction.Controls.Add(this.TxtCost);
            this.grpTransaction.Controls.Add(this.lblCost);
            this.grpTransaction.Location = new System.Drawing.Point(401, 232);
            this.grpTransaction.Name = "grpTransaction";
            this.grpTransaction.Size = new System.Drawing.Size(306, 173);
            this.grpTransaction.TabIndex = 8;
            this.grpTransaction.TabStop = false;
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPrice.Location = new System.Drawing.Point(138, 68);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(103, 23);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(141, 133);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(111, 23);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Processing Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(141, 94);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(111, 23);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Processing Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(141, 42);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(100, 20);
            this.TxtQty.TabIndex = 5;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Location = new System.Drawing.Point(6, 65);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(100, 23);
            this.lblSalePrice.TabIndex = 3;
            this.lblSalePrice.Text = "Sale Price ($):";
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(6, 39);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(100, 23);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Qty:";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(141, 16);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(100, 20);
            this.TxtCost.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(3, 16);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(100, 23);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost ($):";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(55, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(196, 395);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(111, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 433);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpTransaction);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.grpProductDetails);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Product Processing Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpProductDetails.ResumeLayout(false);
            this.grpProductDetails.PerformLayout();
            this.grpTransaction.ResumeLayout(false);
            this.grpTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.GroupBox grpProductDetails;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox TxtMarkUp;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMarkUp;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.GroupBox grpTransaction;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
    }
}

