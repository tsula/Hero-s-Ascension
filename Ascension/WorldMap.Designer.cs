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
            SaveButton.ForeColor = Color.Maroon;
            SaveButton.Location = new Point(192, 19);
            SaveButton.Margin = new Padding(1, 1, 1, 1);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(69, 27);
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
            ExitButton.ForeColor = Color.Maroon;
            ExitButton.Location = new Point(263, 19);
            ExitButton.Margin = new Padding(1, 1, 1, 1);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(82, 27);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // WorldMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.worldmap;
            ClientSize = new Size(358, 234);
            Controls.Add(ExitButton);
            Controls.Add(SaveButton);
            Margin = new Padding(1, 1, 1, 1);
            Name = "WorldMap";
            Text = "World Map";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button SaveButton;
        private Button ExitButton;
    }
}