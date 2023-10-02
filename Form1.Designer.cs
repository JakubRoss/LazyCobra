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
            // Cobra
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 250);
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
            Text = "Cobra";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button;
    }
}