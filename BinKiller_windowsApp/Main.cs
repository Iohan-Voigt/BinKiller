using System.Media;
using System.Text.Json;

namespace BinKiller_windowsApp
{
    public partial class Main : Form
    {
        private static string _appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);
        private static string filePath = Path.Combine(_appDataFolder, "Paths.json");

        List<string> pathsList = new List<string>();
        int directioriesRemoved;
        public Main()
        {
            InitializeComponent();
            ConfigureFiles();
            UpdatePathList();
            UpdateComboBoxPaths();
            ignoreRepositorieCkb.Checked = false;
            ignoreRepositories.Enabled = false;
            directioriesRemoved = 0;
            cnmstrMain.Items[1].Enabled = false;
            if(DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.vesperadesexta);
                player.Play();
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Apaga memo os arquivo do {directoryCbx.Text}?", "Barbaridade tche", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                DeleteCurrentDirectories();
        }

        #region NOTFYINCON THINGS

        private void ConfigureNotfyIcon()
        {
            notifyIconMain.Visible = true;
            notifyIconMain.Text = "BinKillah";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (MessageBox.Show($"Fechar aplicação?", "Bin Killer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_MINIMIZE = 0xF020;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                switch ((int)m.WParam)
                {
                    case SC_MAXIMIZE:
                        return;

                    case SC_MINIMIZE:
                        this.Hide();
                        ConfigureNotfyIcon();
                        return;
                }
            }
            base.WndProc(ref m);
        }

        private void sendToBandeijaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIconMain.Visible = true;
        }

        private void notifyIconMain_DoubleClick(object sender, EventArgs e)
        {
            notifyIconMain.Visible = false;
            this.Show();
        }

        private void abrirAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIconMain.Visible = false;
            this.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rodarUltimoExpurgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Apaga memo os arquivo do {directoryCbx.Text}?", "Barbaridade tche", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DeleteCurrentDirectories();
            }
        }

        #endregion

        #region SAVE IN JSON
        private void UpdatePathList()
        {
            string json = File.ReadAllText(filePath);
            if(!string.IsNullOrEmpty(json))
                pathsList = JsonSerializer.Deserialize<List<string>>(json);
        }

        private void UpdateComboBoxPaths()
        {
            foreach (var path in pathsList)
            {
                directoryCbx.Items.Add(path);
            }
        }

        private bool pathExistsInList(string path)
        {
            if (pathsList.Contains(path))
            {
                return true;
            }
            return false;
        }

        private void UpdatePathsFile(List<string> files)
        {
            string jsonString = JsonSerializer.Serialize(pathsList, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter w = new StreamWriter(filePath))
            {
                w.WriteLine(jsonString);
            }
        }

        private void AddPathToList(string path)
        {
            if (path == null)
                return;

            if (!pathExistsInList(path))
            {
                pathsList.Add(path);
                UpdatePathsFile(pathsList);
                UpdatePathList();
                UpdateComboBoxPaths();
            }
        }

        #endregion

        #region DELETE FILES

        private void DeleteFiles(string path)
        {
            var directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                if(directory.EndsWith("\\bin") || directory.EndsWith("\\obj"))
                {
                    Directory.Delete(directory, true);
                    directioriesRemoved++;
                }                 
                else
                    DeleteFiles(directory);                                     
            }
        }

        private bool PathIsValid(string path)
        {
            if (Directory.Exists(path))
                return true;

            return false;
        }

        private void DeleteCurrentDirectories()
        {
            if (PathIsValid(directoryCbx.Text))
            {
                directioriesRemoved = 0;
                AddPathToList(directoryCbx.Text);
                DeleteFiles(directoryCbx.Text);
                infoLbl.Text = "Deu boa Piazão :)";
                info2Lbl.Text = $"{directioriesRemoved} Pastas removidas";
                SoundPlayer player = new SoundPlayer(Properties.Resources.succes);
                player.Play();
                cnmstrMain.Items[1].Enabled = true;
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.error);
                player.Play();
                infoLbl.Text = "Caminho Inválido";
                info2Lbl.Text = "";
            }
        }

        #endregion

        private static void ConfigureFiles()
        {
            bool pathExists = Directory.Exists(_appDataFolder);
            if (!pathExists)
            {
                Directory.CreateDirectory(_appDataFolder);
            }

            bool fileExists = File.Exists(filePath);
            if (!fileExists)
            {
                var fs = File.Create(filePath);
                fs.Close();      
            }
        }

        #region EVENTS
        private void ignoreRepositorieCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreRepositorieCkb.Checked)
                ignoreRepositories.Enabled = true;
            else
                ignoreRepositories.Enabled = false;
        }

        #endregion

    }
}