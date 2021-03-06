
namespace ClothingShopManagementSystem.App
{
    partial class Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtInventorySearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInventoryCrud = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInventoryAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btninventoryEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventoryDelete = new Guna.UI2.WinForms.Guna2Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dgvProductDetails = new MetroFramework.Controls.MetroGrid();
            this.stockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holeSaleUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pnlInventoryCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInventorySearch
            // 
            this.txtInventorySearch.BorderRadius = 20;
            this.txtInventorySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventorySearch.DefaultText = "";
            this.txtInventorySearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInventorySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInventorySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventorySearch.DisabledState.Parent = this.txtInventorySearch;
            this.txtInventorySearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventorySearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtInventorySearch.FocusedState.Parent = this.txtInventorySearch;
            this.txtInventorySearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventorySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtInventorySearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtInventorySearch.HoverState.Parent = this.txtInventorySearch;
            this.txtInventorySearch.Location = new System.Drawing.Point(124, 56);
            this.txtInventorySearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInventorySearch.Name = "txtInventorySearch";
            this.txtInventorySearch.PasswordChar = '\0';
            this.txtInventorySearch.PlaceholderText = "Search by product name or code or category";
            this.txtInventorySearch.SelectedText = "";
            this.txtInventorySearch.ShadowDecoration.Parent = this.txtInventorySearch;
            this.txtInventorySearch.Size = new System.Drawing.Size(694, 36);
            this.txtInventorySearch.TabIndex = 0;
            this.txtInventorySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInventorySearch.TextChanged += new System.EventHandler(this.txtInventorySearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(336, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product name or code category";
            // 
            // pnlInventoryCrud
            // 
            this.pnlInventoryCrud.Controls.Add(this.btnInventoryAdd);
            this.pnlInventoryCrud.Controls.Add(this.btninventoryEdit);
            this.pnlInventoryCrud.Controls.Add(this.btnInventoryDelete);
            this.pnlInventoryCrud.Location = new System.Drawing.Point(200, 592);
            this.pnlInventoryCrud.Name = "pnlInventoryCrud";
            this.pnlInventoryCrud.Size = new System.Drawing.Size(542, 79);
            this.pnlInventoryCrud.TabIndex = 8;
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.BorderRadius = 30;
            this.btnInventoryAdd.CheckedState.Parent = this.btnInventoryAdd;
            this.btnInventoryAdd.CustomImages.Parent = this.btnInventoryAdd;
            this.btnInventoryAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryAdd.ForeColor = System.Drawing.Color.White;
            this.btnInventoryAdd.HoverState.Parent = this.btnInventoryAdd;
            this.btnInventoryAdd.Location = new System.Drawing.Point(3, 3);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.ShadowDecoration.Parent = this.btnInventoryAdd;
            this.btnInventoryAdd.Size = new System.Drawing.Size(172, 63);
            this.btnInventoryAdd.TabIndex = 0;
            this.btnInventoryAdd.Text = "Add";
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click);
            // 
            // btninventoryEdit
            // 
            this.btninventoryEdit.BorderRadius = 30;
            this.btninventoryEdit.CheckedState.Parent = this.btninventoryEdit;
            this.btninventoryEdit.CustomImages.Parent = this.btninventoryEdit;
            this.btninventoryEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventoryEdit.ForeColor = System.Drawing.Color.White;
            this.btninventoryEdit.HoverState.Parent = this.btninventoryEdit;
            this.btninventoryEdit.Location = new System.Drawing.Point(181, 3);
            this.btninventoryEdit.Name = "btninventoryEdit";
            this.btninventoryEdit.ShadowDecoration.Parent = this.btninventoryEdit;
            this.btninventoryEdit.Size = new System.Drawing.Size(172, 63);
            this.btninventoryEdit.TabIndex = 1;
            this.btninventoryEdit.Text = "Edit";
            this.btninventoryEdit.Click += new System.EventHandler(this.btninventoryEdit_Click);
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.BorderRadius = 30;
            this.btnInventoryDelete.CheckedState.Parent = this.btnInventoryDelete;
            this.btnInventoryDelete.CustomImages.Parent = this.btnInventoryDelete;
            this.btnInventoryDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.btnInventoryDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryDelete.ForeColor = System.Drawing.Color.White;
            this.btnInventoryDelete.HoverState.Parent = this.btnInventoryDelete;
            this.btnInventoryDelete.Location = new System.Drawing.Point(359, 3);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.ShadowDecoration.Parent = this.btnInventoryDelete;
            this.btnInventoryDelete.Size = new System.Drawing.Size(172, 63);
            this.btnInventoryDelete.TabIndex = 2;
            this.btnInventoryDelete.Text = "Delete";
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(903, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 38);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.AllowUserToResizeColumns = false;
            this.dgvProductDetails.AllowUserToResizeRows = false;
            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockDate,
            this.Id,
            this.productCode,
            this.name,
            this.companyName,
            this.size,
            this.quantity,
            this.holeSaleUnitPrice,
            this.retailUnitPrice,
            this.discountAmount,
            this.category});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductDetails.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductDetails.EnableHeadersVisualStyles = false;
            this.dgvProductDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductDetails.Location = new System.Drawing.Point(31, 151);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductDetails.RowHeadersWidth = 51;
            this.dgvProductDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductDetails.RowTemplate.Height = 24;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(880, 435);
            this.dgvProductDetails.TabIndex = 16;
            // 
            // stockDate
            // 
            this.stockDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockDate.DataPropertyName = "stockDate";
            this.stockDate.FillWeight = 74.97542F;
            this.stockDate.HeaderText = "Stock Date";
            this.stockDate.MinimumWidth = 6;
            this.stockDate.Name = "stockDate";
            this.stockDate.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // productCode
            // 
            this.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCode.DataPropertyName = "productCode";
            this.productCode.FillWeight = 46.33061F;
            this.productCode.HeaderText = "Code";
            this.productCode.MinimumWidth = 6;
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 60F;
            this.name.HeaderText = "Product Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // companyName
            // 
            this.companyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyName.DataPropertyName = "companyName";
            this.companyName.FillWeight = 46.33061F;
            this.companyName.HeaderText = "Brand name";
            this.companyName.MinimumWidth = 6;
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.size.DataPropertyName = "size";
            this.size.FillWeight = 40F;
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 40F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // holeSaleUnitPrice
            // 
            this.holeSaleUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.holeSaleUnitPrice.DataPropertyName = "holeSaleUnitPrice";
            this.holeSaleUnitPrice.FillWeight = 46.33061F;
            this.holeSaleUnitPrice.HeaderText = "Cost price";
            this.holeSaleUnitPrice.MinimumWidth = 6;
            this.holeSaleUnitPrice.Name = "holeSaleUnitPrice";
            this.holeSaleUnitPrice.ReadOnly = true;
            // 
            // retailUnitPrice
            // 
            this.retailUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.retailUnitPrice.DataPropertyName = "retailUnitPrice";
            this.retailUnitPrice.FillWeight = 46.33061F;
            this.retailUnitPrice.HeaderText = "Retail price";
            this.retailUnitPrice.MinimumWidth = 6;
            this.retailUnitPrice.Name = "retailUnitPrice";
            this.retailUnitPrice.ReadOnly = true;
            // 
            // discountAmount
            // 
            this.discountAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discountAmount.DataPropertyName = "discountAmount";
            this.discountAmount.FillWeight = 46.33061F;
            this.discountAmount.HeaderText = "Discount";
            this.discountAmount.MinimumWidth = 6;
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 46.33061F;
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(235)))), ((int)(((byte)(180)))));
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(299, 101);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(344, 40);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvProductDetails);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pnlInventoryCrud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInventorySearch);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(943, 671);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.pnlInventoryCrud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtInventorySearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnInventoryAdd;
        private Guna.UI2.WinForms.Guna2Button btninventoryEdit;
        private Guna.UI2.WinForms.Guna2Button btnInventoryDelete;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.FlowLayoutPanel pnlInventoryCrud;
        private MetroFramework.Controls.MetroGrid dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn holeSaleUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
