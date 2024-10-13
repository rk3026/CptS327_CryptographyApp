using System.Security.Cryptography;
using CryptographyApp.Tabs;
using CryptographyEngine.HashingAlgorithms;

namespace CryptographyApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeTabs();
        }

        private void InitializeTabs()
        {
            var encryptionTab = new TextEncryptionTab();
            encryptionTab.Dock = DockStyle.Fill;
            encryptionTab.AutoSize = true;
            tabControl1.TabPages[0].Controls.Add(encryptionTab);

            var hashingTab = new TextHashingTab();
            hashingTab.Dock = DockStyle.Fill;
            hashingTab.AutoSize = true;
            tabControl1.TabPages[1].Controls.Add(hashingTab);

            var fileEncryptTab = new FileEncryptionTab();
            fileEncryptTab.Dock = DockStyle.Fill;
            fileEncryptTab.AutoSize = true;
            tabControl1.TabPages[2].Controls.Add(fileEncryptTab);
        }
    }
}
