namespace SEN381
{
    partial class Products
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblProducts = new MaterialSkin.Controls.MaterialLabel();
            this.lblSensors = new MaterialSkin.Controls.MaterialLabel();
            this.lblControllers = new MaterialSkin.Controls.MaterialLabel();
            this.lblActors = new MaterialSkin.Controls.MaterialLabel();
            this.dgView_Sensors = new System.Windows.Forms.DataGridView();
            this.dgView_Controllers = new System.Windows.Forms.DataGridView();
            this.lsBox_products = new System.Windows.Forms.ListBox();
            this.dgView_Actors = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpAddProducts = new System.Windows.Forms.GroupBox();
            this.txtCost_Insert = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComponentName_Insert = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSubmitNewProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblType = new MaterialSkin.Controls.MaterialLabel();
            this.cb_ProductGroup_Insert = new System.Windows.Forms.ComboBox();
            this.cb_ComponentType_Insert = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbProductName_Update = new System.Windows.Forms.ComboBox();
            this.lblSearchName_Update = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCost_Update = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtComponentName_Update = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cbProductGroup_Update = new System.Windows.Forms.ComboBox();
            this.cb_ComponentType_Update = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbProductName_Delete = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sensors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Controllers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Actors)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gpAddProducts.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(994, 830);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage1.Controls.Add(this.lblProducts);
            this.tabPage1.Controls.Add(this.lblSensors);
            this.tabPage1.Controls.Add(this.lblControllers);
            this.tabPage1.Controls.Add(this.lblActors);
            this.tabPage1.Controls.Add(this.dgView_Sensors);
            this.tabPage1.Controls.Add(this.dgView_Controllers);
            this.tabPage1.Controls.Add(this.lsBox_products);
            this.tabPage1.Controls.Add(this.dgView_Actors);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 804);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Products";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Depth = 0;
            this.lblProducts.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProducts.Location = new System.Drawing.Point(6, 15);
            this.lblProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(69, 19);
            this.lblProducts.TabIndex = 7;
            this.lblProducts.Text = "Products";
            // 
            // lblSensors
            // 
            this.lblSensors.AutoSize = true;
            this.lblSensors.Depth = 0;
            this.lblSensors.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSensors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSensors.Location = new System.Drawing.Point(253, 334);
            this.lblSensors.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSensors.Name = "lblSensors";
            this.lblSensors.Size = new System.Drawing.Size(64, 19);
            this.lblSensors.TabIndex = 6;
            this.lblSensors.Text = "Sensors";
            // 
            // lblControllers
            // 
            this.lblControllers.AutoSize = true;
            this.lblControllers.Depth = 0;
            this.lblControllers.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblControllers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblControllers.Location = new System.Drawing.Point(253, 176);
            this.lblControllers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblControllers.Name = "lblControllers";
            this.lblControllers.Size = new System.Drawing.Size(84, 19);
            this.lblControllers.TabIndex = 5;
            this.lblControllers.Text = "Controllers";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Depth = 0;
            this.lblActors.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblActors.Location = new System.Drawing.Point(253, 15);
            this.lblActors.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(54, 19);
            this.lblActors.TabIndex = 4;
            this.lblActors.Text = "Actors";
            // 
            // dgView_Sensors
            // 
            this.dgView_Sensors.AllowUserToAddRows = false;
            this.dgView_Sensors.AllowUserToDeleteRows = false;
            this.dgView_Sensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Sensors.Location = new System.Drawing.Point(257, 365);
            this.dgView_Sensors.Name = "dgView_Sensors";
            this.dgView_Sensors.ReadOnly = true;
            this.dgView_Sensors.Size = new System.Drawing.Size(723, 113);
            this.dgView_Sensors.TabIndex = 3;
            // 
            // dgView_Controllers
            // 
            this.dgView_Controllers.AllowUserToAddRows = false;
            this.dgView_Controllers.AllowUserToDeleteRows = false;
            this.dgView_Controllers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Controllers.Location = new System.Drawing.Point(257, 209);
            this.dgView_Controllers.Name = "dgView_Controllers";
            this.dgView_Controllers.ReadOnly = true;
            this.dgView_Controllers.Size = new System.Drawing.Size(723, 113);
            this.dgView_Controllers.TabIndex = 2;
            // 
            // lsBox_products
            // 
            this.lsBox_products.BackColor = System.Drawing.Color.Silver;
            this.lsBox_products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsBox_products.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBox_products.FormattingEnabled = true;
            this.lsBox_products.ItemHeight = 16;
            this.lsBox_products.Location = new System.Drawing.Point(6, 45);
            this.lsBox_products.Name = "lsBox_products";
            this.lsBox_products.Size = new System.Drawing.Size(241, 434);
            this.lsBox_products.TabIndex = 1;
            this.lsBox_products.SelectedIndexChanged += new System.EventHandler(this.lsBox_products_SelectedIndexChanged);
            // 
            // dgView_Actors
            // 
            this.dgView_Actors.AllowUserToAddRows = false;
            this.dgView_Actors.AllowUserToDeleteRows = false;
            this.dgView_Actors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Actors.Location = new System.Drawing.Point(257, 47);
            this.dgView_Actors.Name = "dgView_Actors";
            this.dgView_Actors.ReadOnly = true;
            this.dgView_Actors.Size = new System.Drawing.Size(723, 117);
            this.dgView_Actors.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage2.Controls.Add(this.gpAddProducts);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 804);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Products";
            // 
            // gpAddProducts
            // 
            this.gpAddProducts.Controls.Add(this.txtCost_Insert);
            this.gpAddProducts.Controls.Add(this.materialLabel6);
            this.gpAddProducts.Controls.Add(this.txtComponentName_Insert);
            this.gpAddProducts.Controls.Add(this.materialLabel1);
            this.gpAddProducts.Controls.Add(this.btnSubmitNewProduct);
            this.gpAddProducts.Controls.Add(this.lblName);
            this.gpAddProducts.Controls.Add(this.lblType);
            this.gpAddProducts.Controls.Add(this.cb_ProductGroup_Insert);
            this.gpAddProducts.Controls.Add(this.cb_ComponentType_Insert);
            this.gpAddProducts.Location = new System.Drawing.Point(25, 6);
            this.gpAddProducts.Name = "gpAddProducts";
            this.gpAddProducts.Size = new System.Drawing.Size(337, 286);
            this.gpAddProducts.TabIndex = 8;
            this.gpAddProducts.TabStop = false;
            // 
            // txtCost_Insert
            // 
            this.txtCost_Insert.Depth = 0;
            this.txtCost_Insert.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost_Insert.Hint = "Enter Component Cost";
            this.txtCost_Insert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCost_Insert.Location = new System.Drawing.Point(117, 179);
            this.txtCost_Insert.MaxLength = 32767;
            this.txtCost_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCost_Insert.Name = "txtCost_Insert";
            this.txtCost_Insert.PasswordChar = '\0';
            this.txtCost_Insert.SelectedText = "";
            this.txtCost_Insert.SelectionLength = 0;
            this.txtCost_Insert.SelectionStart = 0;
            this.txtCost_Insert.Size = new System.Drawing.Size(200, 23);
            this.txtCost_Insert.TabIndex = 14;
            this.txtCost_Insert.TabStop = false;
            this.txtCost_Insert.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 179);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(41, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Cost";
            // 
            // txtComponentName_Insert
            // 
            this.txtComponentName_Insert.Depth = 0;
            this.txtComponentName_Insert.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponentName_Insert.Hint = "Enter Component Name";
            this.txtComponentName_Insert.Location = new System.Drawing.Point(117, 88);
            this.txtComponentName_Insert.MaxLength = 32767;
            this.txtComponentName_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComponentName_Insert.Name = "txtComponentName_Insert";
            this.txtComponentName_Insert.PasswordChar = '\0';
            this.txtComponentName_Insert.SelectedText = "";
            this.txtComponentName_Insert.SelectionLength = 0;
            this.txtComponentName_Insert.SelectionStart = 0;
            this.txtComponentName_Insert.Size = new System.Drawing.Size(200, 23);
            this.txtComponentName_Insert.TabIndex = 12;
            this.txtComponentName_Insert.TabStop = false;
            this.txtComponentName_Insert.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Product Group";
            // 
            // btnSubmitNewProduct
            // 
            this.btnSubmitNewProduct.AutoSize = true;
            this.btnSubmitNewProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmitNewProduct.Depth = 0;
            this.btnSubmitNewProduct.Icon = null;
            this.btnSubmitNewProduct.Location = new System.Drawing.Point(117, 225);
            this.btnSubmitNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmitNewProduct.Name = "btnSubmitNewProduct";
            this.btnSubmitNewProduct.Primary = true;
            this.btnSubmitNewProduct.Size = new System.Drawing.Size(71, 36);
            this.btnSubmitNewProduct.TabIndex = 7;
            this.btnSubmitNewProduct.Text = "Submit";
            this.btnSubmitNewProduct.UseVisualStyleBackColor = true;
            this.btnSubmitNewProduct.Click += new System.EventHandler(this.btnSubmitNewProduct_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(6, 88);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Depth = 0;
            this.lblType.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblType.Location = new System.Drawing.Point(6, 134);
            this.lblType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(41, 19);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // cb_ProductGroup_Insert
            // 
            this.cb_ProductGroup_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_ProductGroup_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ProductGroup_Insert.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ProductGroup_Insert.ForeColor = System.Drawing.Color.White;
            this.cb_ProductGroup_Insert.FormattingEnabled = true;
            this.cb_ProductGroup_Insert.Location = new System.Drawing.Point(117, 44);
            this.cb_ProductGroup_Insert.Name = "cb_ProductGroup_Insert";
            this.cb_ProductGroup_Insert.Size = new System.Drawing.Size(200, 24);
            this.cb_ProductGroup_Insert.TabIndex = 5;
            this.cb_ProductGroup_Insert.SelectedIndexChanged += new System.EventHandler(this.cb_ProductGroup_SelectedIndexChanged);
            // 
            // cb_ComponentType_Insert
            // 
            this.cb_ComponentType_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_ComponentType_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ComponentType_Insert.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ComponentType_Insert.ForeColor = System.Drawing.Color.White;
            this.cb_ComponentType_Insert.FormattingEnabled = true;
            this.cb_ComponentType_Insert.Items.AddRange(new object[] {
            "Controller",
            "Sensor",
            "Actor"});
            this.cb_ComponentType_Insert.Location = new System.Drawing.Point(117, 134);
            this.cb_ComponentType_Insert.Name = "cb_ComponentType_Insert";
            this.cb_ComponentType_Insert.Size = new System.Drawing.Size(200, 24);
            this.cb_ComponentType_Insert.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage3.Controls.Add(this.cbProductName_Update);
            this.tabPage3.Controls.Add(this.lblSearchName_Update);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 804);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Products";
            // 
            // cbProductName_Update
            // 
            this.cbProductName_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbProductName_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProductName_Update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductName_Update.ForeColor = System.Drawing.Color.White;
            this.cbProductName_Update.FormattingEnabled = true;
            this.cbProductName_Update.Location = new System.Drawing.Point(142, 37);
            this.cbProductName_Update.Name = "cbProductName_Update";
            this.cbProductName_Update.Size = new System.Drawing.Size(200, 24);
            this.cbProductName_Update.TabIndex = 13;
            this.cbProductName_Update.SelectedIndexChanged += new System.EventHandler(this.cbProductName_Update_SelectedIndexChanged);
            // 
            // lblSearchName_Update
            // 
            this.lblSearchName_Update.AutoSize = true;
            this.lblSearchName_Update.Depth = 0;
            this.lblSearchName_Update.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearchName_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchName_Update.Location = new System.Drawing.Point(21, 37);
            this.lblSearchName_Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchName_Update.Name = "lblSearchName_Update";
            this.lblSearchName_Update.Size = new System.Drawing.Size(105, 19);
            this.lblSearchName_Update.TabIndex = 10;
            this.lblSearchName_Update.Text = "Product Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCost_Update);
            this.groupBox1.Controls.Add(this.txtComponentName_Update);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.cbProductGroup_Update);
            this.groupBox1.Controls.Add(this.cb_ComponentType_Update);
            this.groupBox1.Location = new System.Drawing.Point(25, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 283);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtCost_Update
            // 
            this.txtCost_Update.Depth = 0;
            this.txtCost_Update.Hint = "Edit Cost";
            this.txtCost_Update.Location = new System.Drawing.Point(117, 178);
            this.txtCost_Update.MaxLength = 32767;
            this.txtCost_Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCost_Update.Name = "txtCost_Update";
            this.txtCost_Update.PasswordChar = '\0';
            this.txtCost_Update.SelectedText = "";
            this.txtCost_Update.SelectionLength = 0;
            this.txtCost_Update.SelectionStart = 0;
            this.txtCost_Update.Size = new System.Drawing.Size(200, 23);
            this.txtCost_Update.TabIndex = 15;
            this.txtCost_Update.TabStop = false;
            this.txtCost_Update.UseSystemPasswordChar = false;
            // 
            // txtComponentName_Update
            // 
            this.txtComponentName_Update.Depth = 0;
            this.txtComponentName_Update.Hint = "Edit Component Name";
            this.txtComponentName_Update.Location = new System.Drawing.Point(117, 93);
            this.txtComponentName_Update.MaxLength = 32767;
            this.txtComponentName_Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComponentName_Update.Name = "txtComponentName_Update";
            this.txtComponentName_Update.PasswordChar = '\0';
            this.txtComponentName_Update.SelectedText = "";
            this.txtComponentName_Update.SelectionLength = 0;
            this.txtComponentName_Update.SelectionStart = 0;
            this.txtComponentName_Update.Size = new System.Drawing.Size(200, 23);
            this.txtComponentName_Update.TabIndex = 12;
            this.txtComponentName_Update.TabStop = false;
            this.txtComponentName_Update.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 178);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(41, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Cost";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Product Group";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(117, 223);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(73, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 93);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 134);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Type";
            // 
            // cbProductGroup_Update
            // 
            this.cbProductGroup_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbProductGroup_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProductGroup_Update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductGroup_Update.ForeColor = System.Drawing.Color.White;
            this.cbProductGroup_Update.FormattingEnabled = true;
            this.cbProductGroup_Update.Location = new System.Drawing.Point(117, 44);
            this.cbProductGroup_Update.Name = "cbProductGroup_Update";
            this.cbProductGroup_Update.Size = new System.Drawing.Size(200, 24);
            this.cbProductGroup_Update.TabIndex = 5;
            // 
            // cb_ComponentType_Update
            // 
            this.cb_ComponentType_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_ComponentType_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ComponentType_Update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ComponentType_Update.ForeColor = System.Drawing.Color.White;
            this.cb_ComponentType_Update.FormattingEnabled = true;
            this.cb_ComponentType_Update.Items.AddRange(new object[] {
            "Controller",
            "Sensor",
            "Actor"});
            this.cb_ComponentType_Update.Location = new System.Drawing.Point(117, 134);
            this.cb_ComponentType_Update.Name = "cb_ComponentType_Update";
            this.cb_ComponentType_Update.Size = new System.Drawing.Size(200, 24);
            this.cb_ComponentType_Update.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage4.Controls.Add(this.cbProductName_Delete);
            this.tabPage4.Controls.Add(this.btnDeleteProduct);
            this.tabPage4.Controls.Add(this.materialLabel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(986, 804);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Products";
            // 
            // cbProductName_Delete
            // 
            this.cbProductName_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbProductName_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProductName_Delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductName_Delete.ForeColor = System.Drawing.Color.White;
            this.cbProductName_Delete.FormattingEnabled = true;
            this.cbProductName_Delete.Location = new System.Drawing.Point(142, 37);
            this.cbProductName_Delete.Name = "cbProductName_Delete";
            this.cbProductName_Delete.Size = new System.Drawing.Size(200, 24);
            this.cbProductName_Delete.TabIndex = 17;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.AutoSize = true;
            this.btnDeleteProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteProduct.Depth = 0;
            this.btnDeleteProduct.Icon = null;
            this.btnDeleteProduct.Location = new System.Drawing.Point(142, 72);
            this.btnDeleteProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Primary = true;
            this.btnDeleteProduct.Size = new System.Drawing.Size(69, 36);
            this.btnDeleteProduct.TabIndex = 16;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(21, 37);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(105, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Product Name";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(7, 15);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(600, 46);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "tabSelector";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(998, 898);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sensors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Controllers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Actors)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gpAddProducts.ResumeLayout(false);
            this.gpAddProducts.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgView_Actors;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private System.Windows.Forms.ComboBox cb_ProductGroup_Insert;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cb_ComponentType_Insert;
        private MaterialSkin.Controls.MaterialLabel lblType;
        private System.Windows.Forms.GroupBox gpAddProducts;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmitNewProduct;
        private MaterialSkin.Controls.MaterialLabel lblSearchName_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cbProductGroup_Update;
        private System.Windows.Forms.ComboBox cb_ComponentType_Update;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComponentName_Update;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComponentName_Insert;
        private System.Windows.Forms.ListBox lsBox_products;
        private System.Windows.Forms.DataGridView dgView_Sensors;
        private System.Windows.Forms.DataGridView dgView_Controllers;
        private MaterialSkin.Controls.MaterialLabel lblSensors;
        private MaterialSkin.Controls.MaterialLabel lblControllers;
        private MaterialSkin.Controls.MaterialLabel lblActors;
        private MaterialSkin.Controls.MaterialLabel lblProducts;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCost_Insert;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cbProductName_Update;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCost_Update;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox cbProductName_Delete;
    }
}
