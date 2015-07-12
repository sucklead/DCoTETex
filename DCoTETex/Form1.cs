using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.IO;
using System.Threading;

namespace DCoTETex
{
    public partial class Form1 : Form
    {
        byte[] byteArray;
        //String xbdFilename;
        //String xbdDirName;

        string resourceDir;
        string backgroundDir;
        string ddsDir;


        public Form1()
        {
            InitializeComponent();
        }

        #region UI
        private void Log(string logString)
        {
            if (!cbLogEnabled.Checked)
                return;
            ListViewItem lvItem = lvLogArea.Items.Add(logString);
            lvItem.EnsureVisible();
            lvLogArea.Refresh();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            SelectInstallDir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SelectDDSDir();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            GenerateFileLists();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            /*Thread thread = new Thread(new ThreadStart(DoExport));
            thread.Start();*/
            DoExport();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            /*Thread thread = new Thread(new ThreadStart(DoImport));
            thread.Start();*/
            DoImport();
        }

        private void SelectInstallDir()
        {
            fbInstallDir.Description = "Please select your base install directory for DCoTE";

            if (fbInstallDir.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            tbInstallDir.Text = fbInstallDir.SelectedPath;
            if (!tbInstallDir.Text.EndsWith(@"\"))
                tbInstallDir.Text += @"\";
        }

        private void SelectDDSDir()
        {
            fbInstallDir.Description = "Please select your base directory for DDS files";

            if (fbInstallDir.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            tbDDSDir.Text = fbInstallDir.SelectedPath;
            if (!tbDDSDir.Text.EndsWith(@"\"))
                tbDDSDir.Text += @"\";
        }

        private void GenerateFileLists()
        {
            //DEBUG
            //tbInstallDir.Text = @"D:\GAMES\Call Of Cthulhu DCoTE\";

            resourceDir = tbInstallDir.Text + @"Resources\Xbox\";
            backgroundDir = tbInstallDir.Text + @"Backgrounds\";
            ddsDir = tbDDSDir.Text;

            if (!Directory.Exists(resourceDir)
                || !Directory.Exists(backgroundDir))
            {
                MessageBox.Show("Couldn't locate resources from given directory");
                return;
            }

            if (!Directory.Exists(ddsDir))
            {
                MessageBox.Show("Couldn't locate DDS directory");
                return;
            }


            gbMain.Enabled = true;
            gbHeader.Enabled = false;

            //add files in resourceDir to list
            foreach (String fileName in Directory.GetFiles(resourceDir, "*.pc.xbd"))
            {
                lbFiles.Items.Add(fileName.Replace(resourceDir,""));
            }


            //add files in backgroundDir to list
            foreach (String dirName in Directory.GetDirectories(backgroundDir))
            {

                foreach (String fileName in Directory.GetFiles(dirName, "*.pc.naf"))
                {
                    lbFiles.Items.Add(fileName.Replace(backgroundDir, ""));

                }
            }


        }

        private void EnableControls()
        { 
            btnExport.Enabled = true;
            btnImport.Enabled = true;
        }

        private void DisableControls()
        {
            btnExport.Enabled = false;
            btnImport.Enabled = false;
        }

        private void DoImport()
        {
            DisableControls();
            lvLogArea.Items.Clear();

            pbFiles.Maximum = lbFiles.SelectedItems.Count;
            pbFiles.Value = 0;
            foreach (string fileName in lbFiles.SelectedItems)
            {
                ImportTextures(fileName);
                if (this.IsDisposed) return;
                pbFiles.Value += 1;
            }
            EnableControls();
        }

        private void DoExport()
        {
            DisableControls();
            lvLogArea.Items.Clear();

            pbFiles.Maximum = lbFiles.SelectedItems.Count;
            pbFiles.Value = 0;
            foreach (string fileName in lbFiles.SelectedItems)
            {
                ExportTextures(fileName);
                if (this.IsDisposed) return;
                pbFiles.Value += 1;
            }
            EnableControls();
        }


        private void lvLogArea_Resize(object sender, EventArgs e)
        {
            lvLogArea.Columns[0].Width = lvLogArea.Width - 5;
        }
        #endregion UI
    
        private void ImportTextures(string fileName)
        {
            string xbdFileName;

            //create output dir if needed
            string subDir;
            if (fileName.Contains(@"\"))
            {
                xbdFileName = backgroundDir + fileName;
                subDir = ddsDir + fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);
                fileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
            }
            else
            {
                xbdFileName = resourceDir + fileName;
                subDir = ddsDir + fileName + @"\";
            }
            if (!Directory.Exists(subDir))
            {
                Log("Directory " + subDir + " not found.");
                return;
            }

            //load the input file
            Log("Importing from directory " + subDir + ".");

            if (!File.Exists(xbdFileName))
            {
                Log("Couldn't load " + xbdFileName + ".");
                return;
            }

            //backup file
            if (!File.Exists(xbdFileName + ".original"))
            {
                File.Copy(xbdFileName, xbdFileName + ".original");
                Log("Copying file " + xbdFileName);
                Log("to " + xbdFileName + ".original" + ".");
            }

            byteArray = File.ReadAllBytes(xbdFileName);

            int fileSize = byteArray.Length;

            foreach (String ddsFileName in Directory.GetFiles(subDir, fileName + "*"))
            {
                Application.DoEvents();
                if (this.IsDisposed) return;

                int indexStart, indexLength;
                indexStart = ddsFileName.LastIndexOf('_') + 1;
                indexLength = ddsFileName.LastIndexOf('.') - indexStart;
                int ddsStart = int.Parse(ddsFileName.Substring(indexStart, indexLength));
                Log("Importing " + ddsFileName + " at offset " + ddsStart.ToString() + ".");

                byte[] fileBytes = File.ReadAllBytes(ddsFileName);

                fileBytes.CopyTo(byteArray, ddsStart);

            }

            //save file
            File.WriteAllBytes(xbdFileName, byteArray);
            Log("Writing file " + xbdFileName + ".");

        }

        private void ExportTextures(string fileName)
        {
            string xbdFileName;

            //create output dir if needed
            string subDir;
            if (fileName.Contains(@"\"))
            {
                xbdFileName = backgroundDir + fileName;
                subDir = ddsDir + fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);
                fileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                Log(fileName);
            }
            else
            {
                xbdFileName = resourceDir + fileName;
                subDir = ddsDir + fileName + @"\";
                Log(fileName);
            }
            if (!Directory.Exists(subDir))
            {
                Log("Creating directory " + subDir + ".");
                Directory.CreateDirectory(subDir);
            }


            //load the input file
            Log("Exporting to directory " + subDir + ".");

            if (!File.Exists(xbdFileName))
            {
                Log("Couldn't load " + xbdFileName + ".");
                return;
            }

            byteArray = File.ReadAllBytes(xbdFileName);

            int fileSize = byteArray.Length;

            Log("   Parsing " + xbdFileName + " ...");

            pbProgress.Maximum = fileSize;


            for (int i = 0;i < fileSize;i++)
            {
                if (i % 100 == 0)
                {
                    Application.DoEvents();
                    if (this.IsDisposed) return;
                    pbProgress.Value = i;
                }

                if (byteArray[i] == 0x44
                    && byteArray[i + 1] == 0x44
                    && byteArray[i + 2] == 0x53
                    && byteArray[i + 3] == 0x20
                    && byteArray[i + 4] == 0x7C
                   )
                {
                    int dwHeight;
                    int dwWidth;
                    int dwMips;
                    int ddsSize;

                    int ddsStart = i;

                    Log("   DDS at " + i.ToString());

                    dwHeight = byteArray[i + 12]
                               + (byteArray[i + 13] * 256)
                               + (byteArray[i + 14] * 256 * 256)
                               + (byteArray[i + 15] * 256 * 256 * 256);
                    dwWidth = byteArray[i + 16]
                               + (byteArray[i + 17] * 256)
                               + (byteArray[i + 18] * 256 * 256)
                               + (byteArray[i + 19] * 256 * 256 * 256);
                    Log("       Height=" + dwHeight.ToString() + "  Width=" + dwWidth.ToString());

                    dwMips = byteArray[i + 28]
                               + (byteArray[i + 29] * 256)
                               + (byteArray[i + 30] * 256 * 256)
                               + (byteArray[i + 31] * 256 * 256 * 256);

                    Log("       Mips=" + dwMips.ToString());

//DXT1: Max( 1, X/4 ) * Max( 1, Y/4 ) * 8 bytes
//DXT2-5: Max( 1, X/4 ) * Max( 1, Y/4 ) * 16 bytes

                    ddsSize = 128; //header
                    int mipSize;

                    int mipHeight, mipWidth;

                    mipHeight = dwHeight / 4;
                    if (mipHeight < 1)
                        mipHeight = 1;

                    mipWidth = dwWidth / 4;
                    if (dwWidth < 1)
                        dwWidth = 1;

                    mipSize = mipHeight * mipWidth * 16;

                    ddsSize += mipSize;

                    Log("       Mipsize 1 for " + dwWidth.ToString() + " by " + dwHeight.ToString() + " " + " = " + mipSize.ToString());
                    
                    for (int mip = 2; mip <= dwMips; mip++)
                    {
                        dwHeight = dwHeight / 2;
                        if (dwHeight < 1)
                            dwHeight = 1;
                        dwWidth = dwWidth / 2;
                        if (dwWidth < 1)
                            dwWidth = 1;

                        mipHeight = dwHeight / 4;
                        if (mipHeight < 1)
                            mipHeight = 1;

                        mipWidth = dwWidth / 4;
                        if (dwWidth < 1)
                            dwWidth = 1;

                        mipSize = mipHeight * mipWidth * 16;

                        //max(1, width ÷ 4) x max(1, height ÷ 4) x 16
                        if (mipSize < 16)
                            mipSize = 16;

                        Log("       Mipsize " + mip.ToString() + " for " + dwWidth.ToString() + " by " + dwHeight.ToString() + " "  + " = " + mipSize.ToString());

                        ddsSize += mipSize;
                    }
                    Log("       Computed Filesize = " + ddsSize.ToString());

                    String outFile = subDir + fileName + "_" + ddsStart.ToString() + ".dds";

                    try {
                        FileStream fileStream = File.Create(outFile);
                        fileStream.Write(byteArray, i, ddsSize);
                        fileStream.Flush();
                        fileStream.Close();
                    }
                    catch { 
                    
                    }

                    Log("       Writing DDS at " + ddsStart.ToString() + " to " + outFile + ".");

                    i = i + ddsSize;

                }
            }

            pbProgress.Value = fileSize;

            Log("   File Parsed.");
        }

    }
}