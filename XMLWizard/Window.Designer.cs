using System.ComponentModel;
using System.Windows.Forms;

namespace Wizard
{
    partial class Window
    {
        private System.ComponentModel.IContainer components = null;

        #region Components
        private MainMenu MenuBar;

        private MenuItem FileMenu;

        private MenuItem NewMenuItem;
        private MenuItem OpenMenuItem;
        private MenuItem SaveMenuItem;
        private MenuItem ExitMenuItem;

        private OpenFileDialog FileChooser;
        private SaveFileDialog FileSaver;

        private Panel WrapperPanel;

        private SplitContainer ContentContainer;
        private TreeView XMLContent;
        private PropertyGrid SelectedPropertyPanel;

        private ContextMenuStrip RootNodeContextMenu;
        private ToolStripMenuItem AddChildRootContextMenuItem;
        private ToolStripMenuItem RenameRootContextMenuItem;
        private ToolStripMenuItem DeleteRootContextMenuItem;
        private ToolStripSeparator Separator1;
        private ToolStripMenuItem ExpandRootContextMenuItem;
        private ToolStripMenuItem CollapseRootContextMenuItem;
        private ToolStripMenuItem ExpandAllRootContextMenuItem;
        private ToolStripMenuItem CollapseAllRootContextMenuItem;

