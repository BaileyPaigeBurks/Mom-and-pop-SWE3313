
namespace Project
{
    partial class Form2
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
            this.lbCart = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SubTotalListView = new System.Windows.Forms.ListView();
            this.Pizza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PizzaPrice = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.taxPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCart
            // 
            this.lbCart.AutoSize = true;
            this.lbCart.Location = new System.Drawing.Point(89, 9);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(36, 13);
            this.lbCart.TabIndex = 0;
            this.lbCart.Text = "CART";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(12, 347);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(187, 46);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // SubTotalListView
            // 
            this.SubTotalListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pizza,
            this.PriceHeader});
            this.SubTotalListView.HideSelection = false;
            this.SubTotalListView.Location = new System.Drawing.Point(12, 27);
            this.SubTotalListView.Name = "SubTotalListView";
            this.SubTotalListView.Size = new System.Drawing.Size(187, 215);
            this.SubTotalListView.TabIndex = 4;
            this.SubTotalListView.UseCompatibleStateImageBehavior = false;
            this.SubTotalListView.View = System.Windows.Forms.View.Details;
            // 
            // Pizza
            // 
            this.Pizza.Text = "Pizza";
            this.Pizza.Width = 115;
            // 
            // PriceHeader
            // 
            this.PriceHeader.Text = "Price";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(13, 262);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(58, 13);
            this.lb.TabIndex = 5;
            this.lb.Text = "Sub total - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total -";
            // 
            // PizzaPrice
            // 
            this.PizzaPrice.AutoSize = true;
            this.PizzaPrice.Location = new System.Drawing.Point(164, 262);
            this.PizzaPrice.Name = "PizzaPrice";
            this.PizzaPrice.Size = new System.Drawing.Size(34, 13);
            this.PizzaPrice.TabIndex = 8;
            this.PizzaPrice.Text = "$0.00";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(164, 309);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(34, 13);
            this.TotalPrice.TabIndex = 9;
            this.TotalPrice.Text = "$0.00";
            // 
            // taxPriceLabel
            // 
            this.taxPriceLabel.AutoSize = true;
            this.taxPriceLabel.Location = new System.Drawing.Point(164, 284);
            this.taxPriceLabel.Name = "taxPriceLabel";
            this.taxPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.taxPriceLabel.TabIndex = 10;
            this.taxPriceLabel.Text = "$0.00";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 399);
            this.Controls.Add(this.taxPriceLabel);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.PizzaPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.SubTotalListView);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.lbCart);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCart;
        private System.Windows.Forms.Button confirm;
        public System.Windows.Forms.ListView SubTotalListView;
        private System.Windows.Forms.ColumnHeader Pizza;
        private System.Windows.Forms.ColumnHeader PriceHeader;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PizzaPrice;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label taxPriceLabel;
    }
}