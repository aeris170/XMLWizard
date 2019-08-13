using System;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public static class XMLParser
    {
        public static TreeNode ParseXML(XmlDocument doc, XmlReader r, ContextMenuStrip contextMenu)
        {
            doc.ReadNode(r);
            XmlNode root = doc.ReadNode(r);
            TreeNode rv = XMLNodeToTreeNode(root);
            ParseXMLRecursive(root, rv, contextMenu);
            return rv;
        }

        public static void ParseXMLRecursive(XmlNode root, TreeNode rv, ContextMenuStrip contextMenu)
        {
            foreach (XmlNode node in root.ChildNodes)
            {
                if (!node.Name.StartsWith("#"))
                {
                    TreeNode n = XMLNodeToTreeNode(node);
                    n.ContextMenuStrip = contextMenu;
                    rv.Nodes.Add(n);
                    ParseXMLRecursive(node, n, contextMenu);
                }
            }
        }

        private static TreeNode XMLNodeToTreeNode(XmlNode node)
        {
            TreeNode n = new TreeNode(node.Name);
            n.Text = n.Text.Replace(" ", "");
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Name.Equals("#text"))
                {
                    n.Tag = node.InnerText;
                    break;
                }
            }
            return n;
        }
    }
}