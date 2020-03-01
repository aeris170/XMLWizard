using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Wizard {

    public partial class Window : Form {

        public Window() {
            InitializeComponent();
            XMLContent.NodeMouseClick += (sender, e) => XMLContent.SelectedNode = e.Node;
        }

        private void NewMenuItem_Click(object sender, EventArgs e) {
            XMLContent.Nodes.Clear();
            XMLContent.SelectedNode = XMLContent.Nodes.Add("Root");
            XMLContent.SelectedNode.ContextMenuStrip = RootNodeContextMenu;
        }

private void OpenMenuItem_Click(object sender, EventArgs e) {
    DialogResult result = FileChooser.ShowDialog();
    if (result == DialogResult.OK) {
        string file = FileChooser.FileName;
        try {
            XmlReaderSettings settings = new XmlReaderSettings {
                XmlResolver = new XmlUrlResolver(),
                DtdProcessing = DtdProcessing.Ignore,
                IgnoreComments = true,
                IgnoreWhitespace = true,
                IgnoreProcessingInstructions = true,
                CheckCharacters = false,
            };
            XmlReader r = XmlReader.Create(file, settings);
            XmlDocument doc = new XmlDocument();
            XMLContent.Nodes.Clear();
            TreeNode newRoot = XMLParser.ParseXML(doc, r, NodeContextMenu);
            newRoot.ContextMenuStrip = RootNodeContextMenu;
            XMLContent.Nodes.Add(newRoot);
            XMLContent.SelectedNode = newRoot;
        }
        catch (IOException) {}
    }
}

private void SaveMenuItem_Click(object sender, EventArgs e) {
    FileSaver.FileName = "MyXMLDocument.xml";
    DialogResult result = FileSaver.ShowDialog();
    if (result == DialogResult.OK && FileSaver.FileName != "") {
        XmlDocument x = new XmlDocument();
        XmlNode root = TreeParser.ParseTree(XMLContent.Nodes[0], x);
        x.AppendChild(root);
        x.Save(FileSaver.FileName);
    }
}

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void AddNode(object sender, EventArgs e) {
            if(XMLContent.SelectedNode == null) {
                XMLContent.SelectedNode = XMLContent.Nodes.Add("Root");
            } else {
                XMLContent.SelectedNode.Nodes.Add("NewChild").ContextMenuStrip = this.NodeContextMenu;
                XMLContent.SelectedNode.Expand();
            }
        }

        private void RenameNode(object sender, EventArgs e) {
            string s = RenamePrompt.ShowDialog();
            if (s != null && s.Length > 0) {
                XMLContent.SelectedNode.Text = s;
                AfterNodeSelect(sender, null);
            }
        }

        private void DeleteNode(object sender, EventArgs e) {
            XMLContent.Nodes.Remove(XMLContent.SelectedNode);
        }

        private void AfterNodeSelect(object sender, TreeViewEventArgs e) {
            DynamicTypeDescriptor dt = new DynamicTypeDescriptor(typeof(TreeNode));
            dt.RemoveProperty("Name");
            dt.RemoveProperty("ToolTipText");
            dt.RemoveProperty("Checked");
            dt.RemoveProperty("ContextMenu");
            dt.RemoveProperty("ContextMenuStrip");
            dt.RemoveProperty("ImageIndex");
            dt.RemoveProperty("ImageKey");
            dt.RemoveProperty("Index");
            dt.RemoveProperty("SelectedImageIndex");
            dt.RemoveProperty("SelectedImageKey");
            dt.RemoveProperty("StateImageIndex");
            dt.RemoveProperty("StateImageKey");
            SelectedPropertyPanel.SelectedObject = dt.FromComponent(XMLContent.SelectedNode);
        }

        private void AfterNodeTextChange(object sender, NodeLabelEditEventArgs e) {
            BeginInvoke(new Action(() => {
                TreeNode selectedNode = XMLContent.SelectedNode;
                selectedNode.Text = selectedNode.Text.Replace(" ", "");
                AfterNodeSelect(sender, null);
            }));
        }

        private void NodeTextChange(object sender, PropertyValueChangedEventArgs e) {
            TreeNode selectedNode = XMLContent.SelectedNode;
            selectedNode.Text = selectedNode.Text.Replace(" ", "");
            AfterNodeSelect(sender, null);
        }

        private void ExpandNode(object sender, EventArgs e) {
            XMLContent.SelectedNode.Expand();
        }

        private void ExpandAllNodes(object sender, EventArgs e) {
            XMLContent.ExpandAll();
        }

        private void CollapseNode(object sender, EventArgs e) {
            XMLContent.SelectedNode.Collapse();
        }

        private void CollapseAllNodes(object sender, EventArgs e) {
            XMLContent.CollapseAll();
        }
    }
}
