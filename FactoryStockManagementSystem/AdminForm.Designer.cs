namespace FactoryStockManagementSystem
{
    partial class AdminForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.factoryStockManagementSystemDataSet3 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.UsersTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnManufacturingOperations = new System.Windows.Forms.Button();
            this.btnCustomerOperations = new System.Windows.Forms.Button();
            this.cmbFactoryId = new System.Windows.Forms.ComboBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblFactoryId = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cbIsAdmin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.factoryStockManagementSystemDataSet = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet();
            this.factoryStockManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoriesTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.FactoriesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.factoryIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.ısAdminDataGridViewCheckBoxColumn});
            this.dgvUsers.DataSource = this.usersBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(364, 145);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(1127, 633);
            this.dgvUsers.TabIndex = 17;
            // 
            // factoryStockManagementSystemDataSet3
            // 
            this.factoryStockManagementSystemDataSet3.DataSetName = "FactoryStockManagementSystemDataSet3";
            this.factoryStockManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.factoryStockManagementSystemDataSet3;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 150;
            // 
            // factoryIdDataGridViewTextBoxColumn
            // 
            this.factoryIdDataGridViewTextBoxColumn.DataPropertyName = "FactoryId";
            this.factoryIdDataGridViewTextBoxColumn.HeaderText = "FactoryId";
            this.factoryIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.factoryIdDataGridViewTextBoxColumn.Name = "factoryIdDataGridViewTextBoxColumn";
            this.factoryIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // ısAdminDataGridViewCheckBoxColumn
            // 
            this.ısAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.ısAdminDataGridViewCheckBoxColumn.HeaderText = "IsAdmin";
            this.ısAdminDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.ısAdminDataGridViewCheckBoxColumn.Name = "ısAdminDataGridViewCheckBoxColumn";
            this.ısAdminDataGridViewCheckBoxColumn.Width = 150;
            // 
            // btnManufacturingOperations
            // 
            this.btnManufacturingOperations.Location = new System.Drawing.Point(514, 23);
            this.btnManufacturingOperations.Name = "btnManufacturingOperations";
            this.btnManufacturingOperations.Size = new System.Drawing.Size(186, 92);
            this.btnManufacturingOperations.TabIndex = 15;
            this.btnManufacturingOperations.Text = "Manufacturing Operations";
            this.btnManufacturingOperations.UseVisualStyleBackColor = true;
            this.btnManufacturingOperations.Click += new System.EventHandler(this.btnManufacturingOperations_Click);
            // 
            // btnCustomerOperations
            // 
            this.btnCustomerOperations.Location = new System.Drawing.Point(835, 23);
            this.btnCustomerOperations.Name = "btnCustomerOperations";
            this.btnCustomerOperations.Size = new System.Drawing.Size(186, 92);
            this.btnCustomerOperations.TabIndex = 16;
            this.btnCustomerOperations.Text = "Customer Operations";
            this.btnCustomerOperations.UseVisualStyleBackColor = true;
            this.btnCustomerOperations.Click += new System.EventHandler(this.btnCustomerOperations_Click);
            // 
            // cmbFactoryId
            // 
            this.cmbFactoryId.DataSource = this.factoriesBindingSource;
            this.cmbFactoryId.DisplayMember = "FactoryName";
            this.cmbFactoryId.FormattingEnabled = true;
            this.cmbFactoryId.Location = new System.Drawing.Point(146, 104);
            this.cmbFactoryId.Name = "cmbFactoryId";
            this.cmbFactoryId.Size = new System.Drawing.Size(169, 28);
            this.cmbFactoryId.TabIndex = 2;
            this.cmbFactoryId.ValueMember = "Id";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(146, 40);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(169, 26);
            this.txtUserId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(40, 46);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(27, 20);
            this.lblOrderId.TabIndex = 34;
            this.lblOrderId.Text = "Id:";
            // 
            // lblFactoryId
            // 
            this.lblFactoryId.AutoSize = true;
            this.lblFactoryId.Location = new System.Drawing.Point(11, 112);
            this.lblFactoryId.Name = "lblFactoryId";
            this.lblFactoryId.Size = new System.Drawing.Size(84, 20);
            this.lblFactoryId.TabIndex = 33;
            this.lblFactoryId.Text = "Factory Id:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(146, 173);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(169, 26);
            this.txtFirstname.TabIndex = 3;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(23, 173);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(84, 20);
            this.lblFirstname.TabIndex = 37;
            this.lblFirstname.Text = "Firstname:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(146, 235);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(169, 26);
            this.txtLastname.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 235);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 20);
            this.lblLastName.TabIndex = 39;
            this.lblLastName.Text = "Lastname:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(146, 300);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(169, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 300);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 41;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 365);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 371);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 43;
            this.lblPassword.Text = "Password:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(146, 428);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(169, 26);
            this.txtTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(23, 428);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Title:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(146, 484);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(169, 26);
            this.txtPhone.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 484);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 47;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 549);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "Address:";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(146, 546);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(169, 28);
            this.rtxtAddress.TabIndex = 9;
            this.rtxtAddress.Text = "";
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(146, 603);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(169, 26);
            this.txtUserType.TabIndex = 10;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(17, 603);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(85, 20);
            this.lblUserType.TabIndex = 51;
            this.lblUserType.Text = "User Type:";
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.FormattingEnabled = true;
            this.cbIsAdmin.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbIsAdmin.Location = new System.Drawing.Point(146, 674);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(169, 28);
            this.cbIsAdmin.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Is Admin";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(247, 732);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(98, 46);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(130, 732);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(98, 46);
            this.btnUpdateUser.TabIndex = 13;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(11, 732);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(98, 46);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // factoryStockManagementSystemDataSet
            // 
            this.factoryStockManagementSystemDataSet.DataSetName = "FactoryStockManagementSystemDataSet";
            this.factoryStockManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factoryStockManagementSystemDataSetBindingSource
            // 
            this.factoryStockManagementSystemDataSetBindingSource.DataSource = this.factoryStockManagementSystemDataSet;
            this.factoryStockManagementSystemDataSetBindingSource.Position = 0;
            // 
            // factoryStockManagementSystemDataSet3BindingSource
            // 
            this.factoryStockManagementSystemDataSet3BindingSource.DataSource = this.factoryStockManagementSystemDataSet3;
            this.factoryStockManagementSystemDataSet3BindingSource.Position = 0;
            // 
            // factoriesBindingSource
            // 
            this.factoriesBindingSource.DataMember = "Factories";
            this.factoriesBindingSource.DataSource = this.factoryStockManagementSystemDataSet3BindingSource;
            // 
            // factoriesTableAdapter
            // 
            this.factoriesTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1503, 33);
            this.menuStrip1.TabIndex = 54;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 790);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cbIsAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.cmbFactoryId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblFactoryId);
            this.Controls.Add(this.btnCustomerOperations);
            this.Controls.Add(this.btnManufacturingOperations);
            this.Controls.Add(this.dgvUsers);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsers;
        private FactoryStockManagementSystemDataSet3 factoryStockManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private FactoryStockManagementSystemDataSet3TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnManufacturingOperations;
        private System.Windows.Forms.Button btnCustomerOperations;
        private System.Windows.Forms.ComboBox cmbFactoryId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblFactoryId;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cbIsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.BindingSource factoryStockManagementSystemDataSet3BindingSource;
        private FactoryStockManagementSystemDataSet factoryStockManagementSystemDataSet;
        private System.Windows.Forms.BindingSource factoryStockManagementSystemDataSetBindingSource;
        private System.Windows.Forms.BindingSource factoriesBindingSource;
        private FactoryStockManagementSystemDataSet3TableAdapters.FactoriesTableAdapter factoriesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
    }
}