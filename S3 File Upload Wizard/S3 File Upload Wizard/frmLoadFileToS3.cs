using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Amazon;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Transfer;


namespace S3FileUploadWizard
{
    public partial class frmLoadFileToS3 : Form
    {
        public static int intExistingProfileCount;
        public static Int64 intMultiFileUpload = 5000000000; //5368709120 is 5 GB 6291456, // 6 MB.

        public frmLoadFileToS3()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoadFileToS3_Load(object sender, EventArgs e)
        {
            //Create New AWS Profile
            intExistingProfileCount = GetProfileCount();
            SetCreateNewOrUseExistingInstructions(intExistingProfileCount);
            SetCreateOrRemoveProfileInstructions();
            EnableOrDisableConnectionButtons();
            GetRegions();
            GetProfilesToCleanUp();
            btnRemoveProfile.Enabled = false;

            //Select AWS Profile
            GetSavedProfiles();

            //Load File to S3;
            LoadS3StorageClass();
            SetLoadFileInstructions();
            progressBar.Value = 0;
            progressBar.Visible = false;
            txtProgress.Visible = false;

            tabFileLoadWizard.SelectedIndex = 0;

            //set buttons 
            SetButtons();
        }

        private void SetLoadFileInstructions()
        {
            String strLine1 = String.Format("{0}{1}{2}", "To have the file uploaded into a specific folder, under AWS S3 Key Name, enter the Folder Name followed by “/” and then the File Name and extension.", System.Environment.NewLine, System.Environment.NewLine);
            String strLine2 = String.Format("{0}{1}{2}", "Specifies the Storage Class of an S3 object. Possible values are:", System.Environment.NewLine, System.Environment.NewLine);
            String strLine3 = String.Format("{0}{1}", "     1.Standard: provides a 99.999999999% durability guarantee", System.Environment.NewLine);
            String strLine4 = String.Format("{0}{1}", "     2.Reduced Redundancy: provides a 99.99% durability guarantee", System.Environment.NewLine);
            String strLine5 = String.Format("{0}{1}", "     3.Standard Infrequently Accessed: to be used for data that requires less frequent, but rapid access.", System.Environment.NewLine);
            String strLine6 = "     4.Glacier: The object will be placed into Amazon Glacier";

            String strCombined = String.Format("{0}{1}{2}{3}{4}{5}", strLine1, strLine2, strLine3, strLine4, strLine5, strLine6);
            txtUploadFileInstructions.Text = strCombined;
        }

        private int GetProfileCount()
        {
            var netSDKFile = new NetSDKCredentialsFile();
            var lstProfiles = netSDKFile.ListProfileNames();
            int intProfileCount = lstProfiles.Count;
            return intProfileCount;
        }

