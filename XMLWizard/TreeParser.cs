using System;
using System.Windows.Forms;
using System.Xml;

namespace Wizard
{
    public static class TreeParser
    {
        public static XmlNode ParseTree(TreeNode root, XmlDocument doc)
        {
            //TODO DOGA Add Attribute Parsing
            XmlNode rv = TreeNodeToXMLNode(root, doc);
            ParseTreeRecursive(root, doc, rv);
            return rv;
        }

        private static void ParseTreeRecursive(TreeNode root, XmlDocument doc, XmlNode rv)
        {
            if (root.Tag != null && root.Tag.ToString().Length > 0)
            {
                rv.InnerText = root.Tag.ToString();
            }
            foreach (TreeNode node in root.Nodes)
            {
                if (!node.Text.StartsWith("#"))
                {
                    XmlNode n = TreeNodeToXMLNode(node, doc);
                    rv.AppendChild(n);
                    ParseTreeRecursive(node, doc, n);
                }
            }
        }

        private static XmlNode TreeNodeToXMLNode(TreeNode node, XmlDocument doc)
        {
            XmlNode n = doc.CreateElement(node.Text);
            return n;
        }
    }
}
