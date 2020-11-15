namespace Poppel_Ordering_System.Presentation_Layer
{
    partial class CustomerMDIParent
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
            this.POSLabel = new System.Windows.Forms.Label();
            this.createCustomer = new System.Windows.Forms.Button();
            this.createCustomerOrder = new System.Windows.Forms.Button();
            this.cancelItemButton = new System.Windows.Forms.Button();
            this.welcomePoppelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // POSLabel
            // 
            this.POSLabel.AutoSize = true;
            this.POSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSLabel.Location = new System.Drawing.Point(237, -1);
            this.POSLabel.Name = "POSLabel";
            this.POSLabel.Size = new System.Drawing.Size(308, 31);
            this.POSLabel.TabIndex = 0;
            this.POSLabel.Text = "Poppel Ordering System";
            this.POSLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.POSLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // createCustomer
            // 
            this.createCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustomer.Location = new System.Drawing.Point(222, 110);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new System.Drawing.Size(336, 34);
            this.createCustomer.TabIndex = 1;
            this.createCustomer.Text = "Create A Customer";
            this.createCustomer.UseVisualStyleBackColor = true;
            // 
            // createCustomerOrder
            // 
            this.createCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustomerOrder.Location = new System.Drawing.Point(222, 175);
            this.createCustomerOrder.Name = "createCustomerOrder";
            this.createCustomerOrder.Size = new System.Drawing.Size(336, 34);
            this.createCustomerOrder.TabIndex = 2;
            this.createCustomerOrder.Text = "Create A Customer Order";
            this.createCustomerOrder.UseVisualStyleBackColor = true;
            this.createCustomerOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelItemButton
            // 
            this.cancelItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelItemButton.Location = new System.Drawing.Point(222, 239);
            this.cancelItemButton.Name = "cancelItemButton";
            this.cancelItemButton.Size = new System.Drawing.Size(336, 34);
            this.cancelItemButton.TabIndex = 3;
            this.cancelItemButton.Text = "Cancel Item";
            this.cancelItemButton.UseVisualStyleBackColor = true;
            // 
            // welcomePoppelLabel
            // 
            this.welcomePoppelLabel.AutoSize = true;
            this.welcomePoppelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomePoppelLabel.Location = new System.Drawing.Point(218, 61);
            this.welcomePoppelLabel.Name = "welcomePoppelLabel";
            this.welcomePoppelLabel.Size = new System.Drawing.Size(358, 24);
            this.welcomePoppelLabel.TabIndex = 4;
            this.welcomePoppelLabel.Text = "Welcome to the Poppel Ordering System!";
            this.welcomePoppelLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // CustomerMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomePoppelLabel);
            this.Controls.Add(this.cancelItemButton);
            this.Controls.Add(this.createCustomerOrder);
            this.Controls.Add(this.createCustomer);
            this.Controls.Add(this.POSLabel);
            this.Name = "CustomerMDIParent";
            this.Text = "CustomerMDIParent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label POSLabel;
        private System.Windows.Forms.Button createCustomer;
        private System.Windows.Forms.Button createCustomerOrder;
        private System.Windows.Forms.Button cancelItemButton;
        private System.Windows.Forms.Label welcomePoppelLabel;
    }
}