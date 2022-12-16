namespace BinKiller_windowsApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.directoryLbl = new System.Windows.Forms.Label();
            this.directoryCbx = new System.Windows.Forms.ComboBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.info2Lbl = new System.Windows.Forms.Label();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cnmstrMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodarUltimoExpurgoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreRepositorieCkb = new System.Windows.Forms.CheckBox();
            this.ignoreRepositories = new System.Windows.Forms.TextBox();
            this.cnmstrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // directoryLbl
            // 
            this.directoryLbl.AutoSize = true;
            this.directoryLbl.Location = new System.Drawing.Point(12, 9);
            this.directoryLbl.Name = "directoryLbl";
            this.directoryLbl.Size = new System.Drawing.Size(53, 15);
            this.directoryLbl.TabIndex = 0;
            this.directoryLbl.Text = "Diretório";
            // 
            // directoryCbx
            // 
            this.directoryCbx.FormattingEnabled = true;
            this.directoryCbx.Location = new System.Drawing.Point(12, 27);
            this.directoryCbx.Name = "directoryCbx";
            this.directoryCbx.Size = new System.Drawing.Size(264, 23);
            this.directoryCbx.TabIndex = 1;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(12, 111);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(264, 65);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "Fincá fogo ";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(12, 56);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 15);
            this.infoLbl.TabIndex = 3;
            // 
            // info2Lbl
            // 
            this.info2Lbl.AutoSize = true;
            this.info2Lbl.Location = new System.Drawing.Point(12, 164);
            this.info2Lbl.Name = "info2Lbl";
            this.info2Lbl.Size = new System.Drawing.Size(0, 15);
            this.info2Lbl.TabIndex = 4;
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.cnmstrMain;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "notifyIcon1";
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // cnmstrMain
            // 
            this.cnmstrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAplicativoToolStripMenuItem,
            this.rodarUltimoExpurgoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cnmstrMain.Name = "cnmstrMain";
            this.cnmstrMain.Size = new System.Drawing.Size(191, 70);
            // 
            // abrirAplicativoToolStripMenuItem
            // 
            this.abrirAplicativoToolStripMenuItem.Name = "abrirAplicativoToolStripMenuItem";
            this.abrirAplicativoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.abrirAplicativoToolStripMenuItem.Text = "Abrir aplicativo";
            this.abrirAplicativoToolStripMenuItem.Click += new System.EventHandler(this.abrirAplicativoToolStripMenuItem_Click);
            // 
            // rodarUltimoExpurgoToolStripMenuItem
            // 
            this.rodarUltimoExpurgoToolStripMenuItem.Name = "rodarUltimoExpurgoToolStripMenuItem";
            this.rodarUltimoExpurgoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rodarUltimoExpurgoToolStripMenuItem.Text = "Rodar ultimo expurgo";
            this.rodarUltimoExpurgoToolStripMenuItem.Click += new System.EventHandler(this.rodarUltimoExpurgoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // ignoreRepositorieCkb
            // 
            this.ignoreRepositorieCkb.AutoSize = true;
            this.ignoreRepositorieCkb.Location = new System.Drawing.Point(12, 56);
            this.ignoreRepositorieCkb.Name = "ignoreRepositorieCkb";
            this.ignoreRepositorieCkb.Size = new System.Drawing.Size(124, 19);
            this.ignoreRepositorieCkb.TabIndex = 7;
            this.ignoreRepositorieCkb.Text = "Ignorar repositório";
            this.ignoreRepositorieCkb.UseVisualStyleBackColor = true;
            this.ignoreRepositorieCkb.Visible = false;
            this.ignoreRepositorieCkb.CheckedChanged += new System.EventHandler(this.ignoreRepositorieCkb_CheckedChanged);
            // 
            // ignoreRepositories
            // 
            this.ignoreRepositories.Location = new System.Drawing.Point(12, 81);
            this.ignoreRepositories.Name = "ignoreRepositories";
            this.ignoreRepositories.Size = new System.Drawing.Size(264, 23);
            this.ignoreRepositories.TabIndex = 8;
            this.ignoreRepositories.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 188);
            this.Controls.Add(this.ignoreRepositories);
            this.Controls.Add(this.ignoreRepositorieCkb);
            this.Controls.Add(this.info2Lbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.directoryCbx);
            this.Controls.Add(this.directoryLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 227);
            this.MinimumSize = new System.Drawing.Size(307, 227);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BinKiller";
            this.cnmstrMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label directoryLbl;
        private ComboBox directoryCbx;
        private Button runBtn;
        private Label infoLbl;
        private Label info2Lbl;
        private NotifyIcon notifyIconMain;
        private ContextMenuStrip cnmstrMain;
        private ToolStripMenuItem abrirAplicativoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem rodarUltimoExpurgoToolStripMenuItem;
        private CheckBox ignoreRepositorieCkb;
        private TextBox ignoreRepositories;
    }
}