        private String Reverse(String s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private String GetRegionEndpointServiceName(String strLongRegionName)
        {
            int intOutputEnd = strLongRegionName.Length - 1;
            String strOutputString = strLongRegionName.Substring(0, intOutputEnd);
            strOutputString = Reverse(strOutputString);
            int intOutputStart = strOutputString.IndexOf("(");
            strOutputString = strOutputString.Substring(0, intOutputStart);
            strOutputString = Reverse(strOutputString);
            return strOutputString;
        }

        private void GetRegions()
        {
            cboAWSRegions.Items.Clear();
            var AWSRegions = Amazon.RegionEndpoint.EnumerableAllRegions;
            foreach (var AWSRegion in AWSRegions)
            {
                cboAWSRegions.Items.Add(String.Format("{0} ({1})", AWSRegion.DisplayName, AWSRegion.SystemName));
            }

        }
        private void GetProfilesToCleanUp()
        {
            cboAWSProfilesToCleanUp.Items.Clear();
            var netSDKFile = new NetSDKCredentialsFile();
            var lstProfiles = netSDKFile.ListProfileNames();
            foreach (var Profile in lstProfiles)
            {
                cboAWSProfilesToCleanUp.Items.Add(Profile);
            }
            if (cboAWSProfilesToCleanUp.Items.Count == 0)
            {
                cboAWSProfilesToCleanUp.Enabled = false;
            }
            else
            {
                cboAWSProfilesToCleanUp.Enabled = true;
            }
        }

        private void GetSavedProfiles()
        {
            cboAWSExistingProfiles.Items.Clear();
            var netSDKFile = new NetSDKCredentialsFile();
            var lstProfiles = netSDKFile.ListProfileNames();
            foreach (var Profile in lstProfiles)
            {
                cboAWSExistingProfiles.Items.Add(Profile);
            }
            if (cboAWSExistingProfiles.Items.Count == 0)
            {
                cboAWSExistingProfiles.Enabled = false;
            }
            else
            {
                cboAWSExistingProfiles.Enabled = true;
            }
            if (cboAWSExistingProfiles.Items.Count == 1)
            {
                cboAWSExistingProfiles.Text = cboAWSExistingProfiles.Items[0].ToString();
            }
        }

        private void LoadS3StorageClass()
        {
            cboAWSS3StorageClass.Items.Clear();
            cboAWSS3StorageClass.Items.Add(Amazon.S3.S3StorageClass.Standard.Value);
            cboAWSS3StorageClass.Items.Add(Amazon.S3.S3StorageClass.StandardInfrequentAccess.Value);
            cboAWSS3StorageClass.Items.Add(Amazon.S3.S3StorageClass.ReducedRedundancy.Value);
            cboAWSS3StorageClass.Items.Add(Amazon.S3.S3StorageClass.Glacier.Value);
            cboAWSS3StorageClass.Text = Amazon.S3.S3StorageClass.Standard.Value;
        }

        private void SetCreateOrRemoveProfileInstructions()
        {
            String strInstructions = String.Format("{0}{1}{2}", "There are no profiles currently available for the Upload process to use.Please create a new profile using the Create New AWS Profile section below to create a new profile before continuing.", System.Environment.NewLine, "To cleanup profiles, select the profile under the Remove AWS profile (clean up) section and click the Remove Profile button.");
            txtCreateNewOrUseExistingProfileInstructions.Text = strInstructions;
        }

        private void SetCreateNewOrUseExistingInstructions(int intExistingProfileCount)
        {
            if (intExistingProfileCount == 0)
            {
                txtCreateNewOrUseExistingProfileInstructions.Text = "There are no profiles currently available for the Upload process to use.Please create a new profile using the “Create New AWS Profile” section below to create a new profile before continuing.";
            }
            else
            {
                txtCreateNewOrUseExistingProfileInstructions.Text = String.Format("{0} profiles have been located on this machine that may be appropriate to use for this Upload process.  If you would like to create a new profile to use for this Upload instead of using one of the existing ones, please use the “Create New AWS Profile” section below.  To use one of the existing profiles, just click the Next button.", intExistingProfileCount);
            }
        }

        private void DisableNextBottonIfNoPrifileFound(int intExistingPrfileCount)
        {
            btnNext.Enabled = intExistingPrfileCount == 0 ? false : true;
        }

        private void EnableOrDisableConnectionButtons()
        {
            btnCreateProfile.Enabled = txtAWSProfileName.Text.Length != 0 && txtAWSAccessKey.Text.Length != 0 && txtAWSSecretKey.Text.Length != 0 && cboAWSRegions.Text.Length != 0 ? true : false;
        }

        private void SetButtons()
        {
            //overall default behaviour if no other rules apply
            btnNext.Enabled = tabFileLoadWizard.SelectedIndex + 1 < tabFileLoadWizard.TabPages.Count ? true : false;
            btnBack.Enabled = tabFileLoadWizard.SelectedIndex != 0 ? true : false;
            btnUploadFile.Enabled = false;
            switch (tabFileLoadWizard.SelectedIndex)
            {
                case 0:
                    DisableNextBottonIfNoPrifileFound(intExistingProfileCount);
                    break;
                case 1:
                    btnNext.Enabled = cboAWSExistingProfiles.Text.Length == 0 ? false : true;
                    break;
                case 2:
                    EnableOrDisableConnectionButtons();
                    break;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabFileLoadWizard.SelectedIndex = tabFileLoadWizard.SelectedIndex != 0 ? tabFileLoadWizard.SelectedIndex - 1 : tabFileLoadWizard.SelectedIndex;
            SetButtons();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            tabFileLoadWizard.SelectedIndex = tabFileLoadWizard.SelectedIndex + 1 < tabFileLoadWizard.TabPages.Count ? tabFileLoadWizard.SelectedIndex + 1 : tabFileLoadWizard.SelectedIndex;

        }

        private void txtAWSProfileName_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableConnectionButtons();
        }

        private void txtAWSAccessKey_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableConnectionButtons();
        }

