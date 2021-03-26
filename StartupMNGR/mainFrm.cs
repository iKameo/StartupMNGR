using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace StartupMNGR
{
    public partial class mainFrm : Form
    {
              
        public mainFrm()
        {
            InitializeComponent();            
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            populateListbox(); 
            this.Text = this.Text + " - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            copyFiles();
            populateListbox();
            clearTextbox();
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            removeShortcut();
            populateListbox();            
        }

        private void btn_testRunItem_Click(object sender, EventArgs e)
        {
            testRun();
        }

        private void btn_openPath_Click(object sender, EventArgs e)
        {
            openPath();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            Form f = new helpFrm();
            f.ShowDialog(this);            
        }

        //------------------- VOIDS -------------------

        //Setup the DragEnter Event
        private void pnl_Shortcut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        
        //Get filepath from dropped Item and add it to the textbox
        private void pnl_Shortcut_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropData = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (dropData != null && dropData.Length != 0)
            {
                tb_droppedData.Text = dropData[0];
            }
        }

        //Clear the Listbox and Populate the listbox, Duh!
        private void populateListbox()
        {
            {
                string allowdExtension = ".lnk";
                //Clear the Listbox
                lb_StartupPrograms.Items.Clear();
                //Get each file in StartupPath
                foreach (string file in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup)))
                {
                    //Only add Shortcut files
                    if (allowdExtension.Contains(".lnk"))
                    {
                        //Cut everything except the filename + extension from the path
                        string shortfilename = Path.GetFileName(file);
                        //Add the shortend path to the listbox
                        lb_StartupPrograms.Items.Add(shortfilename);
                    }
                }
            }


        }

        //Copy the Shortcut into the Startup path and refresh the Listbox
        private void copyFiles()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string fileWithExtension = Path.GetFileName(tb_droppedData.Text);
            File.Copy(tb_droppedData.Text, startupPath + "/" + fileWithExtension, true);            
        }

        //Remove the Shortcut form the Shortcut Folder
        private void removeShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string fileWithExtension = lb_StartupPrograms.SelectedItem.ToString();
            File.Delete(startupPath + "/" + fileWithExtension);
        }

        //Append *.disabled to the shortcut to disable it
        private void disableShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string fileWithExtension = lb_StartupPrograms.SelectedItem.ToString();
            File.Move(startupPath + "/" + fileWithExtension, startupPath + "/" + fileWithExtension + ".disabled");
        }
                
        //Remove *.disabled to the shortcut to enable it
        private void enableShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string fileWithExtension = lb_StartupPrograms.SelectedItem.ToString();
            //File.Move(startupPath + "/" + fileWithExtension, startupPath + "/" + fileWithExtension + ".disabled");
            string combinedPath = startupPath + "/" + fileWithExtension;
            Path.ChangeExtension(combinedPath, null);
        }

        //Test run the Shortcut
        private void testRun()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string fileWithExtension = lb_StartupPrograms.SelectedItem.ToString();            
            Process.Start(startupPath + "/" + fileWithExtension);
        }

        //Open %appdata% path
        private void openPath()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);            
            Process.Start(startupPath);
        }

        //Clear Textbox
        private void clearTextbox()
        {
            tb_droppedData.Clear();
        }


        
    }
}
