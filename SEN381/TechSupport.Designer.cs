namespace SEN381
{
    partial class TechSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechSupport));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpAddProducts = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSubmitNewProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblType = new MaterialSkin.Controls.MaterialLabel();
            this.cb_ProductGroup = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearchProd_Update = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSearchName_Update = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.CallCentre = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_EndCall = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Call = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearchClientName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lsBoxClientNames = new System.Windows.Forms.ListBox();
            this.JobsInProgress = new System.Windows.Forms.TabPage();
            this.treeCurrentJobs = new System.Windows.Forms.TreeView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gpAddProducts.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.CallCentre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.JobsInProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(7, 15);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(860, 46);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "tabSelector";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.CallCentre);
            this.materialTabControl1.Controls.Add(this.JobsInProgress);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 61);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(994, 830);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 804);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(983, 801);
            this.dgView.TabIndex = 0;
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
            this.tabPage2.Text = "Schedule New";
            // 
            // gpAddProducts
            // 
            this.gpAddProducts.Controls.Add(this.dateTimePicker1);
            this.gpAddProducts.Controls.Add(this.materialSingleLineTextField2);
            this.gpAddProducts.Controls.Add(this.materialLabel1);
            this.gpAddProducts.Controls.Add(this.btnSubmitNewProduct);
            this.gpAddProducts.Controls.Add(this.lblName);
            this.gpAddProducts.Controls.Add(this.lblType);
            this.gpAddProducts.Controls.Add(this.cb_ProductGroup);
            this.gpAddProducts.Location = new System.Drawing.Point(6, 6);
            this.gpAddProducts.Name = "gpAddProducts";
            this.gpAddProducts.Size = new System.Drawing.Size(425, 221);
            this.gpAddProducts.TabIndex = 8;
            this.gpAddProducts.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(207, 16);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(200, 23);
            this.materialSingleLineTextField2.TabIndex = 12;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 66);
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
            this.btnSubmitNewProduct.Location = new System.Drawing.Point(207, 164);
            this.btnSubmitNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmitNewProduct.Name = "btnSubmitNewProduct";
            this.btnSubmitNewProduct.Primary = true;
            this.btnSubmitNewProduct.Size = new System.Drawing.Size(71, 36);
            this.btnSubmitNewProduct.TabIndex = 7;
            this.btnSubmitNewProduct.Text = "Create";
            this.btnSubmitNewProduct.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Depth = 0;
            this.lblType.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblType.Location = new System.Drawing.Point(6, 113);
            this.lblType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 19);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Date";
            // 
            // cb_ProductGroup
            // 
            this.cb_ProductGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_ProductGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ProductGroup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ProductGroup.FormattingEnabled = true;
            this.cb_ProductGroup.Location = new System.Drawing.Point(207, 66);
            this.cb_ProductGroup.Name = "cb_ProductGroup";
            this.cb_ProductGroup.Size = new System.Drawing.Size(200, 24);
            this.cb_ProductGroup.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage3.Controls.Add(this.materialRaisedButton3);
            this.tabPage3.Controls.Add(this.txtSearchProd_Update);
            this.tabPage3.Controls.Add(this.lblSearchName_Update);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 804);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Schedule";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(162, 72);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(73, 36);
            this.materialRaisedButton3.TabIndex = 12;
            this.materialRaisedButton3.Text = "Search";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // txtSearchProd_Update
            // 
            this.txtSearchProd_Update.Depth = 0;
            this.txtSearchProd_Update.Hint = "";
            this.txtSearchProd_Update.Location = new System.Drawing.Point(162, 37);
            this.txtSearchProd_Update.MaxLength = 32767;
            this.txtSearchProd_Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchProd_Update.Name = "txtSearchProd_Update";
            this.txtSearchProd_Update.PasswordChar = '\0';
            this.txtSearchProd_Update.SelectedText = "";
            this.txtSearchProd_Update.SelectionLength = 0;
            this.txtSearchProd_Update.SelectionStart = 0;
            this.txtSearchProd_Update.Size = new System.Drawing.Size(200, 23);
            this.txtSearchProd_Update.TabIndex = 11;
            this.txtSearchProd_Update.TabStop = false;
            this.txtSearchProd_Update.UseSystemPasswordChar = false;
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
            this.lblSearchName_Update.Size = new System.Drawing.Size(119, 19);
            this.lblSearchName_Update.TabIndex = 10;
            this.lblSearchName_Update.Text = "Customer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialRaisedButton1);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 217);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
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
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(137, 155);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(73, 36);
            this.materialRaisedButton1.TabIndex = 7;
            this.materialRaisedButton1.Text = "Update";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
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
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Date";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage4.Controls.Add(this.dateTimePicker3);
            this.tabPage4.Controls.Add(this.materialLabel4);
            this.tabPage4.Controls.Add(this.materialRaisedButton2);
            this.tabPage4.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage4.Controls.Add(this.materialLabel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(986, 804);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Schedule";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(49, 96);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Date";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(170, 179);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(69, 36);
            this.materialRaisedButton2.TabIndex = 16;
            this.materialRaisedButton2.Text = "Delete";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(170, 42);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(200, 23);
            this.materialSingleLineTextField1.TabIndex = 15;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(49, 42);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(119, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Customer Name";
            // 
            // CallCentre
            // 
            this.CallCentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CallCentre.Controls.Add(this.groupBox2);
            this.CallCentre.Controls.Add(this.txtSearchClientName);
            this.CallCentre.Controls.Add(this.lsBoxClientNames);
            this.CallCentre.Location = new System.Drawing.Point(4, 22);
            this.CallCentre.Name = "CallCentre";
            this.CallCentre.Size = new System.Drawing.Size(986, 804);
            this.CallCentre.TabIndex = 4;
            this.CallCentre.Text = "Call Centre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_EndCall);
            this.groupBox2.Controls.Add(this.btn_Call);
            this.groupBox2.Location = new System.Drawing.Point(111, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btn_EndCall
            // 
            this.btn_EndCall.AutoSize = true;
            this.btn_EndCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EndCall.Depth = 0;
            this.btn_EndCall.Icon = ((System.Drawing.Image)(resources.GetObject("btn_EndCall.Icon")));
            this.btn_EndCall.Location = new System.Drawing.Point(94, 10);
            this.btn_EndCall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_EndCall.Name = "btn_EndCall";
            this.btn_EndCall.Primary = true;
            this.btn_EndCall.Size = new System.Drawing.Size(44, 36);
            this.btn_EndCall.TabIndex = 6;
            this.btn_EndCall.UseVisualStyleBackColor = true;
            this.btn_EndCall.Click += new System.EventHandler(this.btn_EndCall_Click);
            // 
            // btn_Call
            // 
            this.btn_Call.AutoSize = true;
            this.btn_Call.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Call.Depth = 0;
            this.btn_Call.Icon = ((System.Drawing.Image)(resources.GetObject("btn_Call.Icon")));
            this.btn_Call.Location = new System.Drawing.Point(6, 10);
            this.btn_Call.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Call.Name = "btn_Call";
            this.btn_Call.Primary = true;
            this.btn_Call.Size = new System.Drawing.Size(44, 36);
            this.btn_Call.TabIndex = 5;
            this.btn_Call.UseVisualStyleBackColor = true;
            this.btn_Call.Click += new System.EventHandler(this.btn_Call_Click);
            // 
            // txtSearchClientName
            // 
            this.txtSearchClientName.Depth = 0;
            this.txtSearchClientName.ForeColor = System.Drawing.Color.White;
            this.txtSearchClientName.Hint = "Enter Customer Name";
            this.txtSearchClientName.Location = new System.Drawing.Point(100, 21);
            this.txtSearchClientName.MaxLength = 32767;
            this.txtSearchClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchClientName.Name = "txtSearchClientName";
            this.txtSearchClientName.PasswordChar = '\0';
            this.txtSearchClientName.SelectedText = "";
            this.txtSearchClientName.SelectionLength = 0;
            this.txtSearchClientName.SelectionStart = 0;
            this.txtSearchClientName.Size = new System.Drawing.Size(178, 23);
            this.txtSearchClientName.TabIndex = 3;
            this.txtSearchClientName.TabStop = false;
            this.txtSearchClientName.UseSystemPasswordChar = false;
            this.txtSearchClientName.TextChanged += new System.EventHandler(this.txtSearchClientName_TextChanged);
            // 
            // lsBoxClientNames
            // 
            this.lsBoxClientNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lsBoxClientNames.ForeColor = System.Drawing.Color.White;
            this.lsBoxClientNames.FormattingEnabled = true;
            this.lsBoxClientNames.Location = new System.Drawing.Point(14, 108);
            this.lsBoxClientNames.Name = "lsBoxClientNames";
            this.lsBoxClientNames.Size = new System.Drawing.Size(328, 238);
            this.lsBoxClientNames.TabIndex = 2;
            // 
            // JobsInProgress
            // 
            this.JobsInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.JobsInProgress.Controls.Add(this.treeCurrentJobs);
            this.JobsInProgress.Location = new System.Drawing.Point(4, 22);
            this.JobsInProgress.Name = "JobsInProgress";
            this.JobsInProgress.Size = new System.Drawing.Size(986, 804);
            this.JobsInProgress.TabIndex = 5;
            this.JobsInProgress.Text = "Current Jobs";
            // 
            // treeCurrentJobs
            // 
            this.treeCurrentJobs.Location = new System.Drawing.Point(81, 98);
            this.treeCurrentJobs.Name = "treeCurrentJobs";
            this.treeCurrentJobs.Size = new System.Drawing.Size(796, 412);
            this.treeCurrentJobs.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(137, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(170, 94);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // TechSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "TechSupport";
            this.Size = new System.Drawing.Size(1000, 900);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gpAddProducts.ResumeLayout(false);
            this.gpAddProducts.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.CallCentre.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.JobsInProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpAddProducts;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmitNewProduct;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblType;
        private System.Windows.Forms.ComboBox cb_ProductGroup;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchProd_Update;
        private MaterialSkin.Controls.MaterialLabel lblSearchName_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage CallCentre;
        private System.Windows.Forms.TabPage JobsInProgress;
        private System.Windows.Forms.TreeView treeCurrentJobs;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchClientName;
        private System.Windows.Forms.ListBox lsBoxClientNames;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Call;
        private MaterialSkin.Controls.MaterialRaisedButton btn_EndCall;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}
