using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExplorer
{
    public partial class Form1 : Form
    {
        string fullPath;        
        public Form1()
        {
            InitializeComponent();        
            
            DetectDrivers();
        }

        private void DetectDrivers()
        {
            foreach(DriveInfo drvInfo in DriveInfo.GetDrives())
            {
                listDrivers.Items.Add(drvInfo);
            }
        }

        private void listDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Drive_Attr(listDrivers.SelectedItem.ToString());
            tree.Nodes.Clear();
            DriveInfo d = (DriveInfo)listDrivers.SelectedItem;
            TreeNode rootNode;
            rootNode = new TreeNode(@d.Name);
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;
            rootNode.Tag = "folder";
            tree.Nodes.Add(rootNode);
            
            if (d.IsReady)
            {
                FillNodes(rootNode);
            }
            
        }
        
        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;

            if (File.Exists(tree.SelectedNode.FullPath))
            {
                txtProperty.Text = e.Node.FullPath;
                Display_File_Attr(tree.SelectedNode.FullPath);
            }
            else
            {
                txtProperty.Text = e.Node.FullPath;
                //close file related information                
                Display_Dir_Attr(tree.SelectedNode.FullPath);
            }

        }
        private void Display_Drive_Attr(string drvname)
        {
            DriveInfo drinfo = new DriveInfo(drvname);
            string strInfo = "";

            strInfo += "DriverName:=" + drinfo.Name.ToString() + Environment.NewLine;
            strInfo += "Label:=" + drinfo.VolumeLabel.ToString() + Environment.NewLine;
            strInfo += "FreeSpace:=" + drinfo.TotalFreeSpace.ToString() + Environment.NewLine;
            strInfo += "TotalSize:=" + drinfo.TotalSize.ToString() + Environment.NewLine;

            txtDriveInfo.Text = strInfo;
        }

        private void Display_Dir_Attr(string dirname)
        {

            string strInfo = "";
            try
            {
                DirectoryInfo d = new DirectoryInfo(@dirname);
                strInfo += "Name:=" + d.Name + Environment.NewLine;
                strInfo += "NumberOfFiles:=" + d.GetFiles().Count() + Environment.NewLine;
                strInfo += "Attributes:=" + File.GetAttributes(@dirname) + Environment.NewLine;
                txtProperty.Text = strInfo;
            }
            catch { }
        }

        private void Display_File_Attr(string filename)
        {
            string strInfo = "";
            
            FileInfo f = new FileInfo(@filename);
            strInfo += "Name:=" + f.Name + Environment.NewLine;
            strInfo += "FileSize:=" + f.Length + Environment.NewLine;
            strInfo += "Attributes:=" + File.GetAttributes(@filename) + Environment.NewLine;
            txtProperty.Text = strInfo;
        }

        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                // Look for a file extension.
                //if (File.Exists(e.Node.FullPath))
                    System.Diagnostics.Process.Start(@e.Node.FullPath);
            }
            // If the file is not found, handle the exception and inform the user.
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Error", "File not found or couldn't be opened.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemException)
            {
                //if user accidently double clicks something that is not handled don't through exceptions
            }
        }

        private void FillNodes(TreeNode dirNode)
        {
            DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);
            try
            {
                foreach (DirectoryInfo dirItem in dir.GetDirectories())
                {
                    TreeNode newNode = new TreeNode(dirItem.Name);
                    newNode.Tag = "folder";
                    dirNode.Nodes.Add(newNode);
                    newNode.Nodes.Add("*");
                }

                
                List<string> uncheckedTypes= new List<string>();
                if (listTypes.Items.Count > 0)
                {
                    foreach (var item in listTypes.Items)
                    {
                        if (!listTypes.CheckedItems.Contains(item))
                            uncheckedTypes.Add(item.ToString());
                    }
                }

                foreach (FileInfo fileItem in dir.GetFiles())
                {
                    TreeNode newNode = new TreeNode(fileItem.Name);
                    if(uncheckedTypes.Count == 0 || !uncheckedTypes.Contains(fileItem.Extension.ToLower()))
                        dirNode.Nodes.Add(newNode);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CollapseTree(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 1;
                fullPath = e.Node.Parent.FullPath;
                e.Node.Nodes.Clear();
                e.Node.Nodes.Add("*");
            }
            else
            {
                fullPath = e.Node.FullPath;
            }
        }
        TreeNode currentNode;
        
        private void ExpandTree(object sender, TreeViewEventArgs e)
        {
            currentNode = null;
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.ImageIndex = 2;
                e.Node.SelectedImageIndex = 2;
                fullPath = e.Node.FullPath;
                e.Node.Nodes.Clear();
                currentNode = e.Node;

                listTypes.Items.Clear();

                try {                     
                    DirectoryInfo dir = new DirectoryInfo(currentNode.FullPath);
                    foreach (FileInfo fileItem in dir.GetFiles())
                    {
                        string type = fileItem.Extension;
                        type = type.ToLower();
                        if (!listTypes.Items.Contains(type))
                        {
                            listTypes.Items.Add(type, true);
                        }
                    }
                }
                catch
                {

                }
                FillNodes(currentNode);
            }
            else
            {
                fullPath = e.Node.FullPath;
            }
        }
        
        private void listTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (currentNode == null) return;
            currentNode.Nodes.Clear();
            FillNodes(currentNode);
        }

    }
}
