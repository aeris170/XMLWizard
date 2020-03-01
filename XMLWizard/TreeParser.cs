using System.Windows.Forms;
using System.Xml;

namespace Wizard {

    public static class TreeParser {

        //helper for parsing a tree node tree into an xml node tree
        //takes a tree node as the root of a tree node tree, and an xml document
        //the xml document is passed to a converting function because of how System.Xml works (TreeNodeToXMLNode)
        public static XmlNode ParseTree(TreeNode root, XmlDocument doc) {
            //convert the root node to
            //an actual xml node
            XmlNode rv = TreeNodeToXMLNode(root, doc);
            //recursively, convert all children
            //of root tree node to xml nodes
            //and add them to their parents
            //while preserving parent-child
            //relationship
            ParseTreeRecursive(root, doc, rv);
            //return the root node of xml
            //converted from tree nodes
            return rv;
        }

        //parses a treenode tree into an xmlnode tree
        //takes a root node, an xml document and an xml node corresponding to the root node
        //root node is a tree node, root of its own subtree
        //xml document is passed to a converter function because of how System.Xml works (TreeNodeToXMLNode)
        //xml node is the root node itself, but converted to an xml node
        private static void ParseTreeRecursive(TreeNode root, XmlDocument doc, XmlNode rv) {
            //check if the root has any data
            if (root.Tag != null && root.Tag.ToString().Length > 0) {
                //if it does, take its data
                //and put it in xml node's
                //data
                rv.InnerText = root.Tag.ToString();
            }
            //now, loop through all children
            foreach (TreeNode node in root.Nodes) {
                //if a children has #
                //as its first char
                //discard, same as the
                //case in XMLParser class
                if (node.Text.StartsWith("#")) {
                    continue;
                }
                //convert the child tree node
                //to an xml node
                XmlNode n = TreeNodeToXMLNode(node, doc);
                //add converted node as a child to
                //the root node
                rv.AppendChild(n);
                //recurse, with this node as the root node
                ParseTreeRecursive(node, doc, n);
            }
        }

        //converts a tree node to an xml node using the xml document
        private static XmlNode TreeNodeToXMLNode(TreeNode node, XmlDocument doc) {
            //create an xml node with
            //tree nodes data in it
            XmlNode n = doc.CreateElement(node.Text);
            //return the newly created node
            return n;
        }
    }
}