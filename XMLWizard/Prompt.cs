using System.Windows.Forms;

namespace Wizard
{
    public static class RenamePrompt
    {
        public static string ShowDialog()
        {
            Form prompt = new Form()
            {
                Height = 165,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Rename Node",
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 25, Top = 20, Text = "Enter New Name: (Spaces not allowed)" };
            TextBox textBox = new TextBox() { Left = 25, Top = 40, Width = 225 };
            Button okButton = new Button() { Text = "Ok", Left = 25, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            Button cancelButton = new Button() { Text = "Cancel", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            okButton.Click += (sender, e) => { prompt.Close(); };
            cancelButton.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(okButton);
            prompt.Controls.Add(cancelButton);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = okButton;
            prompt.CancelButton = cancelButton;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text.Replace(" ", "") : null;
        }
    }
}
