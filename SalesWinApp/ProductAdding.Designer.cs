namespace SalesWinApp
{
    partial class ProductAdding
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
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.ibProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(52, 53);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(60, 15);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "ProductID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(153, 50);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(243, 23);
            this.txtProductID.TabIndex = 1;
            
            // 
            // ibProductName
            // 
            this.ibProductName.AutoSize = true;
            this.ibProductName.Location = new System.Drawing.Point(52, 132);
            this.ibProductName.Name = "ibProductName";
            this.ibProductName.Size = new System.Drawing.Size(81, 15);
            this.ibProductName.TabIndex = 2;
            this.ibProductName.Text = "ProductName";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(153, 129);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(243, 23);
            this.txtProductName.TabIndex = 3;
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(52, 96);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(66, 15);
            this.lbCategoryId.TabIndex = 4;
            this.lbCategoryId.Text = "CategoryID";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(153, 93);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(243, 23);
            this.txtCategoryId.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(153, 173);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(243, 23);
            this.txtWeight.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(153, 226);
            this.txtPrice.Mask = "000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(243, 23);
            this.txtPrice.TabIndex = 7;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(52, 181);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 8;
            this.lbWeight.Text = "Weight";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(52, 229);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 9;
            this.lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(52, 283);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 10;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(153, 280);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(243, 23);
            this.txtQuantity.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(321, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProductAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 423);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.lbCategoryId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.ibProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbProductID);
            this.Name = "ProductAdding";
            this.Text = "ProductAdding";
            this.Load += new System.EventHandler(this.ProductAdding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbProductID;
        private TextBox txtProductID;
        private Label ibProductName;
        private TextBox txtProductName;
        private Label lbCategoryId;
        private TextBox txtCategoryId;
        private TextBox txtWeight;
        private MaskedTextBox txtPrice;
        private Label lbWeight;
        private Label lbPrice;
        private Label lbQuantity;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnClose;
    }
}