        public ContextMenuStrip NodeContextMenu;
        private ToolStripMenuItem AddChildContextMenuItem;
        private ToolStripMenuItem RenameContextMenuItem;
        private ToolStripMenuItem DeleteContextMenuItem;
        private ToolStripSeparator Seperator3;
        private ToolStripMenuItem ExpandContextMenuItem;
        private ToolStripMenuItem CollapseContextMenuItem;
        private ToolStripMenuItem ExpandAllContextMenuItem;
        private ToolStripMenuItem CollapseAllContextMenuItem;
        #endregion

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.RootNodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddChildRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SetValueRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpandAllRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseAllRootContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenu = new System.Windows.Forms.MenuItem();
            this.NewMenuItem = new System.Windows.Forms.MenuItem();
            this.OpenMenuItem = new System.Windows.Forms.MenuItem();
            this.SaveMenuItem = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.FileChooser = new System.Windows.Forms.OpenFileDialog();
            this.SelectedPropertyPanel = new System.Windows.Forms.PropertyGrid();
            this.AddChildContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RenameContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Seperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SetValueContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpandAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLContent = new System.Windows.Forms.TreeView();
            this.XMLContentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExpandAllXMLContentContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseAllXMLContentContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WrapperPanel = new System.Windows.Forms.Panel();
            this.ContentContainer = new System.Windows.Forms.SplitContainer();
            this.FileSaver = new System.Windows.Forms.SaveFileDialog();
            this.RootNodeContextMenu.SuspendLayout();
            this.NodeContextMenu.SuspendLayout();
            this.XMLContentContextMenu.SuspendLayout();
            this.WrapperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentContainer)).BeginInit();
            this.ContentContainer.Panel1.SuspendLayout();
            this.ContentContainer.Panel2.SuspendLayout();
            this.ContentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // RootNodeContextMenu
            // 
            this.RootNodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChildRootContextMenuItem,
            this.RenameRootContextMenuItem,
            this.DeleteRootContextMenuItem,
            this.Separator1,
            this.SetValueRootContextMenuItem,
            this.Separator2,
            this.ExpandRootContextMenuItem,
            this.CollapseRootContextMenuItem,
            this.ExpandAllRootContextMenuItem,
            this.CollapseAllRootContextMenuItem});
            this.RootNodeContextMenu.Name = "XMLContentContextMenu";
            this.RootNodeContextMenu.Size = new System.Drawing.Size(137, 192);
            // 
            // AddChildRootContextMenuItem
            // 
            this.AddChildRootContextMenuItem.Name = "AddChildRootContextMenuItem";
            this.AddChildRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.AddChildRootContextMenuItem.Text = "Add Child";
            this.AddChildRootContextMenuItem.Click += new System.EventHandler(this.AddNode);
            // 
            // RenameRootContextMenuItem
            // 
            this.RenameRootContextMenuItem.Name = "RenameRootContextMenuItem";
            this.RenameRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.RenameRootContextMenuItem.Text = "Rename";
            this.RenameRootContextMenuItem.Click += new System.EventHandler(this.RenameNode);
            // 
            // DeleteRootContextMenuItem
            // 
            this.DeleteRootContextMenuItem.Enabled = false;
            this.DeleteRootContextMenuItem.Name = "DeleteRootContextMenuItem";
            this.DeleteRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DeleteRootContextMenuItem.Text = "Delete";
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(133, 6);
            // 
            // SetValueRootContextMenuItem
            // 
            this.SetValueRootContextMenuItem.Name = "SetValueRootContextMenuItem";
            this.SetValueRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.SetValueRootContextMenuItem.Text = "Set Value";
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(133, 6);
            // 
            // ExpandRootContextMenuItem
            // 
            this.ExpandRootContextMenuItem.Name = "ExpandRootContextMenuItem";
            this.ExpandRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExpandRootContextMenuItem.Text = "Expand";
            this.ExpandRootContextMenuItem.Click += new System.EventHandler(this.ExpandNode);
            // 
            // CollapseRootContextMenuItem
            // 
            this.CollapseRootContextMenuItem.Name = "CollapseRootContextMenuItem";
            this.CollapseRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.CollapseRootContextMenuItem.Text = "Collapse";
            this.CollapseRootContextMenuItem.Click += new System.EventHandler(this.CollapseNode);
            // 
            // ExpandAllRootContextMenuItem
            // 
            this.ExpandAllRootContextMenuItem.Name = "ExpandAllRootContextMenuItem";
            this.ExpandAllRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExpandAllRootContextMenuItem.Text = "Expand All";
            this.ExpandAllRootContextMenuItem.Click += new System.EventHandler(this.ExpandAllNodes);
            // 
            // CollapseAllRootContextMenuItem
            // 
            this.CollapseAllRootContextMenuItem.Name = "CollapseAllRootContextMenuItem";
            this.CollapseAllRootContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.CollapseAllRootContextMenuItem.Text = "Collapse All";
            this.CollapseAllRootContextMenuItem.Click += new System.EventHandler(this.CollapseAllNodes);
            // 
            // MenuBar
            // 
            this.MenuBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenu});
            // 
            // FileMenu
            // 
            this.FileMenu.Index = 0;
            this.FileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.ExitMenuItem});
            this.FileMenu.Text = "File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Index = 0;
            this.NewMenuItem.Text = "New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Index = 1;
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Index = 2;
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 3;
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // FileChooser
            // 
            this.FileChooser.DefaultExt = "XML";
            this.FileChooser.FileName = "FileChooser";
            this.FileChooser.Filter = "Extensible Markup Language Files | *.xml";
            // 
            // SelectedPropertyPanel
            // 
            this.SelectedPropertyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedPropertyPanel.Location = new System.Drawing.Point(3, 3);
            this.SelectedPropertyPanel.Name = "SelectedPropertyPanel";
            this.SelectedPropertyPanel.Size = new System.Drawing.Size(272, 470);
            this.SelectedPropertyPanel.TabIndex = 1;
            this.SelectedPropertyPanel.ToolbarVisible = false;
            this.SelectedPropertyPanel.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.NodeTextChange);
            // 
            // AddChildContextMenuItem
            // 
            this.AddChildContextMenuItem.Name = "AddChildContextMenuItem";
            this.AddChildContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.AddChildContextMenuItem.Text = "Add Child";
            this.AddChildContextMenuItem.Click += new System.EventHandler(this.AddNode);
            // 
            // NodeContextMenu
            // 
            this.NodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChildContextMenuItem,
            this.RenameContextMenuItem,
            this.DeleteContextMenuItem,
            this.Seperator3,
            this.SetValueContextMenuItem,
            this.Separator4,
            this.ExpandContextMenuItem,
            this.CollapseContextMenuItem,
            this.ExpandAllContextMenuItem,
            this.CollapseAllContextMenuItem});
            this.NodeContextMenu.Name = "XMLContentContextMenu";
            this.NodeContextMenu.Size = new System.Drawing.Size(137, 192);
            // 
            // RenameContextMenuItem
            // 
            this.RenameContextMenuItem.Name = "RenameContextMenuItem";
            this.RenameContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.RenameContextMenuItem.Text = "Rename";
            this.RenameContextMenuItem.Click += new System.EventHandler(this.RenameNode);
            // 
            // DeleteContextMenuItem
            // 
            this.DeleteContextMenuItem.Name = "DeleteContextMenuItem";
            this.DeleteContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DeleteContextMenuItem.Text = "Delete";
            this.DeleteContextMenuItem.Click += new System.EventHandler(this.DeleteNode);
            // 
            // Seperator3
            // 
            this.Seperator3.Name = "Seperator3";
            this.Seperator3.Size = new System.Drawing.Size(133, 6);
            // 
            // SetValueContextMenuItem
            // 
            this.SetValueContextMenuItem.Name = "SetValueContextMenuItem";
            this.SetValueContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.SetValueContextMenuItem.Text = "Set Value";
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(133, 6);
            // 
            // ExpandContextMenuItem
            // 
            this.ExpandContextMenuItem.Name = "ExpandContextMenuItem";
            this.ExpandContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExpandContextMenuItem.Text = "Expand";
            this.ExpandContextMenuItem.Click += new System.EventHandler(this.ExpandNode);
            // 
            // CollapseContextMenuItem
            // 
            this.CollapseContextMenuItem.Name = "CollapseContextMenuItem";
            this.CollapseContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.CollapseContextMenuItem.Text = "Collapse";
            this.CollapseContextMenuItem.Click += new System.EventHandler(this.CollapseNode);
            // 
            // ExpandAllContextMenuItem
            // 
            this.ExpandAllContextMenuItem.Name = "ExpandAllContextMenuItem";
            this.ExpandAllContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExpandAllContextMenuItem.Text = "Expand All";
            this.ExpandAllContextMenuItem.Click += new System.EventHandler(this.ExpandAllNodes);
            // 
            // CollapseAllContextMenuItem
            // 
            this.CollapseAllContextMenuItem.Name = "CollapseAllContextMenuItem";
            this.CollapseAllContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.CollapseAllContextMenuItem.Text = "Collapse All";
            this.CollapseAllContextMenuItem.Click += new System.EventHandler(this.CollapseAllNodes);
            // 
            // XMLContent
            // 
            this.XMLContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XMLContent.ContextMenuStrip = this.XMLContentContextMenu;
            this.XMLContent.LabelEdit = true;
            this.XMLContent.Location = new System.Drawing.Point(3, 3);
            this.XMLContent.Name = "XMLContent";
            treeNode1.ContextMenuStrip = this.RootNodeContextMenu;
            treeNode1.Name = "Root";
            treeNode1.Text = "Root";
            this.XMLContent.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.XMLContent.Size = new System.Drawing.Size(377, 470);
            this.XMLContent.TabIndex = 0;
            this.XMLContent.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.AfterNodeTextChange);
            this.XMLContent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfterNodeSelect);
            // 
            // XMLContentContextMenu
            // 
            this.XMLContentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpandAllXMLContentContextMenuItem,
            this.CollapseAllXMLContentContextMenuItem});
            this.XMLContentContextMenu.Name = "XMLContentContextMenu";
            this.XMLContentContextMenu.Size = new System.Drawing.Size(137, 48);
            // 
            // ExpandAllXMLContentContextMenuItem
            // 
            this.ExpandAllXMLContentContextMenuItem.Name = "ExpandAllXMLContentContextMenuItem";
            this.ExpandAllXMLContentContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExpandAllXMLContentContextMenuItem.Text = "Expand All";
            this.ExpandAllXMLContentContextMenuItem.Click += new System.EventHandler(this.ExpandAllNodes);
            // 
            // CollapseAllXMLContentContextMenuItem
            // 
            this.CollapseAllXMLContentContextMenuItem.Name = "CollapseAllXMLContentContextMenuItem";
            this.CollapseAllXMLContentContextMenuItem.Size = new System.Drawing.Size(136, 22);
            this.CollapseAllXMLContentContextMenuItem.Text = "Collapse All";
            this.CollapseAllXMLContentContextMenuItem.Click += new System.EventHandler(this.CollapseAllNodes);
            // 
            // WrapperPanel
            // 
            this.WrapperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WrapperPanel.Controls.Add(this.ContentContainer);
            this.WrapperPanel.Location = new System.Drawing.Point(12, 12);
            this.WrapperPanel.Name = "WrapperPanel";
            this.WrapperPanel.Size = new System.Drawing.Size(671, 484);
            this.WrapperPanel.TabIndex = 2;
            // 
            // ContentContainer
            // 
            this.ContentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentContainer.Location = new System.Drawing.Point(3, 5);
            this.ContentContainer.Name = "ContentContainer";
            // 
            // ContentContainer.Panel1
            // 
            this.ContentContainer.Panel1.Controls.Add(this.XMLContent);
            // 
            // ContentContainer.Panel2
            // 
            this.ContentContainer.Panel2.Controls.Add(this.SelectedPropertyPanel);
            this.ContentContainer.Size = new System.Drawing.Size(665, 476);
            this.ContentContainer.SplitterDistance = 383;
            this.ContentContainer.TabIndex = 2;
            // 
            // FileSaver
            // 
            this.FileSaver.DefaultExt = "XML";
            this.FileSaver.Filter = "Extensible Markup Language Files | *.xml";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(695, 508);
            this.Controls.Add(this.WrapperPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MenuBar;
            this.MinimumSize = new System.Drawing.Size(500, 525);
            this.Name = "Window";
            this.Text = "ResaRf\'s XML Wizard";
            this.RootNodeContextMenu.ResumeLayout(false);
            this.NodeContextMenu.ResumeLayout(false);
            this.XMLContentContextMenu.ResumeLayout(false);
            this.WrapperPanel.ResumeLayout(false);
            this.ContentContainer.Panel1.ResumeLayout(false);
            this.ContentContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContentContainer)).EndInit();
            this.ContentContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private ToolStripMenuItem SetValueRootContextMenuItem;
        private ToolStripSeparator Separator2;
        private ToolStripMenuItem SetValueContextMenuItem;
        private ToolStripSeparator Separator4;
        private ContextMenuStrip XMLContentContextMenu;
        private ToolStripMenuItem ExpandAllXMLContentContextMenuItem;
        private ToolStripMenuItem CollapseAllXMLContentContextMenuItem;
    }
}

