namespace Q3_Program_Languages
{
    partial class ProgramLanguages
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Mainpanel = new Panel();
            removebtn = new Button();
            addbtn = new Button();
            enterlanguage = new TextBox();
            outputpanel = new FlowLayoutPanel();
            titlelabel = new Label();
            logpanel = new FlowLayoutPanel();
            Mainpanel.SuspendLayout();
            SuspendLayout();
            // 
            // Mainpanel
            // 
            Mainpanel.BackColor = Color.WhiteSmoke;
            Mainpanel.Controls.Add(logpanel);
            Mainpanel.Controls.Add(removebtn);
            Mainpanel.Controls.Add(addbtn);
            Mainpanel.Controls.Add(enterlanguage);
            Mainpanel.Controls.Add(outputpanel);
            Mainpanel.Controls.Add(titlelabel);
            Mainpanel.Location = new Point(196, 41);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.Size = new Size(854, 669);
            Mainpanel.TabIndex = 0;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.Red;
            removebtn.Location = new Point(439, 443);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(199, 48);
            removebtn.TabIndex = 4;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.PaleTurquoise;
            addbtn.ForeColor = SystemColors.ControlText;
            addbtn.Location = new Point(147, 443);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(210, 48);
            addbtn.TabIndex = 3;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // enterlanguage
            // 
            enterlanguage.Location = new Point(147, 376);
            enterlanguage.Name = "enterlanguage";
            enterlanguage.Size = new Size(524, 32);
            enterlanguage.TabIndex = 2;
            // 
            // outputpanel
            // 
            outputpanel.BackColor = Color.Bisque;
            outputpanel.FlowDirection = FlowDirection.TopDown;
            outputpanel.Location = new Point(147, 100);
            outputpanel.Name = "outputpanel";
            outputpanel.Size = new Size(524, 251);
            outputpanel.TabIndex = 1;
            outputpanel.WrapContents = false;
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.Font = new Font("Showcard Gothic", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            titlelabel.Location = new Point(98, 15);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(677, 40);
            titlelabel.TabIndex = 0;
            titlelabel.Text = "My Favourite Programming Languages";
            // 
            // logpanel
            // 
            logpanel.BackColor = Color.MistyRose;
            logpanel.Location = new Point(147, 507);
            logpanel.Name = "logpanel";
            logpanel.Size = new Size(300, 150);
            logpanel.TabIndex = 5;
            logpanel.FlowDirection = FlowDirection.TopDown;
            logpanel.AutoScroll = true;
            logpanel.WrapContents= false;
            // 
            // ProgramLanguages
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1229, 788);
            Controls.Add(Mainpanel);
            Font = new Font("Showcard Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProgramLanguages";
            Text = "My Favourite Programming Languages";
            Mainpanel.ResumeLayout(false);
            Mainpanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel Mainpanel;
        private Label titlelabel;
        private FlowLayoutPanel outputpanel;
        private TextBox enterlanguage;
        private Button addbtn;
        private Button removebtn;
        private FlowLayoutPanel logpanel;
    }
}
