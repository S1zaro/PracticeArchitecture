namespace WinForms
{
    partial class AddForm
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
            NameLabel = new Label();
            UniverseLabel = new Label();
            CharacterLabel = new Label();
            SeriesLabel = new Label();
            PriceLabel = new Label();
            NameBox = new TextBox();
            SeriesBox = new TextBox();
            PriceBox = new TextBox();
            CharacterBox = new TextBox();
            UniverseBox = new ComboBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(237, 47);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Имя";
            // 
            // UniverseLabel
            // 
            UniverseLabel.AutoSize = true;
            UniverseLabel.Location = new Point(297, 211);
            UniverseLabel.Name = "UniverseLabel";
            UniverseLabel.Size = new Size(83, 20);
            UniverseLabel.TabIndex = 1;
            UniverseLabel.Text = "Вселенная";
            // 
            // CharacterLabel
            // 
            CharacterLabel.AutoSize = true;
            CharacterLabel.Location = new Point(376, 47);
            CharacterLabel.Name = "CharacterLabel";
            CharacterLabel.Size = new Size(81, 20);
            CharacterLabel.TabIndex = 2;
            CharacterLabel.Text = "Персонаж";
            // 
            // SeriesLabel
            // 
            SeriesLabel.AutoSize = true;
            SeriesLabel.Location = new Point(230, 136);
            SeriesLabel.Name = "SeriesLabel";
            SeriesLabel.Size = new Size(52, 20);
            SeriesLabel.TabIndex = 3;
            SeriesLabel.Text = "Серия";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(396, 136);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(45, 20);
            PriceLabel.TabIndex = 5;
            PriceLabel.Text = "Цена";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(195, 83);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 6;
            // 
            // SeriesBox
            // 
            SeriesBox.Location = new Point(195, 159);
            SeriesBox.Name = "SeriesBox";
            SeriesBox.Size = new Size(125, 27);
            SeriesBox.TabIndex = 7;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(355, 159);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(125, 27);
            PriceBox.TabIndex = 10;
            // 
            // CharacterBox
            // 
            CharacterBox.Location = new Point(355, 83);
            CharacterBox.Name = "CharacterBox";
            CharacterBox.Size = new Size(125, 27);
            CharacterBox.TabIndex = 11;
            // 
            // UniverseBox
            // 
            UniverseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UniverseBox.FormattingEnabled = true;
            UniverseBox.Location = new Point(265, 234);
            UniverseBox.Name = "UniverseBox";
            UniverseBox.Size = new Size(151, 28);
            UniverseBox.TabIndex = 12;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(283, 332);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(94, 29);
            CreateButton.TabIndex = 13;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 480);
            Controls.Add(CreateButton);
            Controls.Add(UniverseBox);
            Controls.Add(CharacterBox);
            Controls.Add(PriceBox);
            Controls.Add(SeriesBox);
            Controls.Add(NameBox);
            Controls.Add(PriceLabel);
            Controls.Add(SeriesLabel);
            Controls.Add(CharacterLabel);
            Controls.Add(UniverseLabel);
            Controls.Add(NameLabel);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label UniverseLabel;
        private Label CharacterLabel;
        private Label SeriesLabel;
        private Label PriceLabel;
        private TextBox NameBox;
        private TextBox SeriesBox;
        private TextBox PriceBox;
        private TextBox CharacterBox;
        private ComboBox UniverseBox;
        private Button CreateButton;
    }
}