        private void txtAWSSecretKey_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableConnectionButtons();
        }

        private void cboAWSRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableOrDisableConnectionButtons();
        }

        private void tabFileLoadWizard_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            String strProfileName = txtAWSProfileName.Text.Trim();
            String strAccessKey = txtAWSAccessKey.Text.Trim();
            String strSecretKey = txtAWSSecretKey.Text.Trim();
            String strRegionServiceName = GetRegionEndpointServiceName(cboAWSRegions.Text.Trim());

            var AmazonRegionEndpoint = RegionEndpoint.GetBySystemName(strRegionServiceName);

            var AWSProfileOptions = new CredentialProfileOptions
            {
                AccessKey = strAccessKey,
                SecretKey = strSecretKey
            };
            var AWSProfile = new Amazon.Runtime.CredentialManagement.CredentialProfile(strProfileName, AWSProfileOptions);
            AWSProfile.Region = AmazonRegionEndpoint;
            //var AWSCredentialsFile = new Amazon.Runtime.CredentialManagement.SharedCredentialsFile();
            var netSDKFile = new NetSDKCredentialsFile();
            netSDKFile.RegisterProfile(AWSProfile);
            //refreshed the list of available profiles
            GetSavedProfiles();
            GetProfilesToCleanUp();
            //clear Create Profile Fields
            txtAWSProfileName.Text = "";
            txtAWSAccessKey.Text = "";
            txtAWSSecretKey.Text = "";
            cboAWSRegions.Text = "";
            cboAWSRegions.SelectedIndex = -1;
            btnCreateProfile.Enabled = false;
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            //Amazon.Util.ProfileManager.UnregisterProfile(cboAWSProfilesToCleanUp.Text);
            //var AWSProfile = new Amazon.Runtime.CredentialManagement.SharedCredentialsFile();
            var netSDKFile = new NetSDKCredentialsFile();
            netSDKFile.UnregisterProfile(cboAWSProfilesToCleanUp.Text);

            GetProfilesToCleanUp();
            GetSavedProfiles();
            cboAWSProfilesToCleanUp.Text = "";
            btnRemoveProfile.Enabled = false;

        }

        private void cboAWSProfilesToCleanUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveProfile.Enabled = cboAWSProfilesToCleanUp.Text.Length != 0 ? true : false;
        }

        private void cboAWSExistingProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void EnableOrDisableUploadFileButton()
        {
            btnUploadFile.Enabled = txtAWSS3BucketName.Text.Length != 0 && txtFilePath.Text.Length != 0 && cboAWSExistingProfiles.Text.Length != 0 ? true : false;
            lblAWSProfileNotSelectedWarning.Visible = cboAWSExistingProfiles.Text.Length == 0 ? true : false;
        }

        private void txtAWSS3BucketName_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableUploadFileButton();
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableUploadFileButton();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtFilePath.Text = openFileDialog.FileName;
                    txtAWSS3KeyName.Text = Path.GetFileName(txtFilePath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtAWSS3KeyName_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableUploadFileButton();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            String strBucketName = txtAWSS3BucketName.Text;
            String strKeyName = txtAWSS3KeyName.Text;
            String strFilePath = txtFilePath.Text;
            S3StorageClass scAWSStorageClass = cboAWSS3StorageClass.Text;
            Int64 intFileSize = new FileInfo(strFilePath).Length;
            DateTime dtStartDateTime = DateTime.Now;
            Int64 intUploadDuration;
            String strProgress;
            S3StorageClass strS3StorageClass = cboAWSS3StorageClass.Text.Length != 0 ? S3StorageClass.FindValue(cboAWSS3StorageClass.Text) : S3StorageClass.Standard;
            txtProgress.Visible = true;
            progressBar.Visible = true;

            try
            {
                var myCredentialPRofileStoreChain = new CredentialProfileStoreChain();
                AWSCredentials myCredentials;
                myCredentialPRofileStoreChain.TryGetAWSCredentials(cboAWSExistingProfiles.Text, out myCredentials);
                CredentialProfile myProfile;
                myCredentialPRofileStoreChain.TryGetProfile(cboAWSExistingProfiles.Text, out myProfile);

                TransferUtility fileTransferUtility = new TransferUtility(new AmazonS3Client(myCredentials, myProfile.Region));
                intUploadDuration = (DateTime.Now - dtStartDateTime).Seconds;
                strProgress = String.Format("Progress: 5%. Elapsed Time: {0} seconds.", intUploadDuration.ToString());
                txtProgress.Text = strProgress;
                progressBar.Value = 5;

                if (intFileSize <= intMultiFileUpload && cboAWSS3StorageClass.Text == "STANDARD")
                {
                    if (txtAWSS3KeyName.Text.Length == 0)
                    {
                        strProgress = "Progress: 10%.";
                        txtProgress.Text = strProgress;
                        progressBar.Value = 10;
                        // 1. Upload a file, file name is used as the object key name.
                        fileTransferUtility.Upload(strFilePath, strBucketName);
                    }
                    else
                    {
                        strProgress = "Progress: 10%.";
                        txtProgress.Text = strProgress;
                        progressBar.Value = 10;
                        // 2. Specify object key name explicitly.
                        fileTransferUtility.Upload(strFilePath,
                                            strBucketName, strKeyName);
                    }
                }
                else
                {
                    strProgress = "Progress: 10%.";
                    txtProgress.Text = strProgress;
                    progressBar.Value = 10;
                    // 4.Specify advanced settings/options.
                    TransferUtilityUploadRequest fileTransferUtilityRequest = new TransferUtilityUploadRequest
                    {
                        BucketName = strBucketName,
                        FilePath = strFilePath,
                        StorageClass = scAWSStorageClass,
                        PartSize = intMultiFileUpload, //5368709120 is 5 GB, but we are going to set it to 5000000000 just to be on the safe side.  The original test was run as 6291456, // 6 MB.
                        Key = strKeyName,
                        CannedACL = S3CannedACL.PublicRead
                    };
                    fileTransferUtilityRequest.Metadata.Add("param1", "Value1");
                    fileTransferUtilityRequest.Metadata.Add("param2", "Value2");
                    fileTransferUtility.Upload(fileTransferUtilityRequest);
                }

                intUploadDuration = (DateTime.Now - dtStartDateTime).Minutes == 0 ? (DateTime.Now - dtStartDateTime).Seconds : (DateTime.Now - dtStartDateTime).Minutes;
                if (intUploadDuration > 60)
                {
                    strProgress = String.Format("Progress: 100%. Elapsed Time: {0} hour {1} minutes.", (intUploadDuration / 60).ToString(), (intUploadDuration % 60).ToString());
                }
                else
                {
                    if ((DateTime.Now - dtStartDateTime).Minutes == 0)
                    {
                        strProgress = String.Format("Progress: 100%. Elapsed Time: {0} seconds.", intUploadDuration.ToString());
                    }
                    else
                    {
                        strProgress = String.Format("Progress: 100%. Elapsed Time: {0} minutes.", intUploadDuration.ToString());
                    }
                }
                txtProgress.Text = strProgress;
                progressBar.Value = 100;
            }
            catch (AmazonS3Exception s3Exception)
            {
                MessageBox.Show(s3Exception.Message,
                                  s3Exception.InnerException.Message);
            }
            btnCancel.Text = "&Close";
        }

        private void cboAWSExistingProfiles_SelectedValueChanged(object sender, EventArgs e)
        {
            SetRegionFromProfile();
        }

        private void SetRegionFromProfile()
        {
            try
            {
                var myCredentialPRofileStoreChain = new CredentialProfileStoreChain();
                AWSCredentials myCredentials;
                myCredentialPRofileStoreChain.TryGetAWSCredentials(cboAWSExistingProfiles.Text, out myCredentials);
                CredentialProfile myProfile;
                myCredentialPRofileStoreChain.TryGetProfile(cboAWSExistingProfiles.Text, out myProfile);
                txtAWSShowRegion.Text = myProfile.Region.ToString();
            }
            catch (AmazonS3Exception s3Exception)
            {
                MessageBox.Show(s3Exception.Message,
                                  s3Exception.InnerException.Message);
            }
        }

    }
}
