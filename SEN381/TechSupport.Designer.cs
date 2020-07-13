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
            this.JobsInProgress = new System.Windows.Forms.TabPage();
            this.treeCurrentJobs = new System.Windows.Forms.TreeView();
            this.ScheduleNew = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lsBoxNewSupport = new System.Windows.Forms.ListBox();
            this.txtDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNewSupport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbNewSupport = new System.Windows.Forms.ComboBox();
            this.dtNewSupport = new System.Windows.Forms.DateTimePicker();
            this.lblJobDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lblTechnician = new MaterialSkin.Controls.MaterialLabel();
            this.UpdateSchedule = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lsBoxUpdateSupport = new System.Windows.Forms.ListBox();
            this.txtUpdateSupportDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnUpdateSupport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbUpdateSupport = new System.Windows.Forms.ComboBox();
            this.dtUpdateSupport = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteSchedule = new System.Windows.Forms.TabPage();
            this.CallCentre = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_EndCall = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Call = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearchClientName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lsBoxClientNames = new System.Windows.Forms.ListBox();
            this.txtUpdateCost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.lsBoxDeleteSupport = new System.Windows.Forms.ListBox();
            this.BtnDeleteSupport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.JobsInProgress.SuspendLayout();
            this.ScheduleNew.SuspendLayout();
            this.UpdateSchedule.SuspendLayout();
            this.DeleteSchedule.SuspendLayout();
            this.CallCentre.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.JobsInProgress);
            this.materialTabControl1.Controls.Add(this.ScheduleNew);
            this.materialTabControl1.Controls.Add(this.UpdateSchedule);
            this.materialTabControl1.Controls.Add(this.DeleteSchedule);
            this.materialTabControl1.Controls.Add(this.CallCentre);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 61);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(994, 830);
            this.materialTabControl1.TabIndex = 2;
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
            this.treeCurrentJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.treeCurrentJobs.ForeColor = System.Drawing.Color.White;
            this.treeCurrentJobs.LineColor = System.Drawing.Color.White;
            this.treeCurrentJobs.Location = new System.Drawing.Point(81, 98);
            this.treeCurrentJobs.Name = "treeCurrentJobs";
            this.treeCurrentJobs.Size = new System.Drawing.Size(796, 412);
            this.treeCurrentJobs.TabIndex = 0;
            // 
            // ScheduleNew
            // 
            this.ScheduleNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ScheduleNew.Controls.Add(this.materialLabel3);
            this.ScheduleNew.Controls.Add(this.materialLabel1);
            this.ScheduleNew.Controls.Add(this.lsBoxNewSupport);
            this.ScheduleNew.Controls.Add(this.txtDescription);
            this.ScheduleNew.Controls.Add(this.btnNewSupport);
            this.ScheduleNew.Controls.Add(this.cbNewSupport);
            this.ScheduleNew.Controls.Add(this.dtNewSupport);
            this.ScheduleNew.Controls.Add(this.lblJobDescription);
            this.ScheduleNew.Controls.Add(this.lblTechnician);
            this.ScheduleNew.ForeColor = System.Drawing.Color.White;
            this.ScheduleNew.Location = new System.Drawing.Point(4, 22);
            this.ScheduleNew.Name = "ScheduleNew";
            this.ScheduleNew.Padding = new System.Windows.Forms.Padding(3);
            this.ScheduleNew.Size = new System.Drawing.Size(986, 804);
            this.ScheduleNew.TabIndex = 1;
            this.ScheduleNew.Text = "Schedule New";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 199);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Schedule Date:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(435, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Customer:";
            // 
            // lsBoxNewSupport
            // 
            this.lsBoxNewSupport.FormattingEnabled = true;
            this.lsBoxNewSupport.Location = new System.Drawing.Point(439, 72);
            this.lsBoxNewSupport.Name = "lsBoxNewSupport";
            this.lsBoxNewSupport.Size = new System.Drawing.Size(196, 238);
            this.lsBoxNewSupport.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Depth = 0;
            this.txtDescription.Hint = "Enter Job Description";
            this.txtDescription.Location = new System.Drawing.Point(21, 151);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(309, 23);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TabStop = false;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // btnNewSupport
            // 
            this.btnNewSupport.AutoSize = true;
            this.btnNewSupport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewSupport.Depth = 0;
            this.btnNewSupport.Icon = null;
            this.btnNewSupport.Location = new System.Drawing.Point(21, 274);
            this.btnNewSupport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewSupport.Name = "btnNewSupport";
            this.btnNewSupport.Primary = true;
            this.btnNewSupport.Size = new System.Drawing.Size(71, 36);
            this.btnNewSupport.TabIndex = 4;
            this.btnNewSupport.Text = "Submit";
            this.btnNewSupport.UseVisualStyleBackColor = true;
            this.btnNewSupport.Click += new System.EventHandler(this.btnNewSupport_Click);
            // 
            // cbNewSupport
            // 
            this.cbNewSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbNewSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNewSupport.ForeColor = System.Drawing.Color.White;
            this.cbNewSupport.FormattingEnabled = true;
            this.cbNewSupport.Location = new System.Drawing.Point(21, 70);
            this.cbNewSupport.Name = "cbNewSupport";
            this.cbNewSupport.Size = new System.Drawing.Size(309, 21);
            this.cbNewSupport.TabIndex = 3;
            // 
            // dtNewSupport
            // 
            this.dtNewSupport.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dtNewSupport.Location = new System.Drawing.Point(21, 233);
            this.dtNewSupport.Name = "dtNewSupport";
            this.dtNewSupport.Size = new System.Drawing.Size(309, 20);
            this.dtNewSupport.TabIndex = 2;
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoSize = true;
            this.lblJobDescription.Depth = 0;
            this.lblJobDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblJobDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJobDescription.Location = new System.Drawing.Point(17, 108);
            this.lblJobDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(90, 19);
            this.lblJobDescription.TabIndex = 1;
            this.lblJobDescription.Text = "Description:";
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Depth = 0;
            this.lblTechnician.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTechnician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTechnician.Location = new System.Drawing.Point(17, 42);
            this.lblTechnician.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(86, 19);
            this.lblTechnician.TabIndex = 0;
            this.lblTechnician.Text = "Technician:";
            // 
            // UpdateSchedule
            // 
            this.UpdateSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.UpdateSchedule.Controls.Add(this.txtUpdateCost);
            this.UpdateSchedule.Controls.Add(this.materialLabel8);
            this.UpdateSchedule.Controls.Add(this.materialLabel4);
            this.UpdateSchedule.Controls.Add(this.materialLabel5);
            this.UpdateSchedule.Controls.Add(this.lsBoxUpdateSupport);
            this.UpdateSchedule.Controls.Add(this.txtUpdateSupportDescription);
            this.UpdateSchedule.Controls.Add(this.btnUpdateSupport);
            this.UpdateSchedule.Controls.Add(this.cbUpdateSupport);
            this.UpdateSchedule.Controls.Add(this.dtUpdateSupport);
            this.UpdateSchedule.Controls.Add(this.materialLabel6);
            this.UpdateSchedule.Controls.Add(this.materialLabel7);
            this.UpdateSchedule.Location = new System.Drawing.Point(4, 22);
            this.UpdateSchedule.Name = "UpdateSchedule";
            this.UpdateSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateSchedule.Size = new System.Drawing.Size(986, 804);
            this.UpdateSchedule.TabIndex = 2;
            this.UpdateSchedule.Text = "Update Schedule";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(339, 289);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(109, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Schedule Date:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(17, 40);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(134, 19);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Scheduled Support";
            // 
            // lsBoxUpdateSupport
            // 
            this.lsBoxUpdateSupport.FormattingEnabled = true;
            this.lsBoxUpdateSupport.Location = new System.Drawing.Point(21, 70);
            this.lsBoxUpdateSupport.Name = "lsBoxUpdateSupport";
            this.lsBoxUpdateSupport.Size = new System.Drawing.Size(196, 238);
            this.lsBoxUpdateSupport.TabIndex = 18;
            // 
            // txtUpdateSupportDescription
            // 
            this.txtUpdateSupportDescription.Depth = 0;
            this.txtUpdateSupportDescription.Hint = "Enter Job Description";
            this.txtUpdateSupportDescription.Location = new System.Drawing.Point(343, 149);
            this.txtUpdateSupportDescription.MaxLength = 32767;
            this.txtUpdateSupportDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateSupportDescription.Name = "txtUpdateSupportDescription";
            this.txtUpdateSupportDescription.PasswordChar = '\0';
            this.txtUpdateSupportDescription.SelectedText = "";
            this.txtUpdateSupportDescription.SelectionLength = 0;
            this.txtUpdateSupportDescription.SelectionStart = 0;
            this.txtUpdateSupportDescription.Size = new System.Drawing.Size(309, 23);
            this.txtUpdateSupportDescription.TabIndex = 17;
            this.txtUpdateSupportDescription.TabStop = false;
            this.txtUpdateSupportDescription.UseSystemPasswordChar = false;
            // 
            // btnUpdateSupport
            // 
            this.btnUpdateSupport.AutoSize = true;
            this.btnUpdateSupport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateSupport.Depth = 0;
            this.btnUpdateSupport.Icon = null;
            this.btnUpdateSupport.Location = new System.Drawing.Point(343, 364);
            this.btnUpdateSupport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateSupport.Name = "btnUpdateSupport";
            this.btnUpdateSupport.Primary = true;
            this.btnUpdateSupport.Size = new System.Drawing.Size(73, 36);
            this.btnUpdateSupport.TabIndex = 16;
            this.btnUpdateSupport.Text = "Update";
            this.btnUpdateSupport.UseVisualStyleBackColor = true;
            this.btnUpdateSupport.Click += new System.EventHandler(this.btnUpdateSupport_Click);
            // 
            // cbUpdateSupport
            // 
            this.cbUpdateSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbUpdateSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUpdateSupport.ForeColor = System.Drawing.Color.White;
            this.cbUpdateSupport.FormattingEnabled = true;
            this.cbUpdateSupport.Location = new System.Drawing.Point(343, 68);
            this.cbUpdateSupport.Name = "cbUpdateSupport";
            this.cbUpdateSupport.Size = new System.Drawing.Size(309, 21);
            this.cbUpdateSupport.TabIndex = 15;
            // 
            // dtUpdateSupport
            // 
            this.dtUpdateSupport.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dtUpdateSupport.Location = new System.Drawing.Point(343, 323);
            this.dtUpdateSupport.Name = "dtUpdateSupport";
            this.dtUpdateSupport.Size = new System.Drawing.Size(309, 20);
            this.dtUpdateSupport.TabIndex = 14;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(339, 106);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(90, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Description:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(339, 40);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(86, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Technician:";
            // 
            // DeleteSchedule
            // 
            this.DeleteSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DeleteSchedule.Controls.Add(this.materialLabel9);
            this.DeleteSchedule.Controls.Add(this.lsBoxDeleteSupport);
            this.DeleteSchedule.Controls.Add(this.BtnDeleteSupport);
            this.DeleteSchedule.Location = new System.Drawing.Point(4, 22);
            this.DeleteSchedule.Name = "DeleteSchedule";
            this.DeleteSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteSchedule.Size = new System.Drawing.Size(986, 804);
            this.DeleteSchedule.TabIndex = 3;
            this.DeleteSchedule.Text = "Delete Schedule";
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
            // txtUpdateCost
            // 
            this.txtUpdateCost.Depth = 0;
            this.txtUpdateCost.Hint = "Enter Job Cost";
            this.txtUpdateCost.Location = new System.Drawing.Point(343, 241);
            this.txtUpdateCost.MaxLength = 32767;
            this.txtUpdateCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpdateCost.Name = "txtUpdateCost";
            this.txtUpdateCost.PasswordChar = '\0';
            this.txtUpdateCost.SelectedText = "";
            this.txtUpdateCost.SelectionLength = 0;
            this.txtUpdateCost.SelectionStart = 0;
            this.txtUpdateCost.Size = new System.Drawing.Size(142, 23);
            this.txtUpdateCost.TabIndex = 22;
            this.txtUpdateCost.TabStop = false;
            this.txtUpdateCost.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(339, 198);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(45, 19);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "Cost:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(19, 19);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(134, 19);
            this.materialLabel9.TabIndex = 22;
            this.materialLabel9.Text = "Scheduled Support";
            // 
            // lsBoxDeleteSupport
            // 
            this.lsBoxDeleteSupport.FormattingEnabled = true;
            this.lsBoxDeleteSupport.Location = new System.Drawing.Point(23, 49);
            this.lsBoxDeleteSupport.Name = "lsBoxDeleteSupport";
            this.lsBoxDeleteSupport.Size = new System.Drawing.Size(196, 238);
            this.lsBoxDeleteSupport.TabIndex = 21;
            // 
            // BtnDeleteSupport
            // 
            this.BtnDeleteSupport.AutoSize = true;
            this.BtnDeleteSupport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteSupport.Depth = 0;
            this.BtnDeleteSupport.Icon = null;
            this.BtnDeleteSupport.Location = new System.Drawing.Point(23, 293);
            this.BtnDeleteSupport.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteSupport.Name = "BtnDeleteSupport";
            this.BtnDeleteSupport.Primary = true;
            this.BtnDeleteSupport.Size = new System.Drawing.Size(69, 36);
            this.BtnDeleteSupport.TabIndex = 20;
            this.BtnDeleteSupport.Text = "Delete";
            this.BtnDeleteSupport.UseVisualStyleBackColor = true;
            this.BtnDeleteSupport.Click += new System.EventHandler(this.BtnDeleteSupport_Click);
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
            this.JobsInProgress.ResumeLayout(false);
            this.ScheduleNew.ResumeLayout(false);
            this.ScheduleNew.PerformLayout();
            this.UpdateSchedule.ResumeLayout(false);
            this.UpdateSchedule.PerformLayout();
            this.DeleteSchedule.ResumeLayout(false);
            this.DeleteSchedule.PerformLayout();
            this.CallCentre.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage ScheduleNew;
        private System.Windows.Forms.TabPage UpdateSchedule;
        private System.Windows.Forms.TabPage DeleteSchedule;
        private System.Windows.Forms.TabPage CallCentre;
        private System.Windows.Forms.TabPage JobsInProgress;
        private System.Windows.Forms.TreeView treeCurrentJobs;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchClientName;
        private System.Windows.Forms.ListBox lsBoxClientNames;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Call;
        private MaterialSkin.Controls.MaterialRaisedButton btn_EndCall;
        private System.Windows.Forms.ComboBox cbNewSupport;
        private System.Windows.Forms.DateTimePicker dtNewSupport;
        private MaterialSkin.Controls.MaterialLabel lblJobDescription;
        private MaterialSkin.Controls.MaterialLabel lblTechnician;
        private MaterialSkin.Controls.MaterialRaisedButton btnNewSupport;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListBox lsBoxNewSupport;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ListBox lsBoxUpdateSupport;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateSupportDescription;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdateSupport;
        private System.Windows.Forms.ComboBox cbUpdateSupport;
        private System.Windows.Forms.DateTimePicker dtUpdateSupport;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpdateCost;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.ListBox lsBoxDeleteSupport;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDeleteSupport;
    }
}
