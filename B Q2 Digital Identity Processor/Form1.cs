namespace B_Q2_Digital_Identity_Processor
{
    public partial class DigitalIdentityProcessor : Form
    {
        private CitizenProfile currentProfile;
        public DigitalIdentityProcessor()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            currentProfile = new CitizenProfile(
                txtname.Text,
                txtID.Text,
                citizenbox.Text
            );
            
            lblValidationResult.Text = string.Empty;

            string result = currentProfile.ValidateID();
            lblValidationResult.Text = result;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (currentProfile == null)
            {
                MessageBox.Show("Please validate ID first.");
                return;
            }

            string summary =
                $@"==== DIGITAL CITIZEN SUMMARY ====
                Name: {currentProfile.FullName}
                ID Number: {currentProfile.IDNumber}
                Age: {currentProfile.Age}
                Citizenship: {currentProfile.CitizenshipStatus}
                Validation: {currentProfile.ValidateID()}
                Processed at: Home Affairs Digital Desk
                Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";

            txtSummary.Text = summary;

        }

        private void DigitalIdentityProcessor_Load(object sender, EventArgs e)
        {

        }
    }
}
