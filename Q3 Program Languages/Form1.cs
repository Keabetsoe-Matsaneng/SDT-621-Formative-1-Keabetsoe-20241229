using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q3_Program_Languages
{
    public partial class ProgramLanguages : Form
    {
        Label selectedItem = null;
        string placeholder = "Enter Programming Language";
        public ProgramLanguages()
        {
            InitializeComponent();

            enterlanguage.Text = placeholder;
            enterlanguage.ForeColor = Color.Gray;

            outputpanel.AutoScroll = true;

            removebtn.Click += removebtn_Click;
        }

        private void enterlanguage_Enter(object sender, EventArgs e)
        {
            if (enterlanguage.Text == placeholder)
            {
                enterlanguage.Text = "";
                enterlanguage.ForeColor = Color.Black;
            }
        }

        private void enterlanguage_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterlanguage.Text))
            {
                enterlanguage.Text = placeholder;
                enterlanguage.ForeColor = Color.Gray;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string input = enterlanguage.Text;

            if (string.IsNullOrWhiteSpace(input) || input == placeholder)
                return;

            Label lbl = new Label();
            lbl.Text = input;
            lbl.AutoSize = true;
            lbl.Padding = new Padding(5);
            lbl.Margin = new Padding(5);
            lbl.BackColor = Color.LightGray;

            lbl.Click += Item_Click;

            outputpanel.Controls.Add(lbl);

            Label log = new Label();
            log.AutoSize = true;
            log.Margin = new Padding(3);

            string timestamp = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");

            log.Text = $"'{input}' added at {timestamp}";

            logpanel.Controls.Add(log);

            enterlanguage.Clear();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
                selectedItem.BackColor = Color.LightGray;

            selectedItem = (Label)sender;
            selectedItem.BackColor = Color.LightBlue;
        }

        private void removebtn_Click(Object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                outputpanel.Controls.Remove(selectedItem);
                selectedItem.Dispose();
                selectedItem = null;
            }
        }

        private void outputpanel_Paint(object sender, PaintEventArgs e)
        {
            outputpanel.FlowDirection = FlowDirection.TopDown;
            outputpanel.WrapContents = false;
        }
    }
}
