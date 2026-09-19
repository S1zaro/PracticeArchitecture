namespace WinForms
{
    partial class UpdateForm
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
            UniverseBox = new ComboBox();
            CharacterBox = new TextBox();
            SeriesBox = new TextBox();
            NameBox = new TextBox();
            SeriesLabel = new Label();
            CharacterLabel = new Label();
            UniverseLabel = new Label();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(215, 294);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(133, 29);
            SaveButton.TabIndex = 24;
            SaveButton.Text = " Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // UniverseBox
            // 
            UniverseBox.FormattingEnabled = true;
            UniverseBox.Location = new Point(283, 227);
            UniverseBox.Name = "UniverseBox";
            UniverseBox.Size = new Size(151, 28);
            UniverseBox.TabIndex = 23;
            // 
            // CharacterBox
            // 
            CharacterBox.Location = new Point(296, 151);
            CharacterBox.Name = "CharacterBox";
            CharacterBox.Size = new Size(125, 27);
            CharacterBox.TabIndex = 22;
            // 
            // SeriesBox
            // 
            SeriesBox.Location = new Point(136, 227);
            SeriesBox.Name = "SeriesBox";
            SeriesBox.Size = new Size(125, 27);
            SeriesBox.TabIndex = 20;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(136, 151);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 19;
            // 
            // SeriesLabel
            // 
            SeriesLabel.AutoSize = true;
            SeriesLabel.Location = new Point(171, 204);
            SeriesLabel.Name = "SeriesLabel";
            SeriesLabel.Size = new Size(52, 20);
            SeriesLabel.TabIndex = 17;
            SeriesLabel.Text = "Серия";
            // 
            // CharacterLabel
            // 
            CharacterLabel.AutoSize = true;
            CharacterLabel.Location = new Point(317, 115);
            CharacterLabel.Name = "CharacterLabel";
            CharacterLabel.Size = new Size(81, 20);
            CharacterLabel.TabIndex = 16;
            CharacterLabel.Text = "Персонаж";
            // 
            // UniverseLabel
            // 
            UniverseLabel.AutoSize = true;
            UniverseLabel.Location = new Point(315, 204);
            UniverseLabel.Name = "UniverseLabel";
            UniverseLabel.Size = new Size(83, 20);
            UniverseLabel.TabIndex = 15;
            UniverseLabel.Text = "Вселенная";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(178, 115);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 14;
            NameLabel.Text = "Имя";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 481);
            Controls.Add(SaveButton);
            Controls.Add(UniverseBox);
            Controls.Add(CharacterBox);
            Controls.Add(SeriesBox);
            Controls.Add(NameBox);
            Controls.Add(SeriesLabel);
            Controls.Add(CharacterLabel);
            Controls.Add(UniverseLabel);
            Controls.Add(NameLabel);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private ComboBox UniverseBox;
        private TextBox CharacterBox;
        private TextBox SeriesBox;
        private TextBox NameBox;
        private Label SeriesLabel;
        private Label CharacterLabel;
        private Label UniverseLabel;
        private Label NameLabel;
    }
}