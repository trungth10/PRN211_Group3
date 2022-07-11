namespace SalesWinApp
{
    partial class OrderUpdating
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
            this.lbOrderId = new System.Windows.Forms.Label();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(55, 41);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(47, 15);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "OrderId";
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(54, 77);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(62, 15);
            this.lbMemberId.TabIndex = 1;
            this.lbMemberId.Text = "MemberId";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(54, 116);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(61, 15);
            this.lbOrderDate.TabIndex = 2;
            this.lbOrderDate.Text = "OrderDate";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(55, 160);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(78, 15);
            this.lbRequiredDate.TabIndex = 3;
            this.lbRequiredDate.Text = "RequiredDate";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(55, 200);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(74, 15);
            this.lbShippedDate.TabIndex = 4;
            this.lbShippedDate.Text = "ShippedDate";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(55, 240);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 5;
            this.lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(187, 238);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFreight.Mask = "0000";
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(182, 23);
            this.txtFreight.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 289);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 22);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 289);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 22);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(187, 39);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(182, 23);
            this.txtOrderId.TabIndex = 14;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(187, 72);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(182, 23);
            this.txtMemberId.TabIndex = 15;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtOrderDate.Location = new System.Drawing.Point(187, 110);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(182, 23);
            this.txtOrderDate.TabIndex = 16;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtRequiredDate.Location = new System.Drawing.Point(187, 154);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(182, 23);
            this.txtRequiredDate.TabIndex = 17;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtShippedDate.Location = new System.Drawing.Point(187, 194);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(182, 23);
            this.txtShippedDate.TabIndex = 18;
            // 
            // OrderUpdating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 338);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.lbOrderId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderUpdating";
            this.Text = "OrderUpdating";
            this.Load += new System.EventHandler(this.OrderUpdating_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderId;
        private Label lbMemberId;
        private Label lbOrderDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private Label lbFreight;
        private MaskedTextBox txtFreight;
        private Button btnUpdate;
        private Button btnClose;
        private TextBox txtOrderId;
        private TextBox txtMemberId;
        private DateTimePicker txtOrderDate;
        private DateTimePicker txtRequiredDate;
        private DateTimePicker txtShippedDate;
    }
}