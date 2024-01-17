namespace MyExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelProperty = new System.Windows.Forms.Panel();
            this.txtDriveInfo = new System.Windows.Forms.TextBox();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.panelDriver = new System.Windows.Forms.Panel();
            this.listDrivers = new System.Windows.Forms.ListBox();
            this.panelTree = new System.Windows.Forms.Panel();
            this.listTypes = new System.Windows.Forms.CheckedListBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.panelInfo.SuspendLayout();
            this.panelProperty.SuspendLayout();
            this.panelDriver.SuspendLayout();
            this.panelTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.panelProperty);
            this.panelInfo.Controls.Add(this.panelDriver);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(278, 603);
            this.panelInfo.TabIndex = 0;
            // 
            // panelProperty
            // 
            this.panelProperty.Controls.Add(this.txtDriveInfo);
            this.panelProperty.Controls.Add(this.txtProperty);
            this.panelProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperty.Location = new System.Drawing.Point(0, 219);
            this.panelProperty.Name = "panelProperty";
            this.panelProperty.Size = new System.Drawing.Size(278, 384);
            this.panelProperty.TabIndex = 1;
            // 
            // txtDriveInfo
            // 
            this.txtDriveInfo.BackColor = System.Drawing.Color.White;
            this.txtDriveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriveInfo.Location = new System.Drawing.Point(10, 3);
            this.txtDriveInfo.Multiline = true;
            this.txtDriveInfo.Name = "txtDriveInfo";
            this.txtDriveInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDriveInfo.Size = new System.Drawing.Size(262, 135);
            this.txtDriveInfo.TabIndex = 1;
            // 
            // txtProperty
            // 
            this.txtProperty.BackColor = System.Drawing.Color.White;
            this.txtProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProperty.Location = new System.Drawing.Point(10, 141);
            this.txtProperty.Multiline = true;
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProperty.Size = new System.Drawing.Size(262, 231);
            this.txtProperty.TabIndex = 0;
            // 
            // panelDriver
            // 
            this.panelDriver.Controls.Add(this.listDrivers);
            this.panelDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDriver.Location = new System.Drawing.Point(0, 0);
            this.panelDriver.Name = "panelDriver";
            this.panelDriver.Size = new System.Drawing.Size(278, 219);
            this.panelDriver.TabIndex = 0;
            // 
            // listDrivers
            // 
            this.listDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDrivers.FormattingEnabled = true;
            this.listDrivers.ItemHeight = 24;
            this.listDrivers.Location = new System.Drawing.Point(10, 20);
            this.listDrivers.Margin = new System.Windows.Forms.Padding(10);
            this.listDrivers.Name = "listDrivers";
            this.listDrivers.Size = new System.Drawing.Size(262, 196);
            this.listDrivers.TabIndex = 0;
            this.listDrivers.SelectedIndexChanged += new System.EventHandler(this.listDrivers_SelectedIndexChanged);
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.listTypes);
            this.panelTree.Controls.Add(this.tree);
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTree.Location = new System.Drawing.Point(278, 0);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(952, 603);
            this.panelTree.TabIndex = 1;
            // 
            // listTypes
            // 
            this.listTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTypes.FormattingEnabled = true;
            this.listTypes.Location = new System.Drawing.Point(760, 20);
            this.listTypes.Name = "listTypes";
            this.listTypes.Size = new System.Drawing.Size(180, 571);
            this.listTypes.TabIndex = 1;
            this.listTypes.SelectedValueChanged += new System.EventHandler(this.listTypes_SelectedValueChanged);
            // 
            // tree
            // 
            this.tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree.Location = new System.Drawing.Point(0, 20);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(754, 571);
            this.tree.TabIndex = 0;
            this.tree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.CollapseTree);
            this.tree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ExpandTree);
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            this.tree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1230, 603);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelInfo.ResumeLayout(false);
            this.panelProperty.ResumeLayout(false);
            this.panelProperty.PerformLayout();
            this.panelDriver.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelProperty;
        private System.Windows.Forms.Panel panelDriver;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.ListBox listDrivers;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.TextBox txtDriveInfo;
        private System.Windows.Forms.TextBox txtProperty;
        private System.Windows.Forms.CheckedListBox listTypes;
    }
}

