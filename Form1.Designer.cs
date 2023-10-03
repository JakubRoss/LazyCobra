using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobra));
            button = new Button();
            GITIFY = new LinkLabel();
            label1 = new Label();
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
            // GITIFY
            // 
            GITIFY.AccessibleRole = AccessibleRole.None;
            GITIFY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GITIFY.AutoSize = true;
            GITIFY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GITIFY.LinkBehavior = LinkBehavior.NeverUnderline;
            GITIFY.LinkColor = Color.DarkSeaGreen;
            GITIFY.Location = new Point(12, 220);
            GITIFY.Name = "GITIFY";
            GITIFY.Size = new Size(57, 21);
            GITIFY.TabIndex = 1;
            GITIFY.TabStop = true;
            GITIFY.Text = "GITIFY";
            GITIFY.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(226, 226);
            label1.Name = "label1";
            label1.Size = new Size(65, 13);
            label1.TabIndex = 2;
            label1.Text = "Jakub Ross";
            label1.MouseEnter += me;
            label1.MouseLeave += ml;
            // 
            // Cobra
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 250);
            Controls.Add(label1);
            Controls.Add(GITIFY);
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
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        protected LinkLabel GITIFY;
        private Label label1;
    }
}