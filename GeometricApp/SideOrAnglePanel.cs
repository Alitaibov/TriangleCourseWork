using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricApp
{
    class SideOrAnglePanel : FlowLayoutPanel
    {
        Label NameLabel;
        TextBox textBox;
        public SideOrAnglePanel(string Name, string textBoxName)
        {
            NameLabel = new Label();
            NameLabel.Text = Name;
            NameLabel.Font = new System.Drawing.Font(NameLabel.Font.FontFamily, 12);
            NameLabel.AutoSize = true;
            textBox = new TextBox();
            textBox.Name = textBoxName;
            Controls.Add(NameLabel);
            Controls.Add(textBox);
            Size = new System.Drawing.Size(155, 28);
        }
    }
}
