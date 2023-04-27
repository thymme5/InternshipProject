using GemBox.Document;
using System.Diagnostics;
using System.Drawing.Imaging;
using VerklaringVanOntvangst.Properties;
#pragma warning disable


namespace VerklaringVanOntvangst
{
    public partial class Form1 : Form
    {
        public bool settingsChanged = Properties.Settings.Default.SettingChanged;
        public string defaultPath;
        public int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (settingsChanged == false)
            {
                //default path is desktop path.
                defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            else if (settingsChanged == true)
            {
                defaultPath = Properties.Settings.Default.DefaultPath;
                Properties.Settings.Default.Save();
            }
            txtboxPath.Text = defaultPath;
            
            _TypeInput.SelectedIndex = 0;
            _DeviceType.SelectedIndex = 0;

            WindowState = FormWindowState.Normal;
        }
        public void CreateDocument(string documentType)
        {
            //pull data 
            string _date = DateTime.Today.ToString("dd MMMM yyyy");
            string _name = _Nametxtbx.Text;
            string _type = _TypeInput.Text;
            string _deviceType = _DeviceType.Text;
            string _device = _DeviceTxtbx.Text;
            string _serialnr = _SerialnrInput.Text;
            string _ID = "(" + _IDinput.Text + ")";
            string _filePath = txtboxPath.Text;
            
            try
            {
                Image logoFile = Properties.Resources.logo_example;
                Image signatureFile = Properties.Resources.signature_example1;

                var logoStream = GetStream(logoFile, logoFile.RawFormat);
                var signatureStream = GetStream(signatureFile, signatureFile.RawFormat);

                ComponentInfo.SetLicense("FREE-LIMITED-KEY");
                var document = new DocumentModel();

                var logo = new Picture(document, logoStream, 245, 89);
                var signature = new Picture(document, signatureStream, 3.22, 2.87, LengthUnit.Centimeter);

                FloatingLayout layout = new FloatingLayout(
                    new HorizontalPosition(13.5, LengthUnit.Centimeter, HorizontalPositionAnchor.Page),
                    new VerticalPosition(22.19, LengthUnit.Centimeter, VerticalPositionAnchor.Page),
                signature.Layout.Size);
                FloatingLayout textLayout = new FloatingLayout(
                    new HorizontalPosition(HorizontalPositionType.Right, HorizontalPositionAnchor.Page),
                    new VerticalPosition(24, LengthUnit.Centimeter, VerticalPositionAnchor.Page),
                    layout.Size
                    );
                signature.Layout = layout;

                try
                {
                    document.Sections.Add(
                           new GemBox.Document.Section(document,
                               new GemBox.Document.Paragraph(document, logo),
                               new GemBox.Document.Paragraph(document,
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new Run(document, _date) { CharacterFormat = { Bold = true, Position = 20, Size = 16 } },
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new Run(document, "VERKLARING VAN " + _type.ToUpper() + " " + _deviceType.ToUpper()) { CharacterFormat = { Size = 20, UnderlineStyle = UnderlineType.Single } },
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new Run(document, "Ondergetekende: "),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new Run(document, _name.ToUpper()),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new Run(document, "Heeft ontvangen: "),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new Run(document, _device.ToUpper()),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new Run(document, _serialnr),
                               new Run(document, " "),
                               new Run(document, _ID),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new Run(document, "Bij ondertekening verklaart de ontvanger zich akkoord met de regelgeving ") { CharacterFormat = { Position = -80, Size = 9 } },
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new Run(document, "omschreven in de IT-policy van INFANO VZW.") { CharacterFormat = { Size = 9 } },
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new Run(document, "Voor ontvangst en akkoord,"),
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new Run(document, "Werknemer") { CharacterFormat = { Position = -160 } },
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new SpecialCharacter(document, SpecialCharacterType.Tab),
                               new Run(document, "ICT Beheerder") { CharacterFormat = { Position = -160 } },
                               new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                               new Run(document, _name.ToUpper())),
                               new GemBox.Document.Paragraph(document, signature))) ;
                }
                catch
                {
                    MessageBox.Show("Error 3");
                }
                try
                {
                    document.Save(_filePath + "\\" + documentType.Trim());
                }
                catch
                {
                    MessageBox.Show("Error 2");
                }
                MessageBox.Show("Bestand gemaakt op " + _filePath + "\\" + documentType, "Succes", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Error 1");
            }
        }
        public Stream GetStream(Image img, ImageFormat format)
        {
            try
            {
                var ms = new MemoryStream();
                img.Save(ms, format);
                return ms;
            }
            catch (Exception)
            {
                MessageBox.Show("Error 4", "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        private void _IDinput_TextChanged(object sender, EventArgs e)
        {

        }
        private void _IDinput_KeyDown(object sender, KeyEventArgs e)
        {
            string sVal = _IDinput.Text;
            string newst = sVal + "-";

            if (_IDinput.Text.Length == 2)
            {
                if (e.KeyCode != Keys.Back)
                {
                    _IDinput.Text = newst;
                    _IDinput.SelectionStart = _IDinput.Text.Length;
                }
            }
            if (_IDinput.Text.Length == 6)
            {
                if (e.KeyCode != Keys.Back)
                {
                    _IDinput.Text = newst;
                    _IDinput.SelectionStart = _IDinput.Text.Length;
                }
            }
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Ben je zeker dat je een PDF wilt maken? De opmaak is niet optimaal", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogresult == DialogResult.Yes)
            {

                //the following code is ineffective, but I decided to keep it in.
                bool checkIfEmpty = CheckIfEmpty();

                string documentName = _DocumentNametxtbox.Text + ".docx";
                string path = txtboxPath.Text + "\\" + documentName;

                string pdfName = _DocumentNametxtbox.Text + ".pdf";
                string _PDFfilePath = txtboxPath.Text + "\\" + _DocumentNametxtbox.Text + ".pdf";

                var printerName = "Microsoft Print to PDF";

                if (checkIfEmpty == true)
                {
                    MessageBox.Show("Gelieve alle velden in te vullen.");
                }
                else
                {
                    CreateDocument(documentName.Trim());

                    DocumentModel document = DocumentModel.Load(path);
                    document.Save(_PDFfilePath);
                    document.Print(printerName);
                    Process.Start("explorer.exe", _PDFfilePath);
                }
            }
        }
        private void btnDOCX_Click_1(object sender, EventArgs e)
        {
            Settings.Default.DefaultPath = txtboxPath.ToString();
            Settings.Default.SettingChanged = false;
            defaultPath = Properties.Settings.Default.DefaultPath;
            Settings.Default.Save();

                try
                {
                    bool checkIfEmpty = CheckIfEmpty();
                    string _filePath = txtboxPath.Text;
                    string documentName = _DocumentNametxtbox.Text + ".docx";

                    if (checkIfEmpty == true)
                    {
                        MessageBox.Show("Gelieve alle velden in te vullen.");
                    }
                    else
                    {
                        CreateDocument(documentName);
                        if (_OpenFileCheckBox.Checked == true)
                        {
                            Process.Start("explorer.exe", _filePath + "\\" + documentName);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error 6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void _DocumentNametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkCharacter(e);
        }

        private void _IDinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkCharacter(e);
        }
        private void checkCharacter(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Bent u zeker dat u alle waarden wilt verwijderen? Deze actie kan niet ongedaan worden gemaakt.", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes) 
                {
                    _TypeInput.Text = null;
                    _DeviceType.Text = null;
                    _Nametxtbx.Text = null;
                    _DeviceTxtbx.Text = null;
                    _SerialnrInput.Text = null;
                    _IDinput.Text = null;
                    _DocumentNametxtbox.Text = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kan waarden niet verwijderen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            _TypeInput.Text = "Ontvangst";
            _DeviceType.Text = "Laptop";
            _Nametxtbx.Text = "John Doe";
            _DeviceTxtbx.Text = "MAC";
            _SerialnrInput.Text = "7407178904";
            _IDinput.Text = "LT-001-2019";
            _DocumentNametxtbox.Text = "Test";
            txtboxPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            index++;

            if (index % 5 == 0)
            {
                btnPDF.Location = new Point(31, 297);
            }
            if (index % 10 == 0 )
            btnPDF.Location = new Point(178, 392);
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtboxPath.Text = fbd.SelectedPath;
            }
        }
        public bool CheckIfEmpty()
        {
            if (string.IsNullOrEmpty(_TypeInput.Text) || string.IsNullOrEmpty(_DeviceType.Text) || string.IsNullOrEmpty(_Nametxtbx.Text) || string.IsNullOrEmpty(_DeviceTxtbx.Text) || string.IsNullOrEmpty(_SerialnrInput.Text) || string.IsNullOrEmpty(_IDinput.Text) || string.IsNullOrEmpty(_DocumentNametxtbox.Text) || string.IsNullOrEmpty(txtboxPath.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void _PrintCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void afsluitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error code 1: problemen met bestanden in te laden \nError code 2: Het pad dat u hebt opgegeven bestaan niet (meer) of u hebt al een bestand met dezelfde naam geopend op het gegeven pad.\nError code 3: Probleem met aanmaken bestand. Mogelijks word het bestand geblokkeerd door een anti-virus software.\nError code 4: Er is mogelijks een probleem met de FileStream. \nError code 5: Ongekende error. Gelieve deze te melden aan uw favoriete IT beheerder. \nError 6: Er was een probleem met het roepen van de functie \"btnDOCX_click\". Controleer of het pad nog bestaat en explorer.exe geopend mag worden. \n \nInfano VZW ©" + DateTime.Today.ToString("yyyy"), "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void feedbackVerzendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
        private void testKnopInschakelenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (testKnopInschakelenToolStripMenuItem.Checked == false)
            {
                btnTest.Enabled = false;
                btnTest.Visible = false;
            }
            if (testKnopInschakelenToolStripMenuItem.Checked == true)
            {
                btnTest.Enabled = true;
                btnTest.Visible = true;
            }
        }
    } 
}
