namespace SalesWinApp
{
    partial class ProductUpdating
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.ibProductName = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(134, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(330, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(162, 280);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(243, 23);
            this.txtQuantity.TabIndex = 26;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(61, 283);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 25;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(61, 229);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 24;
            this.lbPrice.Text = "Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(61, 181);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 23;
            this.lbWeight.Text = "Weight";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(162, 226);
            this.txtPrice.Mask = "000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(243, 23);
            this.txtPrice.TabIndex = 22;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(162, 173);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(243, 23);
            this.txtWeight.TabIndex = 21;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(162, 93);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(243, 23);
            this.txtCategoryId.TabIndex = 20;
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(61, 96);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(66, 15);
            this.lbCategoryId.TabIndex = 19;
            this.lbCategoryId.Text = "CategoryID";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(162, 129);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(243, 23);
            this.txtProductName.TabIndex = 18;
            // 
            // ibProductName
            // 
            this.ibProductName.AutoSize = true;
            this.ibProductName.Location = new System.Drawing.Point(61, 132);
            this.ibProductName.Name = "ibProductName";
            this.ibProductName.Size = new System.Drawing.Size(81, 15);
            this.ibProductName.TabIndex = 17;
            this.ibProductName.Text = "ProductName";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(162, 50);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(243, 23);
            this.txtProductID.TabIndex = 16;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(61, 53);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(60, 15);
            this.lbProductID.TabIndex = 15;
            this.lbProductID.Text = "ProductID";
            // 
            // ProductUpdating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 423);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
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
            this.Name = "ProductUpdating";
            this.Text = "ProductUpdating";
            this.Load += new System.EventHandler(this.ProductUpdating_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private Button btnClose;
        private TextBox txtQuantity;
        private Label lbQuantity;
        private Label lbPrice;
        private Label lbWeight;
        private MaskedTextBox txtPrice;
        private TextBox txtWeight;
        private TextBox txtCategoryId;
        private Label lbCategoryId;
        private TextBox txtProductName;
        private Label ibProductName;
        private TextBox txtProductID;
        private Label lbProductID;
    }
}