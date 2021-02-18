using System;
using System.IO;
using System.Windows.Forms;

namespace AuthenticationGenerator
{
    public partial class FrmMain : Form
    {
        private AuthModel _auth = new AuthModel();
        public FrmMain()
        {
            InitializeComponent();
            TxtVersion.Text = "2";
            TxtEncPrimitives.Text = "RSA-1024"; ;
            TxtSignPrimitives.Text = "RSA-1024";
            TxtMACPrimitives.Text = "SHA256";
            TxtMasterKeyHash.Text = "HASH";
            TxtType.Text = "FA";
            TxtTarget.Text = "OpenMUNCS";
            TxtMainBody.Text = "OpenMUNCS";
            ChkIsSubsidiaryBodyLocked.Checked = false;
            TxtSubsidiaryBodies.Text = "";
            TxtTimeStart.Text = "2019-10-31";
            NumTimeSustain.Value = 10000;
            TxtExpressService.Text = "Normal";
            TxtNyarlathotepService.Text = "Normal";
            TxtNotesService.Text = "Normal";
            TxtProsService.Text = "Normal";
            TxtInfonetService.Text = "Normal";
            ChkIsCoreUser.Checked = false;
            ChkIsPayingUser.Checked = false;
            NumAdvancedSupport.Value = 0;
            ChkIsOverseasService.Checked = false;
            TxtRegion.Text = "Mainland, China";
            TxtComments.Text = "";
        }

        private void TxtVersion_TextChanged(object sender, EventArgs e)
        {
            _auth.Version = TxtVersion.Text;
        }

        private void TxtEncPrimitives_TextChanged(object sender, EventArgs e)
        {
            _auth.EncPrimitives = TxtEncPrimitives.Text;
        }

        private void TxtSignPrimitives_TextChanged(object sender, EventArgs e)
        {
            _auth.SignPrimitives = TxtSignPrimitives.Text;
        }

        private void TxtMACPrimitives_TextChanged(object sender, EventArgs e)
        {
            _auth.MACPrimitives = TxtMACPrimitives.Text;
        }

        private void TxtMasterKeyHash_TextChanged(object sender, EventArgs e)
        {
            _auth.MasterKeyHash = TxtMasterKeyHash.Text;
        }

        private void TxtType_TextChanged(object sender, EventArgs e)
        {
            _auth.Type = TxtType.Text;
        }

        private void TxtTarget_TextChanged(object sender, EventArgs e)
        {
            _auth.Target = TxtTarget.Text;
        }

        private void TxtMainBody_TextChanged(object sender, EventArgs e)
        {
            _auth.MainBody = TxtMainBody.Text;
        }

        private void TxtSubsidiaryBodies_TextChanged(object sender, EventArgs e)
        {
            _auth.SubsidiaryBodies = TxtSubsidiaryBodies.Text;
        }

        private void ChkIsSubsidiaryBodyLocked_CheckedChanged(object sender, EventArgs e)
        {
            _auth.IsSubsidiaryBodyLocked = ChkIsSubsidiaryBodyLocked.Checked;
        }

        private void TxtTimeStart_TextChanged(object sender, EventArgs e)
        {
            _auth.TimeStart = TxtTimeStart.Text;
        }

        private void NumTimeSustain_ValueChanged(object sender, EventArgs e)
        {
            _auth.TimeSustain = (int)NumTimeSustain.Value;
        }

        private void TxtExpressService_TextChanged(object sender, EventArgs e)
        {
            _auth.ExpressService = TxtExpressService.Text;
        }

        private void TxtNyarlathotepService_TextChanged(object sender, EventArgs e)
        {
            _auth.NyarlathotepService = TxtNyarlathotepService.Text;
        }

        private void TxtNotesService_TextChanged(object sender, EventArgs e)
        {
            _auth.NotesService = TxtNotesService.Text;

        }

        private void TxtProsService_TextChanged(object sender, EventArgs e)
        {

            _auth.ProsService = TxtProsService.Text;
        }

        private void TxtInfonetService_TextChanged(object sender, EventArgs e)
        {
            _auth.InfonetService = TxtInfonetService.Text;

        }

        private void ChkIsCoreUser_CheckedChanged(object sender, EventArgs e)
        {
            _auth.IsCoreUser = ChkIsCoreUser.Checked;
        }

        private void ChkIsPayingUser_CheckedChanged(object sender, EventArgs e)
        {
            _auth.IsPayingUser = ChkIsPayingUser.Checked;
        }

        private void NumAdvancedSupport_ValueChanged(object sender, EventArgs e)
        {
            _auth.AdvancedSupport = (int)NumAdvancedSupport.Value;
        }

        private void ChkIsOverseasService_CheckedChanged(object sender, EventArgs e)
        {
            _auth.IsOverseasService = ChkIsOverseasService.Checked;

        }

        private void TxtRegion_TextChanged(object sender, EventArgs e)
        {
            _auth.Region = TxtRegion.Text;

        }

        private void TxtComments_TextChanged(object sender, EventArgs e)
        {
            _auth.Comments = TxtComments.Text;

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var r = XmlModule.SerializeXml(_auth);
            MessageBox.Show(r);
        }

        private string ShowSaveFileDialog()
        {
            string localFilePath = "";

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Authentication.license（*.license）|*.license",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString();
            }

            return localFilePath;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var path = ShowSaveFileDialog();
            File.WriteAllText(path, XmlModule.SerializeXml(_auth));
        }
    }
}
