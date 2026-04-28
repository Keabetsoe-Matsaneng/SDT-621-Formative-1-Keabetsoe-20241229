namespace B_Q2_Digital_Identity_Processor
{
    partial class DigitalIdentityProcessor
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
            HomeAffairsLogo = new PictureBox();
            title = new Label();
            namelabel = new Label();
            IDlabel = new Label();
            citizenlabel = new Label();
            txtname = new TextBox();
            txtID = new TextBox();
            citizenbox = new ComboBox();
            btnValidate = new Button();
            btnGenerate = new Button();
            lblValidationResult = new Label();
            txtSummary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)HomeAffairsLogo).BeginInit();
            SuspendLayout();
            // 
            // HomeAffairsLogo
            // 
            HomeAffairsLogo.Image = Properties.Resources.images;
            HomeAffairsLogo.Location = new Point(40, 72);
            HomeAffairsLogo.Name = "HomeAffairsLogo";
            HomeAffairsLogo.Size = new Size(490, 811);
            HomeAffairsLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            HomeAffairsLogo.TabIndex = 0;
            HomeAffairsLogo.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            title.ForeColor = Color.PaleVioletRed;
            title.Location = new Point(512, 29);
            title.Name = "title";
            title.Size = new Size(628, 35);
            title.TabIndex = 1;
            title.Text = "Home Affairs Digital Identity Processor";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            namelabel.Location = new Point(548, 105);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(240, 30);
            namelabel.TabIndex = 2;
            namelabel.Text = "Enter your name: ";
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            IDlabel.Location = new Point(546, 166);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(304, 30);
            IDlabel.TabIndex = 3;
            IDlabel.Text = "Enter your ID number: ";
            // 
            // citizenlabel
            // 
            citizenlabel.AutoSize = true;
            citizenlabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            citizenlabel.Location = new Point(546, 235);
            citizenlabel.Name = "citizenlabel";
            citizenlabel.Size = new Size(328, 30);
            citizenlabel.TabIndex = 4;
            citizenlabel.Text = "Select your Citizenship: ";
            // 
            // txtname
            // 
            txtname.Location = new Point(807, 103);
            txtname.Name = "txtname";
            txtname.Size = new Size(229, 32);
            txtname.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(868, 164);
            txtID.Name = "txtID";
            txtID.Size = new Size(227, 32);
            txtID.TabIndex = 6;
            // 
            // citizenbox
            // 
            citizenbox.FormattingEnabled = true;
            citizenbox.Items.AddRange(new object[] { "South African", "Permanent Resident", "Visitor" });
            citizenbox.Location = new Point(900, 231);
            citizenbox.Name = "citizenbox";
            citizenbox.Size = new Size(240, 34);
            citizenbox.TabIndex = 7;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.Pink;
            btnValidate.Location = new Point(779, 303);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(171, 48);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Pink;
            btnGenerate.Location = new Point(779, 858);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(173, 44);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblValidationResult
            // 
            lblValidationResult.AutoSize = true;
            lblValidationResult.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValidationResult.Location = new Point(796, 388);
            lblValidationResult.Name = "lblValidationResult";
            lblValidationResult.Size = new Size(0, 30);
            lblValidationResult.TabIndex = 11;
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(696, 476);
            txtSummary.MaximumSize = new Size(600, 800);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.Size = new Size(379, 368);
            txtSummary.TabIndex = 12;
            // 
            // DigitalIdentityProcessor
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1233, 929);
            Controls.Add(txtSummary);
            Controls.Add(lblValidationResult);
            Controls.Add(btnGenerate);
            Controls.Add(btnValidate);
            Controls.Add(citizenbox);
            Controls.Add(txtID);
            Controls.Add(txtname);
            Controls.Add(citizenlabel);
            Controls.Add(IDlabel);
            Controls.Add(namelabel);
            Controls.Add(title);
            Controls.Add(HomeAffairsLogo);
            Font = new Font("Showcard Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DigitalIdentityProcessor";
            Text = "Digital Identity Processor";
            Load += DigitalIdentityProcessor_Load;
            ((System.ComponentModel.ISupportInitialize)HomeAffairsLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox HomeAffairsLogo;
        private Label title;
        private Label namelabel;
        private Label IDlabel;
        private Label citizenlabel;
        private TextBox txtname;
        private TextBox txtID;
        private ComboBox citizenbox;
        private Button btnValidate;
        private Button btnGenerate;
        private Label lblValidationResult;
        private TextBox txtSummary;
    }
}
