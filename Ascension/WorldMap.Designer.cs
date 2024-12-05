namespace Ascension
{
    partial class WorldMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.None;
            SaveButton.BackColor = SystemColors.ControlDarkDark;
            SaveButton.BackgroundImage = Properties.Resources.worldmap;
            SaveButton.BackgroundImageLayout = ImageLayout.Center;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.Crimson;
            SaveButton.Location = new Point(1, 955);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(181, 63);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.None;
            ExitButton.BackColor = SystemColors.ControlDarkDark;
            ExitButton.BackgroundImage = Properties.Resources.worldmap;
            ExitButton.BackgroundImageLayout = ImageLayout.None;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = Color.Crimson;
            ExitButton.Location = new Point(885, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(139, 63);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // WorldMap
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.worldmap;
            ClientSize = new Size(1023, 1030);
            Controls.Add(ExitButton);
            Controls.Add(SaveButton);
            Name = "WorldMap";
            Text = "World Map";
            ResumeLayout(false);
        }

        #endregion

        private Button SaveButton;
        private Button ExitButton;
    }
}