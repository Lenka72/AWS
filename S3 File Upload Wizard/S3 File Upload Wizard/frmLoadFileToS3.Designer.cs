namespace S3FileUploadWizard
{
    partial class frmLoadFileToS3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadFileToS3));
            this.tabFileLoadWizard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAWSProfilesToCleanUp = new System.Windows.Forms.ComboBox();
            this.lblAWSProfileNameToRemove = new System.Windows.Forms.Label();
            this.btnRemoveProfile = new System.Windows.Forms.Button();
            this.grpAWSProfile = new System.Windows.Forms.GroupBox();
            this.txtCreateNewOrUseExistingProfileInstructions = new System.Windows.Forms.TextBox();
            this.grpNewProfile = new System.Windows.Forms.GroupBox();
            this.cboAWSRegions = new System.Windows.Forms.ComboBox();
            this.lblAWSRegion = new System.Windows.Forms.Label();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.lblAWSSecretKey = new System.Windows.Forms.Label();
            this.txtAWSSecretKey = new System.Windows.Forms.TextBox();
            this.lblAWSAccessKey = new System.Windows.Forms.Label();
            this.txtAWSAccessKey = new System.Windows.Forms.TextBox();
            this.lblAWSProfileName = new System.Windows.Forms.Label();
            this.txtAWSProfileName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpSelectExistingProfile = new System.Windows.Forms.GroupBox();
            this.txtAWSShowRegion = new System.Windows.Forms.TextBox();
            this.lblAWSShowRegion = new System.Windows.Forms.Label();
            this.txtSelectAWSProfileInstructions = new System.Windows.Forms.TextBox();
            this.lblAWSExistingProfielName = new System.Windows.Forms.Label();
            this.cboAWSExistingProfiles = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpUploadDetails = new System.Windows.Forms.GroupBox();
            this.lblAWSProfileNotSelectedWarning = new System.Windows.Forms.Label();
            this.cboAWSS3StorageClass = new System.Windows.Forms.ComboBox();
            this.lblAWSS3StorageClass = new System.Windows.Forms.Label();
            this.txtUploadFileInstructions = new System.Windows.Forms.TextBox();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblAWSS3KeyName = new System.Windows.Forms.Label();
            this.txtAWSS3KeyName = new System.Windows.Forms.TextBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtAWSS3BucketName = new System.Windows.Forms.TextBox();
            this.lblAWSS3BucketName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabFileLoadWizard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpAWSProfile.SuspendLayout();
            this.grpNewProfile.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpSelectExistingProfile.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpUploadDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFileLoadWizard
            // 
            this.tabFileLoadWizard.Controls.Add(this.tabPage1);
            this.tabFileLoadWizard.Controls.Add(this.tabPage2);
            this.tabFileLoadWizard.Controls.Add(this.tabPage3);
            this.tabFileLoadWizard.Location = new System.Drawing.Point(12, 12);
            this.tabFileLoadWizard.Name = "tabFileLoadWizard";
            this.tabFileLoadWizard.SelectedIndex = 0;
            this.tabFileLoadWizard.Size = new System.Drawing.Size(551, 331);
            this.tabFileLoadWizard.TabIndex = 1;
            this.tabFileLoadWizard.SelectedIndexChanged += new System.EventHandler(this.tabFileLoadWizard_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpAWSProfile);
            this.tabPage1.Controls.Add(this.grpNewProfile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create New AWS Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboAWSProfilesToCleanUp);
            this.groupBox1.Controls.Add(this.lblAWSProfileNameToRemove);
            this.groupBox1.Controls.Add(this.btnRemoveProfile);
            this.groupBox1.Location = new System.Drawing.Point(7, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove AWS Profile (clean up)";
            // 
            // cboAWSProfilesToCleanUp
            // 
            this.cboAWSProfilesToCleanUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAWSProfilesToCleanUp.FormattingEnabled = true;
            this.cboAWSProfilesToCleanUp.Location = new System.Drawing.Point(201, 19);
            this.cboAWSProfilesToCleanUp.Name = "cboAWSProfilesToCleanUp";
            this.cboAWSProfilesToCleanUp.Size = new System.Drawing.Size(195, 21);
            this.cboAWSProfilesToCleanUp.TabIndex = 11;
            this.cboAWSProfilesToCleanUp.SelectedIndexChanged += new System.EventHandler(this.cboAWSProfilesToCleanUp_SelectedIndexChanged);
            // 
            // lblAWSProfileNameToRemove
            // 
            this.lblAWSProfileNameToRemove.AutoSize = true;
            this.lblAWSProfileNameToRemove.Location = new System.Drawing.Point(6, 24);
            this.lblAWSProfileNameToRemove.Name = "lblAWSProfileNameToRemove";
            this.lblAWSProfileNameToRemove.Size = new System.Drawing.Size(95, 13);
            this.lblAWSProfileNameToRemove.TabIndex = 10;
            this.lblAWSProfileNameToRemove.Text = "AWS Profile Name";
            // 
            // btnRemoveProfile
            // 
            this.btnRemoveProfile.Location = new System.Drawing.Point(412, 19);
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            this.btnRemoveProfile.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveProfile.TabIndex = 9;
            this.btnRemoveProfile.Text = "Re&move Profile";
            this.btnRemoveProfile.UseVisualStyleBackColor = true;
            this.btnRemoveProfile.Click += new System.EventHandler(this.btnRemoveProfile_Click);
            // 
            // grpAWSProfile
            // 
            this.grpAWSProfile.Controls.Add(this.txtCreateNewOrUseExistingProfileInstructions);
            this.grpAWSProfile.Location = new System.Drawing.Point(6, 6);
            this.grpAWSProfile.Name = "grpAWSProfile";
            this.grpAWSProfile.Size = new System.Drawing.Size(528, 80);
            this.grpAWSProfile.TabIndex = 2;
            this.grpAWSProfile.TabStop = false;
            this.grpAWSProfile.Text = "AWS Profile";
            // 
            // txtCreateNewOrUseExistingProfileInstructions
            // 
            this.txtCreateNewOrUseExistingProfileInstructions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCreateNewOrUseExistingProfileInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreateNewOrUseExistingProfileInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateNewOrUseExistingProfileInstructions.Location = new System.Drawing.Point(9, 20);
            this.txtCreateNewOrUseExistingProfileInstructions.Multiline = true;
            this.txtCreateNewOrUseExistingProfileInstructions.Name = "txtCreateNewOrUseExistingProfileInstructions";
            this.txtCreateNewOrUseExistingProfileInstructions.ReadOnly = true;
            this.txtCreateNewOrUseExistingProfileInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCreateNewOrUseExistingProfileInstructions.Size = new System.Drawing.Size(513, 45);
            this.txtCreateNewOrUseExistingProfileInstructions.TabIndex = 0;
            this.txtCreateNewOrUseExistingProfileInstructions.Text = "There are no profiles currently available for the Upload process to use.  Please " +
    "create a new profile using the “Create New AWS Profile” section below to create " +
    "a new profile before continuing.";
            // 
            // grpNewProfile
            // 
            this.grpNewProfile.Controls.Add(this.cboAWSRegions);
            this.grpNewProfile.Controls.Add(this.lblAWSRegion);
            this.grpNewProfile.Controls.Add(this.btnCreateProfile);
            this.grpNewProfile.Controls.Add(this.lblAWSSecretKey);
            this.grpNewProfile.Controls.Add(this.txtAWSSecretKey);
            this.grpNewProfile.Controls.Add(this.lblAWSAccessKey);
            this.grpNewProfile.Controls.Add(this.txtAWSAccessKey);
            this.grpNewProfile.Controls.Add(this.lblAWSProfileName);
            this.grpNewProfile.Controls.Add(this.txtAWSProfileName);
            this.grpNewProfile.Location = new System.Drawing.Point(6, 92);
            this.grpNewProfile.Name = "grpNewProfile";
            this.grpNewProfile.Size = new System.Drawing.Size(528, 153);
            this.grpNewProfile.TabIndex = 1;
            this.grpNewProfile.TabStop = false;
            this.grpNewProfile.Text = "Create New AWS Profile";
            // 
            // cboAWSRegions
            // 
            this.cboAWSRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAWSRegions.FormattingEnabled = true;
            this.cboAWSRegions.Location = new System.Drawing.Point(202, 96);
            this.cboAWSRegions.Name = "cboAWSRegions";
            this.cboAWSRegions.Size = new System.Drawing.Size(320, 21);
            this.cboAWSRegions.TabIndex = 8;
            this.cboAWSRegions.SelectedIndexChanged += new System.EventHandler(this.cboAWSRegions_SelectedIndexChanged);
            // 
            // lblAWSRegion
            // 
            this.lblAWSRegion.AutoSize = true;
            this.lblAWSRegion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAWSRegion.Location = new System.Drawing.Point(6, 92);
            this.lblAWSRegion.Name = "lblAWSRegion";
            this.lblAWSRegion.Size = new System.Drawing.Size(69, 13);
            this.lblAWSRegion.TabIndex = 7;
            this.lblAWSRegion.Text = "AWS Region";
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(419, 123);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(103, 23);
            this.btnCreateProfile.TabIndex = 6;
            this.btnCreateProfile.Text = "C&reate Profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // lblAWSSecretKey
            // 
            this.lblAWSSecretKey.AutoSize = true;
            this.lblAWSSecretKey.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAWSSecretKey.Location = new System.Drawing.Point(6, 70);
            this.lblAWSSecretKey.Name = "lblAWSSecretKey";
            this.lblAWSSecretKey.Size = new System.Drawing.Size(87, 13);
            this.lblAWSSecretKey.TabIndex = 5;
            this.lblAWSSecretKey.Text = "AWS Secret Key";
            // 
            // txtAWSSecretKey
            // 
            this.txtAWSSecretKey.Location = new System.Drawing.Point(327, 70);
            this.txtAWSSecretKey.Name = "txtAWSSecretKey";
            this.txtAWSSecretKey.Size = new System.Drawing.Size(195, 20);
            this.txtAWSSecretKey.TabIndex = 4;
            this.txtAWSSecretKey.TextChanged += new System.EventHandler(this.txtAWSSecretKey_TextChanged);
            // 
            // lblAWSAccessKey
            // 
            this.lblAWSAccessKey.AutoSize = true;
            this.lblAWSAccessKey.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAWSAccessKey.Location = new System.Drawing.Point(6, 47);
            this.lblAWSAccessKey.Name = "lblAWSAccessKey";
            this.lblAWSAccessKey.Size = new System.Drawing.Size(91, 13);
            this.lblAWSAccessKey.TabIndex = 3;
            this.lblAWSAccessKey.Text = "AWS Access Key";
            // 
            // txtAWSAccessKey
            // 
            this.txtAWSAccessKey.Location = new System.Drawing.Point(327, 47);
            this.txtAWSAccessKey.Name = "txtAWSAccessKey";
            this.txtAWSAccessKey.Size = new System.Drawing.Size(195, 20);
            this.txtAWSAccessKey.TabIndex = 2;
            this.txtAWSAccessKey.TextChanged += new System.EventHandler(this.txtAWSAccessKey_TextChanged);
            // 
            // lblAWSProfileName
            // 
            this.lblAWSProfileName.AutoSize = true;
            this.lblAWSProfileName.Location = new System.Drawing.Point(6, 25);
            this.lblAWSProfileName.Name = "lblAWSProfileName";
            this.lblAWSProfileName.Size = new System.Drawing.Size(95, 13);
            this.lblAWSProfileName.TabIndex = 1;
            this.lblAWSProfileName.Text = "AWS Profile Name";
            // 
            // txtAWSProfileName
            // 
            this.txtAWSProfileName.Location = new System.Drawing.Point(327, 25);
            this.txtAWSProfileName.Name = "txtAWSProfileName";
            this.txtAWSProfileName.Size = new System.Drawing.Size(195, 20);
            this.txtAWSProfileName.TabIndex = 0;
            this.txtAWSProfileName.TextChanged += new System.EventHandler(this.txtAWSProfileName_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpSelectExistingProfile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Select AWS Profile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpSelectExistingProfile
            // 
            this.grpSelectExistingProfile.Controls.Add(this.txtAWSShowRegion);
            this.grpSelectExistingProfile.Controls.Add(this.lblAWSShowRegion);
            this.grpSelectExistingProfile.Controls.Add(this.txtSelectAWSProfileInstructions);
            this.grpSelectExistingProfile.Controls.Add(this.lblAWSExistingProfielName);
            this.grpSelectExistingProfile.Controls.Add(this.cboAWSExistingProfiles);
            this.grpSelectExistingProfile.Location = new System.Drawing.Point(6, 6);
            this.grpSelectExistingProfile.Name = "grpSelectExistingProfile";
            this.grpSelectExistingProfile.Size = new System.Drawing.Size(531, 293);
            this.grpSelectExistingProfile.TabIndex = 4;
            this.grpSelectExistingProfile.TabStop = false;
            this.grpSelectExistingProfile.Text = "Select the AWS Profile to Use";
            // 
            // txtAWSShowRegion
            // 
            this.txtAWSShowRegion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAWSShowRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAWSShowRegion.Enabled = false;
            this.txtAWSShowRegion.Location = new System.Drawing.Point(315, 81);
            this.txtAWSShowRegion.Name = "txtAWSShowRegion";
            this.txtAWSShowRegion.Size = new System.Drawing.Size(195, 13);
            this.txtAWSShowRegion.TabIndex = 9;
            // 
            // lblAWSShowRegion
            // 
            this.lblAWSShowRegion.AutoSize = true;
            this.lblAWSShowRegion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAWSShowRegion.Location = new System.Drawing.Point(6, 81);
            this.lblAWSShowRegion.Name = "lblAWSShowRegion";
            this.lblAWSShowRegion.Size = new System.Drawing.Size(69, 13);
            this.lblAWSShowRegion.TabIndex = 8;
            this.lblAWSShowRegion.Text = "AWS Region";
            // 
            // txtSelectAWSProfileInstructions
            // 
            this.txtSelectAWSProfileInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectAWSProfileInstructions.Location = new System.Drawing.Point(9, 20);
            this.txtSelectAWSProfileInstructions.Multiline = true;
            this.txtSelectAWSProfileInstructions.Name = "txtSelectAWSProfileInstructions";
            this.txtSelectAWSProfileInstructions.Size = new System.Drawing.Size(516, 35);
            this.txtSelectAWSProfileInstructions.TabIndex = 7;
            this.txtSelectAWSProfileInstructions.Text = "Please select the AWS Profile to be used for this Upload.  The profile you select" +
    " should have the appropriate level of access to perform this task. ";
            // 
            // lblAWSExistingProfielName
            // 
            this.lblAWSExistingProfielName.AutoSize = true;
            this.lblAWSExistingProfielName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAWSExistingProfielName.Location = new System.Drawing.Point(6, 58);
            this.lblAWSExistingProfielName.Name = "lblAWSExistingProfielName";
            this.lblAWSExistingProfielName.Size = new System.Drawing.Size(95, 13);
            this.lblAWSExistingProfielName.TabIndex = 6;
            this.lblAWSExistingProfielName.Text = "AWS Profile Name";
            // 
            // cboAWSExistingProfiles
            // 
            this.cboAWSExistingProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAWSExistingProfiles.FormattingEnabled = true;
            this.cboAWSExistingProfiles.Location = new System.Drawing.Point(315, 55);
            this.cboAWSExistingProfiles.Name = "cboAWSExistingProfiles";
            this.cboAWSExistingProfiles.Size = new System.Drawing.Size(195, 21);
            this.cboAWSExistingProfiles.TabIndex = 0;
            this.cboAWSExistingProfiles.SelectedIndexChanged += new System.EventHandler(this.cboAWSExistingProfiles_SelectedIndexChanged);
            this.cboAWSExistingProfiles.SelectedValueChanged += new System.EventHandler(this.cboAWSExistingProfiles_SelectedValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpUploadDetails);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(543, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Load File in to S3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpUploadDetails
            // 
            this.grpUploadDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUploadDetails.Controls.Add(this.lblAWSProfileNotSelectedWarning);
            this.grpUploadDetails.Controls.Add(this.cboAWSS3StorageClass);
            this.grpUploadDetails.Controls.Add(this.lblAWSS3StorageClass);
            this.grpUploadDetails.Controls.Add(this.txtUploadFileInstructions);
            this.grpUploadDetails.Controls.Add(this.txtProgress);
            this.grpUploadDetails.Controls.Add(this.progressBar);
            this.grpUploadDetails.Controls.Add(this.lblAWSS3KeyName);
            this.grpUploadDetails.Controls.Add(this.txtAWSS3KeyName);
            this.grpUploadDetails.Controls.Add(this.btnUploadFile);
            this.grpUploadDetails.Controls.Add(this.btnBrowse);
            this.grpUploadDetails.Controls.Add(this.txtFilePath);
            this.grpUploadDetails.Controls.Add(this.lblFilePath);
            this.grpUploadDetails.Controls.Add(this.txtAWSS3BucketName);
            this.grpUploadDetails.Controls.Add(this.lblAWSS3BucketName);
            this.grpUploadDetails.Location = new System.Drawing.Point(3, 3);
            this.grpUploadDetails.Name = "grpUploadDetails";
            this.grpUploadDetails.Size = new System.Drawing.Size(530, 299);
            this.grpUploadDetails.TabIndex = 3;
            this.grpUploadDetails.TabStop = false;
            this.grpUploadDetails.Text = "Upload Details";
            // 
            // lblAWSProfileNotSelectedWarning
            // 
            this.lblAWSProfileNotSelectedWarning.AutoSize = true;
            this.lblAWSProfileNotSelectedWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAWSProfileNotSelectedWarning.ForeColor = System.Drawing.Color.Red;
            this.lblAWSProfileNotSelectedWarning.Location = new System.Drawing.Point(10, 128);
            this.lblAWSProfileNotSelectedWarning.Name = "lblAWSProfileNotSelectedWarning";
            this.lblAWSProfileNotSelectedWarning.Size = new System.Drawing.Size(447, 13);
            this.lblAWSProfileNotSelectedWarning.TabIndex = 13;
            this.lblAWSProfileNotSelectedWarning.Text = "+ No AWS Profile selected for this upload.  Please select a Profile to enable the" +
    " Upload button.";
            this.lblAWSProfileNotSelectedWarning.Visible = false;
            // 
            // cboAWSS3StorageClass
            // 
            this.cboAWSS3StorageClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAWSS3StorageClass.FormattingEnabled = true;
            this.cboAWSS3StorageClass.Location = new System.Drawing.Point(230, 98);
            this.cboAWSS3StorageClass.Name = "cboAWSS3StorageClass";
            this.cboAWSS3StorageClass.Size = new System.Drawing.Size(288, 21);
            this.cboAWSS3StorageClass.TabIndex = 12;
            // 
            // lblAWSS3StorageClass
            // 
            this.lblAWSS3StorageClass.AutoSize = true;
            this.lblAWSS3StorageClass.Location = new System.Drawing.Point(7, 103);
            this.lblAWSS3StorageClass.Name = "lblAWSS3StorageClass";
            this.lblAWSS3StorageClass.Size = new System.Drawing.Size(116, 13);
            this.lblAWSS3StorageClass.TabIndex = 11;
            this.lblAWSS3StorageClass.Text = "AWS S3 Storage Class";
            // 
            // txtUploadFileInstructions
            // 
            this.txtUploadFileInstructions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUploadFileInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUploadFileInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUploadFileInstructions.Location = new System.Drawing.Point(6, 209);
            this.txtUploadFileInstructions.Multiline = true;
            this.txtUploadFileInstructions.Name = "txtUploadFileInstructions";
            this.txtUploadFileInstructions.ReadOnly = true;
            this.txtUploadFileInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUploadFileInstructions.Size = new System.Drawing.Size(512, 84);
            this.txtUploadFileInstructions.TabIndex = 10;
            this.txtUploadFileInstructions.Text = "To have the file uploaded into a specific folder, under AWS S3 Key Name, enter th" +
    "e Folder Name followed by “/” and then the File Name and extension.  ";
            // 
            // txtProgress
            // 
            this.txtProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProgress.Location = new System.Drawing.Point(6, 154);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(425, 13);
            this.txtProgress.TabIndex = 9;
            this.txtProgress.Text = "Progress: 0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 180);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(512, 23);
            this.progressBar.TabIndex = 8;
            // 
            // lblAWSS3KeyName
            // 
            this.lblAWSS3KeyName.AutoSize = true;
            this.lblAWSS3KeyName.Location = new System.Drawing.Point(7, 72);
            this.lblAWSS3KeyName.Name = "lblAWSS3KeyName";
            this.lblAWSS3KeyName.Size = new System.Drawing.Size(100, 13);
            this.lblAWSS3KeyName.TabIndex = 2;
            this.lblAWSS3KeyName.Text = "AWS S3 Key Name";
            // 
            // txtAWSS3KeyName
            // 
            this.txtAWSS3KeyName.Location = new System.Drawing.Point(149, 72);
            this.txtAWSS3KeyName.Name = "txtAWSS3KeyName";
            this.txtAWSS3KeyName.Size = new System.Drawing.Size(369, 20);
            this.txtAWSS3KeyName.TabIndex = 3;
            this.txtAWSS3KeyName.TextChanged += new System.EventHandler(this.txtAWSS3KeyName_TextChanged);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(443, 154);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(75, 23);
            this.btnUploadFile.TabIndex = 7;
            this.btnUploadFile.Text = "&Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(443, 46);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Bro&wse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(60, 46);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(377, 20);
            this.txtFilePath.TabIndex = 5;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 46);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "File Path";
            // 
            // txtAWSS3BucketName
            // 
            this.txtAWSS3BucketName.Location = new System.Drawing.Point(151, 20);
            this.txtAWSS3BucketName.Name = "txtAWSS3BucketName";
            this.txtAWSS3BucketName.Size = new System.Drawing.Size(369, 20);
            this.txtAWSS3BucketName.TabIndex = 1;
            this.txtAWSS3BucketName.TextChanged += new System.EventHandler(this.txtAWSS3BucketName_TextChanged);
            // 
            // lblAWSS3BucketName
            // 
            this.lblAWSS3BucketName.AutoSize = true;
            this.lblAWSS3BucketName.Location = new System.Drawing.Point(7, 20);
            this.lblAWSS3BucketName.Name = "lblAWSS3BucketName";
            this.lblAWSS3BucketName.Size = new System.Drawing.Size(116, 13);
            this.lblAWSS3BucketName.TabIndex = 0;
            this.lblAWSS3BucketName.Text = "AWS S3 Bucket Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(322, 349);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(403, 349);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(484, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmLoadFileToS3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 386);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabFileLoadWizard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoadFileToS3";
            this.Text = "Load File to S3";
            this.Load += new System.EventHandler(this.frmLoadFileToS3_Load);
            this.tabFileLoadWizard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAWSProfile.ResumeLayout(false);
            this.grpAWSProfile.PerformLayout();
            this.grpNewProfile.ResumeLayout(false);
            this.grpNewProfile.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpSelectExistingProfile.ResumeLayout(false);
            this.grpSelectExistingProfile.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grpUploadDetails.ResumeLayout(false);
            this.grpUploadDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFileLoadWizard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAWSProfilesToCleanUp;
        private System.Windows.Forms.Label lblAWSProfileNameToRemove;
        private System.Windows.Forms.Button btnRemoveProfile;
        private System.Windows.Forms.GroupBox grpAWSProfile;
        private System.Windows.Forms.TextBox txtCreateNewOrUseExistingProfileInstructions;
        private System.Windows.Forms.GroupBox grpNewProfile;
        private System.Windows.Forms.ComboBox cboAWSRegions;
        private System.Windows.Forms.Label lblAWSRegion;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Label lblAWSSecretKey;
        private System.Windows.Forms.TextBox txtAWSSecretKey;
        private System.Windows.Forms.Label lblAWSAccessKey;
        private System.Windows.Forms.TextBox txtAWSAccessKey;
        private System.Windows.Forms.Label lblAWSProfileName;
        private System.Windows.Forms.TextBox txtAWSProfileName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpSelectExistingProfile;
        private System.Windows.Forms.TextBox txtSelectAWSProfileInstructions;
        private System.Windows.Forms.Label lblAWSExistingProfielName;
        private System.Windows.Forms.ComboBox cboAWSExistingProfiles;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpUploadDetails;
        private System.Windows.Forms.Label lblAWSProfileNotSelectedWarning;
        private System.Windows.Forms.ComboBox cboAWSS3StorageClass;
        private System.Windows.Forms.Label lblAWSS3StorageClass;
        private System.Windows.Forms.TextBox txtUploadFileInstructions;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblAWSS3KeyName;
        private System.Windows.Forms.TextBox txtAWSS3KeyName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtAWSS3BucketName;
        private System.Windows.Forms.Label lblAWSS3BucketName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAWSShowRegion;
        private System.Windows.Forms.TextBox txtAWSShowRegion;
    }
}

