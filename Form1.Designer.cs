namespace CoMo
{
    partial class Cobra
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobra));
            button = new Button();
            linkLabel = new LinkLabel();
            nameLabel = new Label();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // button
            // 
            button.Anchor = AnchorStyles.None;
            button.BackColor = Color.MediumSeaGreen;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new Point(60, 80);
            button.Margin = new Padding(4);
            button.Name = "button";
            button.Size = new Size(180, 90);
            button.TabIndex = 0;
            button.Text = "Start";
            button.TextImageRelation = TextImageRelation.ImageAboveText;
            button.UseVisualStyleBackColor = false;
            button.Click += button1_Click;
            // 
            // linkLabel
            // 
            linkLabel.AccessibleRole = AccessibleRole.None;
            linkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel.LinkColor = Color.DarkSeaGreen;
            linkLabel.Location = new Point(12, 220);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(57, 21);
            linkLabel.TabIndex = 1;
            linkLabel.TabStop = true;
            linkLabel.Text = "GITIFY";
            linkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.WhiteSmoke;
            nameLabel.Location = new Point(226, 226);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(65, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Jakub Ross";
            nameLabel.MouseEnter += me;
            nameLabel.MouseLeave += ml;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "LazyCobra";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += ShowWindow;
            // 
            // Cobra
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 250);
            Controls.Add(nameLabel);
            Controls.Add(linkLabel);
            Controls.Add(button);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(450, 400);
            MinimumSize = new Size(300, 250);
            Name = "Cobra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LazyCobra";
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        protected LinkLabel linkLabel;
        private Label nameLabel;
        private NotifyIcon notifyIcon1;
    }
}