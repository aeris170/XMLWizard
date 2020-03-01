using System.Windows.Forms;
using System.Xml;

namespace Wizard {

    public static class XMLParser {

        //takes an xml document, an xml reader and a contextstrip
        //xml document will be read using the xml reader
        //context strip is for gui
        public static TreeNode ParseXML(XmlDocument doc, XmlReader r, ContextMenuStrip contextMenu) {
            //bug in system.xml
            //must read twice
            doc.ReadNode(r);
            //read the document
            //into the root node
            XmlNode root = doc.ReadNode(r);
            //convert root to a
            //tree node
            TreeNode rv = XMLNodeToTreeNode(root);
            //recursively parse all
            //xml nodes into tree nodes
            ParseXMLRecursive(root, rv, contextMenu);
            //return the
            //root tree node
            return rv;
        }

        //takes a root node, a tree node corresponding to the root node and a contextstrip
        //the root node is an xml node which acts as a root in its own subtree
        //the treenode is the root node but converted to a treenode
        //context strip is for gui
        public static void ParseXMLRecursive(XmlNode root, TreeNode rv, ContextMenuStrip contextMenu) {
            //loop through all nodes in root
            foreach (XmlNode node in root.ChildNodes) {
                //look at the nodes name
                //if node starts with #, discard
                //nodes start with # are
                //#text nodes, and contain the
                //actual data the user will manipulate
                //instead of putting it as an actual child node,
                //i instead show it as a property of the node,
                //which makes more sense
                if (node.Name.StartsWith("#"))  {
                    continue;
                }
                //convert this xml node to a tree node
                TreeNode n = XMLNodeToTreeNode(node);
                //gui set
                n.ContextMenuStrip = contextMenu;
                //add the newly created
                //tree node to its parent
                rv.Nodes.Add(n);
                //recurse, with root as this node
                ParseXMLRecursive(node, n, contextMenu);
            }
        }

        //takes an xml node and converts it to a treenode
        private static TreeNode XMLNodeToTreeNode(XmlNode node) {
            //create a new tree
            //node with nodes name
            //n.Text is now node.Name
            //(ctor assigns it)
            TreeNode n = new TreeNode(node.Name);
            //delete any whitespace in
            //tree node's name
            n.Text = n.Text.Replace(" ", "");
            //loop all children of node
            foreach (XmlNode child in node.ChildNodes) {
                //if you find #text
                if (child.Name.Equals("#text")) {
                    //set the data of tree
                    //node to data of #text
                    n.Tag = node.InnerText;
                    break;
                }
            }
            //return the prepared node for insertion
            return n;
        }
    }
}