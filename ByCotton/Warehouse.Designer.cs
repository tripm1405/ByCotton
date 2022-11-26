using System.Windows.Forms;

namespace ByCotton
{
    partial class Warehouse
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.clearProductButton = new System.Windows.Forms.Button();
            this.doneProductButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.getProduct = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.productsListView = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearProductsbutton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(807, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(105, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "ĐĂNG XUẤT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(25, 75);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(105, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "SỬA SP";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(25, 105);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(531, 255);
            this.productsDataGridView.TabIndex = 3;
            // 
            // clearProductButton
            // 
            this.clearProductButton.Location = new System.Drawing.Point(701, 275);
            this.clearProductButton.Name = "clearProductButton";
            this.clearProductButton.Size = new System.Drawing.Size(95, 23);
            this.clearProductButton.TabIndex = 15;
            this.clearProductButton.Text = "ĐẶT LẠI";
            this.clearProductButton.UseVisualStyleBackColor = true;
            this.clearProductButton.Click += new System.EventHandler(this.clearProductButton_Click);
            // 
            // doneProductButton
            // 
            this.doneProductButton.Location = new System.Drawing.Point(802, 275);
            this.doneProductButton.Name = "doneProductButton";
            this.doneProductButton.Size = new System.Drawing.Size(96, 23);
            this.doneProductButton.TabIndex = 14;
            this.doneProductButton.Text = "THÊM SP";
            this.doneProductButton.UseVisualStyleBackColor = true;
            this.doneProductButton.Click += new System.EventHandler(this.doneProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "GIÁ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "SỐ LƯỢNG:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(701, 237);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(197, 22);
            this.priceNumericUpDown.TabIndex = 11;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(701, 200);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(197, 22);
            this.amountNumericUpDown.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(701, 162);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(197, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "TÊN:";
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(136, 75);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(105, 23);
            this.deleteProductButton.TabIndex = 16;
            this.deleteProductButton.Text = "XÓA SP";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // getProduct
            // 
            this.getProduct.Location = new System.Drawing.Point(25, 366);
            this.getProduct.Name = "getProduct";
            this.getProduct.Size = new System.Drawing.Size(154, 23);
            this.getProduct.TabIndex = 17;
            this.getProduct.Text = "THÊM SP VÀO HĐ";
            this.getProduct.UseVisualStyleBackColor = true;
            this.getProduct.Click += new System.EventHandler(this.getProduct_Click);
            // 
            // removeProductButton
            // 
            this.removeProductButton.Location = new System.Drawing.Point(185, 366);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(154, 23);
            this.removeProductButton.TabIndex = 18;
            this.removeProductButton.Text = "XÓA SP KHỎI HĐ";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(701, 532);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(154, 23);
            this.printButton.TabIndex = 19;
            this.printButton.Text = "IN HĐ";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.name,
            this.amount,
            this.price});
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(25, 395);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(531, 299);
            this.productsListView.TabIndex = 20;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            // 
            // code
            // 
            this.code.Text = "code";
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 180;
            // 
            // amount
            // 
            this.amount.Text = "amount";
            // 
            // price
            // 
            this.price.Text = "price";
            this.price.Width = 80;
            // 
            // clearProductsbutton
            // 
            this.clearProductsbutton.Location = new System.Drawing.Point(345, 366);
            this.clearProductsbutton.Name = "clearProductsbutton";
            this.clearProductsbutton.Size = new System.Drawing.Size(154, 23);
            this.clearProductsbutton.TabIndex = 21;
            this.clearProductsbutton.Text = "ĐẶT LẠI HĐ";
            this.clearProductsbutton.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(701, 504);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(197, 22);
            this.phoneTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "SỐ ĐIỆN THOẠI:";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 706);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.clearProductsbutton);
            this.Controls.Add(this.productsListView);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.getProduct);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.clearProductButton);
            this.Controls.Add(this.doneProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.Shown += new System.EventHandler(this.Warehouse_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private Button clearProductButton;
        private Button doneProductButton;
        private Label label3;
        private Label label2;
        private NumericUpDown priceNumericUpDown;
        private NumericUpDown amountNumericUpDown;
        private TextBox nameTextBox;
        private Label label1;
        private Button deleteProductButton;
        private Button getProduct;
        private Button removeProductButton;
        private Button printButton;
        private ListView productsListView;
        private Button clearProductsbutton;
        private TextBox phoneTextBox;
        private Label label4;
        private ColumnHeader code;
        private ColumnHeader name;
        private ColumnHeader amount;
        private ColumnHeader price;
    }
}