using System;
using System.IO;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace SkidWare.api
{
    class Synapse
    {
        // Internal variable, no need to expose
        private SxLibWinForms instance;
        private Label attachedLabel;
        private SxLibBase.SynAttachEvents attachEvent;

        public void SynapseLoadEvent(SxLibBase.SynLoadEvents Event, object e)
        {
            switch (Event)
            {
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    attachedLabel.Text = "Status: Checking whitelist";
                    break;
                case SxLibBase.SynLoadEvents.ALREADY_EXISTING_WL:
                    attachedLabel.Text = "Status: Whitelist already existing";
                    break;
                case SxLibBase.SynLoadEvents.CHANGING_WL:
                    attachedLabel.Text = "Status: Changing whitelist";
                    break;
                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    attachedLabel.Text = "Status: Checking synapse data";
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    attachedLabel.Text = "Status: Downloading synapse data";
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    attachedLabel.Text = "Status: Downloading the DLLs";
                    break;
                case SxLibBase.SynLoadEvents.FAILED_TO_DOWNLOAD:
                    attachedLabel.Text = "Status: Failed to download the data";
                    break;
                case SxLibBase.SynLoadEvents.NOT_ENOUGH_TIME:
                    attachedLabel.Text = "Status: Failed to change whitelist, wait 24 hours to change whitelist";
                    break;
                case SxLibBase.SynLoadEvents.NOT_LOGGED_IN:
                    attachedLabel.Text = "Status: Failed to check whitelist, log-in using official synapse UI";
                    break;
                case SxLibBase.SynLoadEvents.NOT_UPDATED:
                    attachedLabel.Text = "Status: Your synapse file is old, use synapse launcher to update";
                    break;
                case SxLibBase.SynLoadEvents.UNAUTHORIZED_HWID:
                    attachedLabel.Text = "Status: Unauthorized HWID, contact synapse staff if you think this is false error";
                    break;
                case SxLibBase.SynLoadEvents.FAILED_TO_VERIFY:
                    attachedLabel.Text = "Status: Failed to verify files";
                    MessageBox.Show("SkidWare cannot verify your synapse file, well i guess you get that from unknown source lmao", "SkidWare - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Unload();
                    break;
                case SxLibBase.SynLoadEvents.UNKNOWN:
                    attachedLabel.Text = "Status: Unknown Error";
                    MessageBox.Show("SkidWare encountered unknown error, make sure to tell your antivirus to stay the fuck off from synapse", "SkidWare - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Unload();
                    break;
                case SxLibBase.SynLoadEvents.READY:
                    attachedLabel.Text = "Status: SkidWare is ready to use!";
                    break;
            }
        }
        public void SynapseAttachEvent(SxLibBase.SynAttachEvents Event, object e)
        {
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.CHECKING:
                    attachedLabel.Text = "Status: Checking roblox";
                    break;
                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    attachedLabel.Text = "Status: Checking whitelist";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_ATTACH:
                    attachedLabel.Text = "Status: Failed to attach";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    attachedLabel.Text = "Status: Failed to find roblox instances";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_UPDATE:
                    attachedLabel.Text = "Status: Failed to update synapse";
                    break;
                case SxLibBase.SynAttachEvents.INJECTING:
                    attachedLabel.Text = "Status: Injecting";
                    break;
                case SxLibBase.SynAttachEvents.NOT_INJECTED:
                    attachedLabel.Text = "Status: Not injected";
                    break;
                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    attachedLabel.Text = "Status: Already injected bozo";
                    break;
                case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
                    attachedLabel.Text = "Status: SkidWare running on old synapse version";
                    break;
                case SxLibBase.SynAttachEvents.NOT_UPDATED:
                    attachedLabel.Text = "Status: Outdated synapse version";
                    break;
                case SxLibBase.SynAttachEvents.PROC_CREATION:
                    attachedLabel.Text = "Status: Detected roblox new instance";
                    break;
                case SxLibBase.SynAttachEvents.PROC_DELETION:
                    attachedLabel.Text = "Status: Detected roblox instance being deleted";
                    break;
                case SxLibBase.SynAttachEvents.REINJECTING:
                    attachedLabel.Text = "Status: Reinjecting";
                    break;
                case SxLibBase.SynAttachEvents.SCANNING:
                    attachedLabel.Text = "Status: Scanning";
                    break;
                case SxLibBase.SynAttachEvents.UPDATING_DLLS:
                    attachedLabel.Text = "Status: Updating DLLs";
                    break;
                case SxLibBase.SynAttachEvents.READY:
                    attachedLabel.Text = "Status: Successfully attached";
                    break;
            }

            attachEvent = Event;
        }

        public void Initialize(Form form)
        {
            // attach instance
            this.instance = SxLib.InitializeWinForms(form, Directory.GetCurrentDirectory());
            instance.LoadEvent += this.SynapseLoadEvent;
            instance.AttachEvent += this.SynapseAttachEvent;
            
            instance.Load();
        }

        public void BroadcastEventToLabel(Label label)
        {
            attachedLabel = label;
        }

        public bool ExecuteScript(string script)
        {
            instance.Execute(script);

            if (attachEvent.Equals(SxLibBase.SynAttachEvents.NOT_INJECTED))
            {
                return false;
            }

            return true;
        }

        public bool AttachToRoblox()
        {
            return instance.Attach();
        }

        public void Unload()
        {
            instance.Close();
            Environment.Exit(Environment.ExitCode);
        }
    }
}
