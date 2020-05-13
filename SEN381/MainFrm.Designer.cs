namespace SEN381
{
    partial class MainFrm
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
            this.productView = new SEN381.Products();
            this.menuSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.customers1 = new SEN381.Customers();
            this.techSupport1 = new SEN381.TechSupport();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productView
            // 
            this.productView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productView.Location = new System.Drawing.Point(3, 3);
            this.productView.Name = "productView";
            this.productView.Size = new System.Drawing.Size(1906, 945);
            this.productView.TabIndex = 1;
            // 
            // menuSelector
            // 
            this.menuSelector.BaseTabControl = this.tabControl;
            this.menuSelector.Depth = 0;
            this.menuSelector.Location = new System.Drawing.Point(70, 27);
            this.menuSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuSelector.Name = "menuSelector";
            this.menuSelector.Size = new System.Drawing.Size(415, 31);
            this.menuSelector.TabIndex = 2;
            this.menuSelector.Text = "materialTabSelector1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 103);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1920, 977);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.productView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1912, 951);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customers1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1912, 951);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.techSupport1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1912, 951);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Technical Support";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // customers1
            // 
            this.customers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.customers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customers1.Location = new System.Drawing.Point(3, 3);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(1906, 945);
            this.customers1.TabIndex = 0;
            // 
            // techSupport1
            // 
            this.techSupport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techSupport1.Location = new System.Drawing.Point(3, 3);
            this.techSupport1.Name = "techSupport1";
            this.techSupport1.Size = new System.Drawing.Size(1906, 945);
            this.techSupport1.TabIndex = 0;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuSelector);
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHS";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Products productView;
        private MaterialSkin.Controls.MaterialTabSelector menuSelector;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Customers customers1;
        private TechSupport techSupport1;
    }
}

