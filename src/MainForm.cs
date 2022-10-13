using System;
using System.IO;
using System.Windows.Forms;

using sxlib;
using sxlib.Specialized;

namespace SkidWare
{
    public partial class SkidWareForm : Form
    {
        private SxLibWinForms sxLib;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public SkidWareForm()
        {
            InitializeComponent();
        }

        private void OnSkidWareFormLoad(object sender, EventArgs e)
        {
            // attach instance
            this.sxLib = SxLib.InitializeWinForms(this, Directory.GetCurrentDirectory());
            sxLib.LoadEvent += this.SynapseLoadEvent;
            sxLib.AttachEvent += this.SynapseAttachEvent;
            sxLib.Load();
        }
        
        private void OnSkidWareFormMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void OnLoadButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog scriptLoad = new OpenFileDialog();
            if (scriptLoad.ShowDialog() == DialogResult.OK)
            {
                richTextBoxScript.LoadFile(scriptLoad.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void OnButtonSaveClicked(object sender, EventArgs e)
        {
            SaveFileDialog scriptSave = new SaveFileDialog();
            if (scriptSave.ShowDialog() == DialogResult.OK)
            {
                richTextBoxScript.SaveFile(scriptSave.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void OnButtonAttachClicked(object sender, EventArgs e)
        {
            sxLib.Attach();
        }

        private void OnButtonExecuteClicked(object sender, EventArgs e)
        {
            sxLib.Execute(richTextBoxScript.Text);
        }

        private void OnButtonMinimizeClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnButtonCloseClicked(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void OnButtonCopyleftClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Aiuraa");
        }

        public void SynapseLoadEvent(SxLibBase.SynLoadEvents Event, object e)
        {
            switch (Event)
            {
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    labelStatus.Text = "Status: Checking whitelist";
                    break;
                case SxLibBase.SynLoadEvents.ALREADY_EXISTING_WL:
                    labelStatus.Text = "Status: Whitelist already existing";
                    break;
                case SxLibBase.SynLoadEvents.CHANGING_WL:
                    labelStatus.Text = "Status: Changing whitelist";
                    break;
                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    labelStatus.Text = "Status: Checking synapse data";
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    labelStatus.Text = "Status: Downloading synapse data";
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    labelStatus.Text = "Status: Downloading the DLLs";
                    break;
                case SxLibBase.SynLoadEvents.FAILED_TO_DOWNLOAD:
                    labelStatus.Text = "Status: Failed to download the data";
                    break;
                case SxLibBase.SynLoadEvents.NOT_ENOUGH_TIME:
                    labelStatus.Text = "Status: Failed to change whitelist, wait 24 hours to change whitelist";
                    break;
                case SxLibBase.SynLoadEvents.NOT_LOGGED_IN:
                    labelStatus.Text = "Status: Failed to check whitelist, log-in using official synapse UI";
                    break;
                case SxLibBase.SynLoadEvents.NOT_UPDATED:
                    labelStatus.Text = "Status: Your synapse file is old, use synapse launcher to update";
                    break;
                case SxLibBase.SynLoadEvents.UNAUTHORIZED_HWID:
                    labelStatus.Text = "Status: Unauthorized HWID, contact synapse staff if you think this is false error";
                    break;
                case SxLibBase.SynLoadEvents.FAILED_TO_VERIFY:
                    labelStatus.Text = "Status: Failed to verify files";
                    MessageBox.Show("SkidWare cannot verify your synapse file, well i guess you get that from unknown source lmao", "SkidWare - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                    break;
                case SxLibBase.SynLoadEvents.UNKNOWN:
                    labelStatus.Text = "Status: Unknown Error";
                    MessageBox.Show("SkidWare encountered unknown error, make sure to tell your antivirus to stay the fuck off from synapse", "SkidWare - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                    break;
                case SxLibBase.SynLoadEvents.READY:
                    labelStatus.Text = "Status: ready to use!";
                    break;
            }
        }
        public void SynapseAttachEvent(SxLibBase.SynAttachEvents Event, object e)
        {
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.CHECKING:
                    labelStatus.Text = "Status: Checking roblox";
                    break;
                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    labelStatus.Text = "Status: Checking whitelist";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_ATTACH:
                    labelStatus.Text = "Status: Failed to attach";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    labelStatus.Text = "Status: Failed to find roblox instances";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_UPDATE:
                    labelStatus.Text = "Status: Failed to update synapse";
                    break;
                case SxLibBase.SynAttachEvents.INJECTING:
                    labelStatus.Text = "Status: Injecting";
                    break;
                case SxLibBase.SynAttachEvents.NOT_INJECTED:
                    labelStatus.Text = "Status: Not injected";
                    break;
                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    labelStatus.Text = "Status: Already injected bozo";
                    break;
                case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
                    labelStatus.Text = "Status: SkidWare running on old synapse version";
                    break;
                case SxLibBase.SynAttachEvents.NOT_UPDATED:
                    labelStatus.Text = "Status: Outdated synapse version";
                    break;
                case SxLibBase.SynAttachEvents.PROC_CREATION:
                    labelStatus.Text = "Status: Detected roblox new instance";
                    break;
                case SxLibBase.SynAttachEvents.PROC_DELETION:
                    labelStatus.Text = "Status: Detected roblox instance being deleted";
                    break;
                case SxLibBase.SynAttachEvents.REINJECTING:
                    labelStatus.Text = "Status: Reinjecting";
                    break;
                case SxLibBase.SynAttachEvents.SCANNING:
                    labelStatus.Text = "Status: Scanning";
                    break;
                case SxLibBase.SynAttachEvents.UPDATING_DLLS:
                    labelStatus.Text = "Status: Updating DLLs";
                    break;
                case SxLibBase.SynAttachEvents.READY:
                    labelStatus.Text = "Status: Successfully attached";
                    break;
            }
        }
    }
}
