namespace FactoryStockManagementSystem
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.customerFactoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet();
            this.customerFactoriesTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSetTableAdapters.CustomerFactoriesTableAdapter();
            this.lblFactoryType = new System.Windows.Forms.Label();
            this.manufacturingFactoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturingFactoriesTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSetTableAdapters.ManufacturingFactoriesTableAdapter();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtFactoryId = new System.Windows.Forms.TextBox();
            this.cbIsAdmin = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.customerFactoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturingFactoriesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Is Admin";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(909, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "User Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(909, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(909, 296);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(909, 359);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(909, 428);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(240, 427);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(240, 364);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Lastname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(240, 290);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 20);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "Firstname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(437, 290);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(210, 26);
            this.txtFirstname.TabIndex = 3;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(437, 364);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(210, 26);
            this.txtLastname.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(437, 427);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1080, 428);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 26);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(1080, 155);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 26);
            this.txtTitle.TabIndex = 6;
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(1080, 222);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(210, 26);
            this.txtUserType.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(1080, 296);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(210, 26);
            this.txtPhone.TabIndex = 8;
            // 
            // customerFactoriesBindingSource
            // 
            this.customerFactoriesBindingSource.DataMember = "CustomerFactories";
            this.customerFactoriesBindingSource.DataSource = this.factoryStockManagementSystemDataSetBindingSource;
            // 
            // factoryStockManagementSystemDataSetBindingSource
            // 
            this.factoryStockManagementSystemDataSetBindingSource.DataSource = this.factoryStockManagementSystemDataSet;
            this.factoryStockManagementSystemDataSetBindingSource.Position = 0;
            // 
            // factoryStockManagementSystemDataSet
            // 
            this.factoryStockManagementSystemDataSet.DataSetName = "FactoryStockManagementSystemDataSet";
            this.factoryStockManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerFactoriesTableAdapter
            // 
            this.customerFactoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lblFactoryType
            // 
            this.lblFactoryType.AutoSize = true;
            this.lblFactoryType.Location = new System.Drawing.Point(240, 155);
            this.lblFactoryType.Name = "lblFactoryType";
            this.lblFactoryType.Size = new System.Drawing.Size(90, 20);
            this.lblFactoryType.TabIndex = 18;
            this.lblFactoryType.Text = "Factory Id";
            // 
            // manufacturingFactoriesBindingSource
            // 
            this.manufacturingFactoriesBindingSource.DataMember = "ManufacturingFactories";
            this.manufacturingFactoriesBindingSource.DataSource = this.factoryStockManagementSystemDataSetBindingSource;
            // 
            // manufacturingFactoriesTableAdapter
            // 
            this.manufacturingFactoriesTableAdapter.ClearBeforeFill = true;
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(1080, 359);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(210, 30);
            this.rtxtAddress.TabIndex = 9;
            this.rtxtAddress.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(848, 549);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(267, 74);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(481, 549);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(267, 74);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "&Return To Main Page";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtFactoryId
            // 
            this.txtFactoryId.Location = new System.Drawing.Point(437, 152);
            this.txtFactoryId.Name = "txtFactoryId";
            this.txtFactoryId.Size = new System.Drawing.Size(210, 26);
            this.txtFactoryId.TabIndex = 1;
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.FormattingEnabled = true;
            this.cbIsAdmin.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbIsAdmin.Location = new System.Drawing.Point(437, 220);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(210, 28);
            this.cbIsAdmin.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınfoToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1507, 33);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ınfoToolStripMenuItem
            // 
            this.ınfoToolStripMenuItem.Name = "ınfoToolStripMenuItem";
            this.ınfoToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.ınfoToolStripMenuItem.Text = "Info";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 34);
            this.toolStripMenuItem1.Text = "Font";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factoriesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // factoriesToolStripMenuItem
            // 
            this.factoriesToolStripMenuItem.Name = "factoriesToolStripMenuItem";
            this.factoriesToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.factoriesToolStripMenuItem.Text = "Factories";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 725);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbIsAdmin);
            this.Controls.Add(this.txtFactoryId);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.lblFactoryType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerFactoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturingFactoriesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.BindingSource factoryStockManagementSystemDataSetBindingSource;
        private FactoryStockManagementSystemDataSet factoryStockManagementSystemDataSet;
        private System.Windows.Forms.BindingSource customerFactoriesBindingSource;
        private FactoryStockManagementSystemDataSetTableAdapters.CustomerFactoriesTableAdapter customerFactoriesTableAdapter;
        private System.Windows.Forms.Label lblFactoryType;
        private System.Windows.Forms.BindingSource manufacturingFactoriesBindingSource;
        private FactoryStockManagementSystemDataSetTableAdapters.ManufacturingFactoriesTableAdapter manufacturingFactoriesTableAdapter;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtFactoryId;
        private System.Windows.Forms.ComboBox cbIsAdmin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
    }
}