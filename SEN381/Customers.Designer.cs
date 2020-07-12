namespace SEN381
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.ViewCustomers = new System.Windows.Forms.TabPage();
            this.lblProducts = new MaterialSkin.Controls.MaterialLabel();
            this.lsBox_products = new System.Windows.Forms.ListBox();
            this.lblSensors = new MaterialSkin.Controls.MaterialLabel();
            this.lblControllers = new MaterialSkin.Controls.MaterialLabel();
            this.lblActors = new MaterialSkin.Controls.MaterialLabel();
            this.dgView_Sensors = new System.Windows.Forms.DataGridView();
            this.dgView_Controllers = new System.Windows.Forms.DataGridView();
            this.dgView_Actors = new System.Windows.Forms.DataGridView();
            this.lblCustomers = new MaterialSkin.Controls.MaterialLabel();
            this.dgView_Customers = new System.Windows.Forms.DataGridView();
            this.AddCustomers = new System.Windows.Forms.TabPage();
            this.gpAddCustomer = new System.Windows.Forms.GroupBox();
            this.txtNewBankAccount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNewPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNewAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNewEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNewSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNewName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNewCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.PurchaseProduct = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPurchaseProducts = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClearCart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearchClientName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lsBoxClientNames = new System.Windows.Forms.ListBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.lsBoxPurchaseSensors = new System.Windows.Forms.CheckedListBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lsBoxPurchaseControllers = new System.Windows.Forms.CheckedListBox();
            this.lsBoxPurchaseProducts = new System.Windows.Forms.ListBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lsBoxPurchaseActors = new System.Windows.Forms.CheckedListBox();
            this.UpdateCustomers = new System.Windows.Forms.TabPage();
            this.cbUpdateCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUpdateBank = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUpdateTelephone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUpdateAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUpdateEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUpdateSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUpdateName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSearchName_Update = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteCustomers = new System.Windows.Forms.TabPage();
            this.cbDeleteCustomer = new System.Windows.Forms.ComboBox();
            this.btnDeleteCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnUpdateCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.ViewCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sensors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Controllers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Actors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Customers)).BeginInit();
            this.AddCustomers.SuspendLayout();
            this.gpAddCustomer.SuspendLayout();
            this.PurchaseProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.UpdateCustomers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.DeleteCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.ViewCustomers);
            this.materialTabControl1.Controls.Add(this.AddCustomers);
            this.materialTabControl1.Controls.Add(this.PurchaseProduct);
            this.materialTabControl1.Controls.Add(this.UpdateCustomers);
            this.materialTabControl1.Controls.Add(this.DeleteCustomers);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 41);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(998, 857);
            this.materialTabControl1.TabIndex = 1;
            // 
            // ViewCustomers
            // 
            this.ViewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ViewCustomers.Controls.Add(this.lblProducts);
            this.ViewCustomers.Controls.Add(this.lsBox_products);
            this.ViewCustomers.Controls.Add(this.lblSensors);
            this.ViewCustomers.Controls.Add(this.lblControllers);
            this.ViewCustomers.Controls.Add(this.lblActors);
            this.ViewCustomers.Controls.Add(this.dgView_Sensors);
            this.ViewCustomers.Controls.Add(this.dgView_Controllers);
            this.ViewCustomers.Controls.Add(this.dgView_Actors);
            this.ViewCustomers.Controls.Add(this.lblCustomers);
            this.ViewCustomers.Controls.Add(this.dgView_Customers);
            this.ViewCustomers.Location = new System.Drawing.Point(4, 22);
            this.ViewCustomers.Name = "ViewCustomers";
            this.ViewCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.ViewCustomers.Size = new System.Drawing.Size(990, 831);
            this.ViewCustomers.TabIndex = 0;
            this.ViewCustomers.Text = "View Customers";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Depth = 0;
            this.lblProducts.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProducts.Location = new System.Drawing.Point(6, 325);
            this.lblProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(118, 19);
            this.lblProducts.TabIndex = 23;
            this.lblProducts.Text = "Owned Products";
            // 
            // lsBox_products
            // 
            this.lsBox_products.BackColor = System.Drawing.Color.Silver;
            this.lsBox_products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsBox_products.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBox_products.FormattingEnabled = true;
            this.lsBox_products.ItemHeight = 16;
            this.lsBox_products.Location = new System.Drawing.Point(6, 355);
            this.lsBox_products.Name = "lsBox_products";
            this.lsBox_products.Size = new System.Drawing.Size(241, 434);
            this.lsBox_products.TabIndex = 22;
            this.lsBox_products.SelectedIndexChanged += new System.EventHandler(this.lsBox_products_SelectedIndexChanged);
            // 
            // lblSensors
            // 
            this.lblSensors.AutoSize = true;
            this.lblSensors.Depth = 0;
            this.lblSensors.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSensors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSensors.Location = new System.Drawing.Point(253, 641);
            this.lblSensors.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSensors.Name = "lblSensors";
            this.lblSensors.Size = new System.Drawing.Size(64, 19);
            this.lblSensors.TabIndex = 21;
            this.lblSensors.Text = "Sensors";
            // 
            // lblControllers
            // 
            this.lblControllers.AutoSize = true;
            this.lblControllers.Depth = 0;
            this.lblControllers.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblControllers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblControllers.Location = new System.Drawing.Point(253, 483);
            this.lblControllers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblControllers.Name = "lblControllers";
            this.lblControllers.Size = new System.Drawing.Size(84, 19);
            this.lblControllers.TabIndex = 20;
            this.lblControllers.Text = "Controllers";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Depth = 0;
            this.lblActors.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblActors.Location = new System.Drawing.Point(253, 322);
            this.lblActors.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(54, 19);
            this.lblActors.TabIndex = 19;
            this.lblActors.Text = "Actors";
            // 
            // dgView_Sensors
            // 
            this.dgView_Sensors.AllowUserToAddRows = false;
            this.dgView_Sensors.AllowUserToDeleteRows = false;
            this.dgView_Sensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Sensors.Location = new System.Drawing.Point(257, 672);
            this.dgView_Sensors.Name = "dgView_Sensors";
            this.dgView_Sensors.ReadOnly = true;
            this.dgView_Sensors.Size = new System.Drawing.Size(890, 113);
            this.dgView_Sensors.TabIndex = 18;
            // 
            // dgView_Controllers
            // 
            this.dgView_Controllers.AllowUserToAddRows = false;
            this.dgView_Controllers.AllowUserToDeleteRows = false;
            this.dgView_Controllers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Controllers.Location = new System.Drawing.Point(257, 516);
            this.dgView_Controllers.Name = "dgView_Controllers";
            this.dgView_Controllers.ReadOnly = true;
            this.dgView_Controllers.Size = new System.Drawing.Size(890, 113);
            this.dgView_Controllers.TabIndex = 17;
            // 
            // dgView_Actors
            // 
            this.dgView_Actors.AllowUserToAddRows = false;
            this.dgView_Actors.AllowUserToDeleteRows = false;
            this.dgView_Actors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Actors.Location = new System.Drawing.Point(257, 354);
            this.dgView_Actors.Name = "dgView_Actors";
            this.dgView_Actors.ReadOnly = true;
            this.dgView_Actors.Size = new System.Drawing.Size(890, 117);
            this.dgView_Actors.TabIndex = 16;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Depth = 0;
            this.lblCustomers.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomers.Location = new System.Drawing.Point(6, 3);
            this.lblCustomers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(83, 19);
            this.lblCustomers.TabIndex = 15;
            this.lblCustomers.Text = "Customers";
            // 
            // dgView_Customers
            // 
            this.dgView_Customers.AllowUserToAddRows = false;
            this.dgView_Customers.AllowUserToDeleteRows = false;
            this.dgView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Customers.Location = new System.Drawing.Point(10, 39);
            this.dgView_Customers.Name = "dgView_Customers";
            this.dgView_Customers.ReadOnly = true;
            this.dgView_Customers.Size = new System.Drawing.Size(1137, 272);
            this.dgView_Customers.TabIndex = 8;
            this.dgView_Customers.Click += new System.EventHandler(this.dgView_Customers_Click);
            // 
            // AddCustomers
            // 
            this.AddCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.AddCustomers.Controls.Add(this.gpAddCustomer);
            this.AddCustomers.ForeColor = System.Drawing.Color.White;
            this.AddCustomers.Location = new System.Drawing.Point(4, 22);
            this.AddCustomers.Name = "AddCustomers";
            this.AddCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.AddCustomers.Size = new System.Drawing.Size(990, 831);
            this.AddCustomers.TabIndex = 1;
            this.AddCustomers.Text = "Add Customers";
            // 
            // gpAddCustomer
            // 
            this.gpAddCustomer.Controls.Add(this.txtNewBankAccount);
            this.gpAddCustomer.Controls.Add(this.materialLabel9);
            this.gpAddCustomer.Controls.Add(this.txtNewPhone);
            this.gpAddCustomer.Controls.Add(this.materialLabel8);
            this.gpAddCustomer.Controls.Add(this.txtNewAddress);
            this.gpAddCustomer.Controls.Add(this.materialLabel7);
            this.gpAddCustomer.Controls.Add(this.txtNewEmail);
            this.gpAddCustomer.Controls.Add(this.materialLabel6);
            this.gpAddCustomer.Controls.Add(this.txtNewSurname);
            this.gpAddCustomer.Controls.Add(this.materialLabel1);
            this.gpAddCustomer.Controls.Add(this.txtNewName);
            this.gpAddCustomer.Controls.Add(this.btnNewCustomer);
            this.gpAddCustomer.Controls.Add(this.lblName);
            this.gpAddCustomer.Location = new System.Drawing.Point(6, 6);
            this.gpAddCustomer.Name = "gpAddCustomer";
            this.gpAddCustomer.Size = new System.Drawing.Size(348, 364);
            this.gpAddCustomer.TabIndex = 8;
            this.gpAddCustomer.TabStop = false;
            // 
            // txtNewBankAccount
            // 
            this.txtNewBankAccount.Depth = 0;
            this.txtNewBankAccount.Hint = "Enter Customer Account";
            this.txtNewBankAccount.Location = new System.Drawing.Point(117, 273);
            this.txtNewBankAccount.MaxLength = 32767;
            this.txtNewBankAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewBankAccount.Name = "txtNewBankAccount";
            this.txtNewBankAccount.PasswordChar = '\0';
            this.txtNewBankAccount.SelectedText = "";
            this.txtNewBankAccount.SelectionLength = 0;
            this.txtNewBankAccount.SelectionStart = 0;
            this.txtNewBankAccount.Size = new System.Drawing.Size(200, 23);
            this.txtNewBankAccount.TabIndex = 18;
            this.txtNewBankAccount.TabStop = false;
            this.txtNewBankAccount.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(6, 273);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(102, 19);
            this.materialLabel9.TabIndex = 17;
            this.materialLabel9.Text = "Bank Account";
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Depth = 0;
            this.txtNewPhone.Hint = "Enter Customer Number";
            this.txtNewPhone.Location = new System.Drawing.Point(117, 225);
            this.txtNewPhone.MaxLength = 32767;
            this.txtNewPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.PasswordChar = '\0';
            this.txtNewPhone.SelectedText = "";
            this.txtNewPhone.SelectionLength = 0;
            this.txtNewPhone.SelectionStart = 0;
            this.txtNewPhone.Size = new System.Drawing.Size(200, 23);
            this.txtNewPhone.TabIndex = 16;
            this.txtNewPhone.TabStop = false;
            this.txtNewPhone.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 225);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(79, 19);
            this.materialLabel8.TabIndex = 15;
            this.materialLabel8.Text = "Telephone";
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Depth = 0;
            this.txtNewAddress.Hint = "Enter Customer Address";
            this.txtNewAddress.Location = new System.Drawing.Point(117, 172);
            this.txtNewAddress.MaxLength = 32767;
            this.txtNewAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.PasswordChar = '\0';
            this.txtNewAddress.SelectedText = "";
            this.txtNewAddress.SelectionLength = 0;
            this.txtNewAddress.SelectionStart = 0;
            this.txtNewAddress.Size = new System.Drawing.Size(200, 23);
            this.txtNewAddress.TabIndex = 14;
            this.txtNewAddress.TabStop = false;
            this.txtNewAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 172);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(64, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Address";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Depth = 0;
            this.txtNewEmail.Hint = "Enter Customer Email";
            this.txtNewEmail.Location = new System.Drawing.Point(117, 123);
            this.txtNewEmail.MaxLength = 32767;
            this.txtNewEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.PasswordChar = '\0';
            this.txtNewEmail.SelectedText = "";
            this.txtNewEmail.SelectionLength = 0;
            this.txtNewEmail.SelectionStart = 0;
            this.txtNewEmail.Size = new System.Drawing.Size(200, 23);
            this.txtNewEmail.TabIndex = 12;
            this.txtNewEmail.TabStop = false;
            this.txtNewEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 123);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Email";
            // 
            // txtNewSurname
            // 
            this.txtNewSurname.Depth = 0;
            this.txtNewSurname.Hint = "Enter Customer Surname";
            this.txtNewSurname.Location = new System.Drawing.Point(117, 73);
            this.txtNewSurname.MaxLength = 32767;
            this.txtNewSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewSurname.Name = "txtNewSurname";
            this.txtNewSurname.PasswordChar = '\0';
            this.txtNewSurname.SelectedText = "";
            this.txtNewSurname.SelectionLength = 0;
            this.txtNewSurname.SelectionStart = 0;
            this.txtNewSurname.Size = new System.Drawing.Size(200, 23);
            this.txtNewSurname.TabIndex = 10;
            this.txtNewSurname.TabStop = false;
            this.txtNewSurname.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Surname";
            // 
            // txtNewName
            // 
            this.txtNewName.Depth = 0;
            this.txtNewName.Hint = "Enter Custom Name";
            this.txtNewName.Location = new System.Drawing.Point(117, 19);
            this.txtNewName.MaxLength = 32767;
            this.txtNewName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.PasswordChar = '\0';
            this.txtNewName.SelectedText = "";
            this.txtNewName.SelectionLength = 0;
            this.txtNewName.SelectionStart = 0;
            this.txtNewName.Size = new System.Drawing.Size(200, 23);
            this.txtNewName.TabIndex = 8;
            this.txtNewName.TabStop = false;
            this.txtNewName.UseSystemPasswordChar = false;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.AutoSize = true;
            this.btnNewCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewCustomer.Depth = 0;
            this.btnNewCustomer.Icon = null;
            this.btnNewCustomer.Location = new System.Drawing.Point(117, 316);
            this.btnNewCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Primary = true;
            this.btnNewCustomer.Size = new System.Drawing.Size(71, 36);
            this.btnNewCustomer.TabIndex = 7;
            this.btnNewCustomer.Text = "Submit";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // PurchaseProduct
            // 
            this.PurchaseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PurchaseProduct.Controls.Add(this.groupBox2);
            this.PurchaseProduct.Controls.Add(this.txtSearchClientName);
            this.PurchaseProduct.Controls.Add(this.lsBoxClientNames);
            this.PurchaseProduct.Controls.Add(this.materialLabel10);
            this.PurchaseProduct.Controls.Add(this.lsBoxPurchaseSensors);
            this.PurchaseProduct.Controls.Add(this.materialLabel4);
            this.PurchaseProduct.Controls.Add(this.lsBoxPurchaseControllers);
            this.PurchaseProduct.Controls.Add(this.lsBoxPurchaseProducts);
            this.PurchaseProduct.Controls.Add(this.materialLabel3);
            this.PurchaseProduct.Controls.Add(this.materialLabel2);
            this.PurchaseProduct.Controls.Add(this.lsBoxPurchaseActors);
            this.PurchaseProduct.Location = new System.Drawing.Point(4, 22);
            this.PurchaseProduct.Name = "PurchaseProduct";
            this.PurchaseProduct.Size = new System.Drawing.Size(990, 831);
            this.PurchaseProduct.TabIndex = 4;
            this.PurchaseProduct.Text = "Sales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPurchaseProducts);
            this.groupBox2.Controls.Add(this.btnClearCart);
            this.groupBox2.Location = new System.Drawing.Point(67, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 52);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnPurchaseProducts
            // 
            this.btnPurchaseProducts.AutoSize = true;
            this.btnPurchaseProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPurchaseProducts.Depth = 0;
            this.btnPurchaseProducts.Icon = ((System.Drawing.Image)(resources.GetObject("btnPurchaseProducts.Icon")));
            this.btnPurchaseProducts.Location = new System.Drawing.Point(103, 10);
            this.btnPurchaseProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPurchaseProducts.Name = "btnPurchaseProducts";
            this.btnPurchaseProducts.Primary = true;
            this.btnPurchaseProducts.Size = new System.Drawing.Size(99, 36);
            this.btnPurchaseProducts.TabIndex = 3;
            this.btnPurchaseProducts.Text = "Submit";
            this.btnPurchaseProducts.UseVisualStyleBackColor = true;
            this.btnPurchaseProducts.Click += new System.EventHandler(this.btnPurchaseProducts_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.AutoSize = true;
            this.btnClearCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearCart.Depth = 0;
            this.btnClearCart.Icon = ((System.Drawing.Image)(resources.GetObject("btnClearCart.Icon")));
            this.btnClearCart.Location = new System.Drawing.Point(6, 10);
            this.btnClearCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Primary = true;
            this.btnClearCart.Size = new System.Drawing.Size(91, 36);
            this.btnClearCart.TabIndex = 2;
            this.btnClearCart.Text = "Clear";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // txtSearchClientName
            // 
            this.txtSearchClientName.Depth = 0;
            this.txtSearchClientName.ForeColor = System.Drawing.Color.White;
            this.txtSearchClientName.Hint = "Enter Customer Name";
            this.txtSearchClientName.Location = new System.Drawing.Point(67, 23);
            this.txtSearchClientName.MaxLength = 32767;
            this.txtSearchClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchClientName.Name = "txtSearchClientName";
            this.txtSearchClientName.PasswordChar = '\0';
            this.txtSearchClientName.SelectedText = "";
            this.txtSearchClientName.SelectionLength = 0;
            this.txtSearchClientName.SelectionStart = 0;
            this.txtSearchClientName.Size = new System.Drawing.Size(196, 23);
            this.txtSearchClientName.TabIndex = 1;
            this.txtSearchClientName.TabStop = false;
            this.txtSearchClientName.UseSystemPasswordChar = false;
            this.txtSearchClientName.TextChanged += new System.EventHandler(this.txtSearchClientName_TextChanged);
            // 
            // lsBoxClientNames
            // 
            this.lsBoxClientNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lsBoxClientNames.ForeColor = System.Drawing.Color.White;
            this.lsBoxClientNames.FormattingEnabled = true;
            this.lsBoxClientNames.Location = new System.Drawing.Point(47, 131);
            this.lsBoxClientNames.Name = "lsBoxClientNames";
            this.lsBoxClientNames.Size = new System.Drawing.Size(328, 576);
            this.lsBoxClientNames.TabIndex = 4;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(498, 556);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(68, 19);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "Sensors:";
            // 
            // lsBoxPurchaseSensors
            // 
            this.lsBoxPurchaseSensors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lsBoxPurchaseSensors.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBoxPurchaseSensors.ForeColor = System.Drawing.Color.White;
            this.lsBoxPurchaseSensors.FormattingEnabled = true;
            this.lsBoxPurchaseSensors.Location = new System.Drawing.Point(502, 591);
            this.lsBoxPurchaseSensors.Name = "lsBoxPurchaseSensors";
            this.lsBoxPurchaseSensors.Size = new System.Drawing.Size(370, 116);
            this.lsBoxPurchaseSensors.TabIndex = 8;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(498, 379);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Controllers:";
            // 
            // lsBoxPurchaseControllers
            // 
            this.lsBoxPurchaseControllers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lsBoxPurchaseControllers.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBoxPurchaseControllers.ForeColor = System.Drawing.Color.White;
            this.lsBoxPurchaseControllers.FormattingEnabled = true;
            this.lsBoxPurchaseControllers.Location = new System.Drawing.Point(502, 414);
            this.lsBoxPurchaseControllers.Name = "lsBoxPurchaseControllers";
            this.lsBoxPurchaseControllers.Size = new System.Drawing.Size(370, 116);
            this.lsBoxPurchaseControllers.TabIndex = 7;
            // 
            // lsBoxPurchaseProducts
            // 
            this.lsBoxPurchaseProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lsBoxPurchaseProducts.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBoxPurchaseProducts.ForeColor = System.Drawing.Color.White;
            this.lsBoxPurchaseProducts.FormattingEnabled = true;
            this.lsBoxPurchaseProducts.ItemHeight = 16;
            this.lsBoxPurchaseProducts.Location = new System.Drawing.Point(502, 94);
            this.lsBoxPurchaseProducts.Name = "lsBoxPurchaseProducts";
            this.lsBoxPurchaseProducts.Size = new System.Drawing.Size(370, 84);
            this.lsBoxPurchaseProducts.TabIndex = 5;
            this.lsBoxPurchaseProducts.SelectedIndexChanged += new System.EventHandler(this.lsBoxPurchaseProducts_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(498, 198);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(58, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Actors:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(498, 66);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Products:";
            // 
            // lsBoxPurchaseActors
            // 
            this.lsBoxPurchaseActors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lsBoxPurchaseActors.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBoxPurchaseActors.ForeColor = System.Drawing.Color.White;
            this.lsBoxPurchaseActors.FormattingEnabled = true;
            this.lsBoxPurchaseActors.Location = new System.Drawing.Point(502, 233);
            this.lsBoxPurchaseActors.Name = "lsBoxPurchaseActors";
            this.lsBoxPurchaseActors.Size = new System.Drawing.Size(370, 116);
            this.lsBoxPurchaseActors.TabIndex = 6;
            // 
            // UpdateCustomers
            // 
            this.UpdateCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.UpdateCustomers.Controls.Add(this.btnUpdateCustomer);
            this.UpdateCustomers.Controls.Add(this.cbUpdateCustomer);
            this.UpdateCustomers.Controls.Add(this.groupBox3);
            this.UpdateCustomers.Controls.Add(this.lblSearchName_Update);
            this.UpdateCustomers.Location = new System.Drawing.Point(4, 22);
            this.UpdateCustomers.Name = "UpdateCustomers";
            this.UpdateCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateCustomers.Size = new System.Drawing.Size(990, 831);
            this.UpdateCustomers.TabIndex = 2;
            this.UpdateCustomers.Text = "Update Customers";
            // 
            // cbUpdateCustomer
            // 
            this.cbUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.cbUpdateCustomer.FormattingEnabled = true;
            this.cbUpdateCustomer.Location = new System.Drawing.Point(127, 19);
            this.cbUpdateCustomer.Name = "cbUpdateCustomer";
            this.cbUpdateCustomer.Size = new System.Drawing.Size(200, 21);
            this.cbUpdateCustomer.TabIndex = 21;
            this.cbUpdateCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUpdateBank);
            this.groupBox3.Controls.Add(this.materialLabel14);
            this.groupBox3.Controls.Add(this.txtUpdateTelephone);
            this.groupBox3.Controls.Add(this.materialLabel16);
            this.groupBox3.Controls.Add(this.txtUpdateAddress);
            this.groupBox3.Controls.Add(this.materialLabel17);
            this.groupBox3.Controls.Add(this.txtUpdateEmail);
            this.groupBox3.Controls.Add(this.materialLabel18);
            this.groupBox3.Controls.Add(this.txtUpdateSurname);
            this.groupBox3.Controls.Add(this.materialLabel19);
            this.groupBox3.Controls.Add(this.txtUpdateName);
            this.groupBox3.Controls.Add(this.materialLabel20);
            this.groupBox3.Location = new System.Drawing.Point(10, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 321);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // txtUpdateBank
            // 
            this.txtUpdateBank.Depth = 0;
            this.txtUpdateBank.Hint = "Edit Account";
            this.txtUpdateBank.Location = new System.Drawing.Point(117, 273);
            this.txtUpdateBank.MaxLength = 32767;
            this.txtUpdateBank.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateBank.Name = "txtUpdateBank";
            this.txtUpdateBank.PasswordChar = '\0';
            this.txtUpdateBank.SelectedText = "";
            this.txtUpdateBank.SelectionLength = 0;
            this.txtUpdateBank.SelectionStart = 0;
            this.txtUpdateBank.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateBank.TabIndex = 18;
            this.txtUpdateBank.TabStop = false;
            this.txtUpdateBank.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(6, 273);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(102, 19);
            this.materialLabel14.TabIndex = 17;
            this.materialLabel14.Text = "Bank Account";
            // 
            // txtUpdateTelephone
            // 
            this.txtUpdateTelephone.Depth = 0;
            this.txtUpdateTelephone.Hint = "Edit Telephone";
            this.txtUpdateTelephone.Location = new System.Drawing.Point(117, 225);
            this.txtUpdateTelephone.MaxLength = 32767;
            this.txtUpdateTelephone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateTelephone.Name = "txtUpdateTelephone";
            this.txtUpdateTelephone.PasswordChar = '\0';
            this.txtUpdateTelephone.SelectedText = "";
            this.txtUpdateTelephone.SelectionLength = 0;
            this.txtUpdateTelephone.SelectionStart = 0;
            this.txtUpdateTelephone.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateTelephone.TabIndex = 16;
            this.txtUpdateTelephone.TabStop = false;
            this.txtUpdateTelephone.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(6, 225);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(79, 19);
            this.materialLabel16.TabIndex = 15;
            this.materialLabel16.Text = "Telephone";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Depth = 0;
            this.txtUpdateAddress.Hint = "Edit Address";
            this.txtUpdateAddress.Location = new System.Drawing.Point(117, 172);
            this.txtUpdateAddress.MaxLength = 32767;
            this.txtUpdateAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.PasswordChar = '\0';
            this.txtUpdateAddress.SelectedText = "";
            this.txtUpdateAddress.SelectionLength = 0;
            this.txtUpdateAddress.SelectionStart = 0;
            this.txtUpdateAddress.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateAddress.TabIndex = 14;
            this.txtUpdateAddress.TabStop = false;
            this.txtUpdateAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(6, 172);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(64, 19);
            this.materialLabel17.TabIndex = 13;
            this.materialLabel17.Text = "Address";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Depth = 0;
            this.txtUpdateEmail.Hint = "Edit Email";
            this.txtUpdateEmail.Location = new System.Drawing.Point(117, 123);
            this.txtUpdateEmail.MaxLength = 32767;
            this.txtUpdateEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.PasswordChar = '\0';
            this.txtUpdateEmail.SelectedText = "";
            this.txtUpdateEmail.SelectionLength = 0;
            this.txtUpdateEmail.SelectionStart = 0;
            this.txtUpdateEmail.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateEmail.TabIndex = 12;
            this.txtUpdateEmail.TabStop = false;
            this.txtUpdateEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(6, 123);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(47, 19);
            this.materialLabel18.TabIndex = 11;
            this.materialLabel18.Text = "Email";
            // 
            // txtUpdateSurname
            // 
            this.txtUpdateSurname.Depth = 0;
            this.txtUpdateSurname.Hint = "Edit Surname";
            this.txtUpdateSurname.Location = new System.Drawing.Point(117, 73);
            this.txtUpdateSurname.MaxLength = 32767;
            this.txtUpdateSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateSurname.Name = "txtUpdateSurname";
            this.txtUpdateSurname.PasswordChar = '\0';
            this.txtUpdateSurname.SelectedText = "";
            this.txtUpdateSurname.SelectionLength = 0;
            this.txtUpdateSurname.SelectionStart = 0;
            this.txtUpdateSurname.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateSurname.TabIndex = 10;
            this.txtUpdateSurname.TabStop = false;
            this.txtUpdateSurname.UseSystemPasswordChar = false;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(6, 73);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(68, 19);
            this.materialLabel19.TabIndex = 9;
            this.materialLabel19.Text = "Surname";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Depth = 0;
            this.txtUpdateName.Hint = "Edit Name";
            this.txtUpdateName.Location = new System.Drawing.Point(117, 19);
            this.txtUpdateName.MaxLength = 32767;
            this.txtUpdateName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.PasswordChar = '\0';
            this.txtUpdateName.SelectedText = "";
            this.txtUpdateName.SelectionLength = 0;
            this.txtUpdateName.SelectionStart = 0;
            this.txtUpdateName.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateName.TabIndex = 8;
            this.txtUpdateName.TabStop = false;
            this.txtUpdateName.UseSystemPasswordChar = false;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(6, 19);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(49, 19);
            this.materialLabel20.TabIndex = 0;
            this.materialLabel20.Text = "Name";
            // 
            // lblSearchName_Update
            // 
            this.lblSearchName_Update.AutoSize = true;
            this.lblSearchName_Update.Depth = 0;
            this.lblSearchName_Update.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearchName_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchName_Update.Location = new System.Drawing.Point(6, 18);
            this.lblSearchName_Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchName_Update.Name = "lblSearchName_Update";
            this.lblSearchName_Update.Size = new System.Drawing.Size(119, 19);
            this.lblSearchName_Update.TabIndex = 10;
            this.lblSearchName_Update.Text = "Customer Name";
            // 
            // DeleteCustomers
            // 
            this.DeleteCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DeleteCustomers.Controls.Add(this.cbDeleteCustomer);
            this.DeleteCustomers.Controls.Add(this.btnDeleteCustomer);
            this.DeleteCustomers.Controls.Add(this.materialLabel5);
            this.DeleteCustomers.Location = new System.Drawing.Point(4, 22);
            this.DeleteCustomers.Name = "DeleteCustomers";
            this.DeleteCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteCustomers.Size = new System.Drawing.Size(990, 831);
            this.DeleteCustomers.TabIndex = 3;
            this.DeleteCustomers.Text = "Delete Customers";
            // 
            // cbDeleteCustomer
            // 
            this.cbDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.cbDeleteCustomer.FormattingEnabled = true;
            this.cbDeleteCustomer.Location = new System.Drawing.Point(127, 17);
            this.cbDeleteCustomer.Name = "cbDeleteCustomer";
            this.cbDeleteCustomer.Size = new System.Drawing.Size(200, 21);
            this.cbDeleteCustomer.TabIndex = 22;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.AutoSize = true;
            this.btnDeleteCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCustomer.Depth = 0;
            this.btnDeleteCustomer.Icon = null;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(127, 53);
            this.btnDeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Primary = true;
            this.btnDeleteCustomer.Size = new System.Drawing.Size(69, 36);
            this.btnDeleteCustomer.TabIndex = 16;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 16);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(119, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Customer Name";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(729, 46);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "tabSelector";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.AutoSize = true;
            this.btnUpdateCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateCustomer.Depth = 0;
            this.btnUpdateCustomer.Icon = null;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(127, 59);
            this.btnUpdateCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Primary = true;
            this.btnUpdateCustomer.Size = new System.Drawing.Size(73, 36);
            this.btnUpdateCustomer.TabIndex = 22;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(998, 898);
            this.materialTabControl1.ResumeLayout(false);
            this.ViewCustomers.ResumeLayout(false);
            this.ViewCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sensors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Controllers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Actors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Customers)).EndInit();
            this.AddCustomers.ResumeLayout(false);
            this.gpAddCustomer.ResumeLayout(false);
            this.gpAddCustomer.PerformLayout();
            this.PurchaseProduct.ResumeLayout(false);
            this.PurchaseProduct.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.UpdateCustomers.ResumeLayout(false);
            this.UpdateCustomers.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.DeleteCustomers.ResumeLayout(false);
            this.DeleteCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage ViewCustomers;
        private System.Windows.Forms.TabPage AddCustomers;
        private System.Windows.Forms.GroupBox gpAddCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton btnNewCustomer;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private System.Windows.Forms.TabPage UpdateCustomers;
        private MaterialSkin.Controls.MaterialLabel lblSearchName_Update;
        private System.Windows.Forms.TabPage DeleteCustomers;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteCustomer;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewSurname;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewBankAccount;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateBank;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateTelephone;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateSurname;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateName;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel lblCustomers;
        private System.Windows.Forms.DataGridView dgView_Customers;
        private MaterialSkin.Controls.MaterialLabel lblSensors;
        private MaterialSkin.Controls.MaterialLabel lblControllers;
        private MaterialSkin.Controls.MaterialLabel lblActors;
        private System.Windows.Forms.DataGridView dgView_Sensors;
        private System.Windows.Forms.DataGridView dgView_Controllers;
        private System.Windows.Forms.DataGridView dgView_Actors;
        private MaterialSkin.Controls.MaterialLabel lblProducts;
        private System.Windows.Forms.ListBox lsBox_products;
        private System.Windows.Forms.ComboBox cbUpdateCustomer;
        private System.Windows.Forms.ComboBox cbDeleteCustomer;
        private System.Windows.Forms.TabPage PurchaseProduct;
        private System.Windows.Forms.ListBox lsBoxPurchaseProducts;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.CheckedListBox lsBoxPurchaseActors;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.CheckedListBox lsBoxPurchaseSensors;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.CheckedListBox lsBoxPurchaseControllers;
        private MaterialSkin.Controls.MaterialRaisedButton btnPurchaseProducts;
        private MaterialSkin.Controls.MaterialRaisedButton btnClearCart;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchClientName;
        private System.Windows.Forms.ListBox lsBoxClientNames;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdateCustomer;
    }
}
