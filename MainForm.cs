using System;
using System.Windows.Forms;
using SkidWare.api;

namespace SkidWare
{
    public partial class SkidWareForm : Form
    {
        Synapse synapse = new Synapse();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public SkidWareForm()
        {
            InitializeComponent();
        }

        private void OnSkidWareFormLoad(object sender, EventArgs e)
        {
            synapse.BroadcastEventToLabel(labelStatus);
            synapse.Initialize(this);
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

        private void OnButtonExecuteClicked(object sender, EventArgs e)
        {
            if (!synapse.ExecuteScript(richTextBoxScript.Text))
            {
                MessageBox.Show("Click inject before executing the script", "SkidWare - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void OnButtonInjectClicked(object sender, EventArgs e)
        {
            if (!synapse.AttachToRoblox())
            {
                MessageBox.Show("Cannot inject synapse into roblox", "SkidWare - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void OnButtonMinimizeClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnButtonCloseClicked(object sender, EventArgs e)
        {
            synapse.Unload();
        }

        private void OnButtonCopyleftClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Aiuraa");
        }

        private void OnFormMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
