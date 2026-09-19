namespace WinForms
{
    partial class MainForm
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
            listFigure = new ListView();
            IdColumn = new ColumnHeader();
            NameColumn = new ColumnHeader();
            UniverseColumn = new ColumnHeader();
            SeriesColumn = new ColumnHeader();
            CharacterColumn = new ColumnHeader();
            PriceColumn = new ColumnHeader();
            createButton = new Button();
            DeleteButton = new Button();
            ChangeButton = new Button();
            SortBox = new ComboBox();
            SortLabel = new Label();
            SumCollection = new Label();
            SumAllBox = new TextBox();
            SumMarvelBox = new TextBox();
            MarvelSumLabel = new Label();
            SumDCBox = new TextBox();
            DCSumLabel = new Label();
            SumAnimeBox = new TextBox();
            AnimeSumLabel = new Label();
            SumGameBox = new TextBox();
            GameSumLabel = new Label();
            BalanceBox = new TextBox();
            BalanceLabel = new Label();
            UpgradeButton = new Button();
            SuspendLayout();
            // 
            // listFigure
            // 
            listFigure.Activation = ItemActivation.OneClick;
            listFigure.Columns.AddRange(new ColumnHeader[] { IdColumn, NameColumn, UniverseColumn, SeriesColumn, CharacterColumn, PriceColumn });
            listFigure.FullRowSelect = true;
            listFigure.Location = new Point(23, 88);
            listFigure.Name = "listFigure";
            listFigure.Size = new Size(549, 314);
            listFigure.TabIndex = 0;
            listFigure.UseCompatibleStateImageBehavior = false;
            listFigure.View = View.Details;
            // 
            // IdColumn
            // 
            IdColumn.Text = "Id";
            IdColumn.Width = 30;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Название";
            NameColumn.TextAlign = HorizontalAlignment.Center;
            NameColumn.Width = 125;
            // 
            // UniverseColumn
            // 
            UniverseColumn.Text = "Вселенная";
            UniverseColumn.TextAlign = HorizontalAlignment.Center;
            UniverseColumn.Width = 100;
            // 
            // SeriesColumn
            // 
            SeriesColumn.Text = "Серия";
            SeriesColumn.TextAlign = HorizontalAlignment.Center;
            SeriesColumn.Width = 125;
            // 
            // CharacterColumn
            // 
            CharacterColumn.Text = "Персонаж";
            CharacterColumn.TextAlign = HorizontalAlignment.Center;
            CharacterColumn.Width = 100;
            // 
            // PriceColumn
            // 
            PriceColumn.Text = "Цена";
            PriceColumn.TextAlign = HorizontalAlignment.Center;
            PriceColumn.Width = 65;
            // 
            // createButton
            // 
            createButton.Location = new Point(603, 103);
            createButton.Name = "createButton";
            createButton.Size = new Size(161, 46);
            createButton.TabIndex = 1;
            createButton.Text = "Создать Фигурку";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(603, 180);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(161, 46);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить Фигурку";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(603, 253);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(161, 46);
            ChangeButton.TabIndex = 3;
            ChangeButton.Text = "Изменить Фигурку";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // SortBox
            // 
            SortBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortBox.FormattingEnabled = true;
            SortBox.Location = new Point(62, 45);
            SortBox.Name = "SortBox";
            SortBox.Size = new Size(151, 28);
            SortBox.TabIndex = 6;
            SortBox.SelectedIndexChanged += SortBox_SelectedIndexChanged;
            // 
            // SortLabel
            // 
            SortLabel.AutoSize = true;
            SortLabel.Location = new Point(62, 22);
            SortLabel.Name = "SortLabel";
            SortLabel.Size = new Size(140, 20);
            SortLabel.TabIndex = 7;
            SortLabel.Text = "Сгруппировать по:";
            // 
            // SumCollection
            // 
            SumCollection.AutoSize = true;
            SumCollection.Location = new Point(23, 419);
            SumCollection.Name = "SumCollection";
            SumCollection.Size = new Size(239, 20);
            SumCollection.TabIndex = 9;
            SumCollection.Text = "Общая сумма вашей коллекции: ";
            // 
            // SumAllBox
            // 
            SumAllBox.Location = new Point(268, 419);
            SumAllBox.Name = "SumAllBox";
            SumAllBox.ReadOnly = true;
            SumAllBox.Size = new Size(125, 27);
            SumAllBox.TabIndex = 10;
            // 
            // SumMarvelBox
            // 
            SumMarvelBox.Location = new Point(143, 459);
            SumMarvelBox.Name = "SumMarvelBox";
            SumMarvelBox.ReadOnly = true;
            SumMarvelBox.Size = new Size(125, 27);
            SumMarvelBox.TabIndex = 12;
            // 
            // MarvelSumLabel
            // 
            MarvelSumLabel.AutoSize = true;
            MarvelSumLabel.Location = new Point(20, 459);
            MarvelSumLabel.Name = "MarvelSumLabel";
            MarvelSumLabel.Size = new Size(117, 20);
            MarvelSumLabel.TabIndex = 11;
            MarvelSumLabel.Text = "Marvel-фигурки";
            // 
            // SumDCBox
            // 
            SumDCBox.Location = new Point(406, 462);
            SumDCBox.Name = "SumDCBox";
            SumDCBox.ReadOnly = true;
            SumDCBox.Size = new Size(125, 27);
            SumDCBox.TabIndex = 14;
            // 
            // DCSumLabel
            // 
            DCSumLabel.AutoSize = true;
            DCSumLabel.Location = new Point(283, 462);
            DCSumLabel.Name = "DCSumLabel";
            DCSumLabel.Size = new Size(92, 20);
            DCSumLabel.TabIndex = 13;
            DCSumLabel.Text = "DC-фигурки";
            // 
            // SumAnimeBox
            // 
            SumAnimeBox.Location = new Point(146, 499);
            SumAnimeBox.Name = "SumAnimeBox";
            SumAnimeBox.ReadOnly = true;
            SumAnimeBox.Size = new Size(125, 27);
            SumAnimeBox.TabIndex = 16;
            // 
            // AnimeSumLabel
            // 
            AnimeSumLabel.AutoSize = true;
            AnimeSumLabel.Location = new Point(23, 499);
            AnimeSumLabel.Name = "AnimeSumLabel";
            AnimeSumLabel.Size = new Size(115, 20);
            AnimeSumLabel.TabIndex = 15;
            AnimeSumLabel.Text = "Anime-фигурки";
            // 
            // SumGameBox
            // 
            SumGameBox.Location = new Point(406, 496);
            SumGameBox.Name = "SumGameBox";
            SumGameBox.ReadOnly = true;
            SumGameBox.Size = new Size(125, 27);
            SumGameBox.TabIndex = 18;
            // 
            // GameSumLabel
            // 
            GameSumLabel.AutoSize = true;
            GameSumLabel.Location = new Point(283, 499);
            GameSumLabel.Name = "GameSumLabel";
            GameSumLabel.Size = new Size(111, 20);
            GameSumLabel.TabIndex = 17;
            GameSumLabel.Text = "Game-фигурки";
            // 
            // BalanceBox
            // 
            BalanceBox.Location = new Point(652, 9);
            BalanceBox.Name = "BalanceBox";
            BalanceBox.ReadOnly = true;
            BalanceBox.Size = new Size(125, 27);
            BalanceBox.TabIndex = 20;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Location = new Point(585, 12);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(61, 20);
            BalanceLabel.TabIndex = 19;
            BalanceLabel.Text = "Баланс:";
            // 
            // UpgradeButton
            // 
            UpgradeButton.Location = new Point(603, 329);
            UpgradeButton.Name = "UpgradeButton";
            UpgradeButton.Size = new Size(161, 46);
            UpgradeButton.TabIndex = 21;
            UpgradeButton.Text = "Улучшить фигурку";
            UpgradeButton.UseVisualStyleBackColor = true;
            UpgradeButton.Click += UpgradeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 559);
            Controls.Add(UpgradeButton);
            Controls.Add(BalanceBox);
            Controls.Add(BalanceLabel);
            Controls.Add(SumGameBox);
            Controls.Add(GameSumLabel);
            Controls.Add(SumAnimeBox);
            Controls.Add(AnimeSumLabel);
            Controls.Add(SumDCBox);
            Controls.Add(DCSumLabel);
            Controls.Add(SumMarvelBox);
            Controls.Add(MarvelSumLabel);
            Controls.Add(SumAllBox);
            Controls.Add(SumCollection);
            Controls.Add(SortLabel);
            Controls.Add(SortBox);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteButton);
            Controls.Add(createButton);
            Controls.Add(listFigure);
            Name = "MainForm";
            Text = "mainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listFigure;
        private Button createButton;
        private Button DeleteButton;
        private Button ChangeButton;
        private ColumnHeader IdColumn;
        private ColumnHeader NameColumn;
        private ColumnHeader UniverseColumn;
        private ColumnHeader SeriesColumn;
        private ColumnHeader CharacterColumn;
        private ColumnHeader PriceColumn;
        private ComboBox SortBox;
        private Label SortLabel;
        private Label SumCollection;
        private TextBox SumAllBox;
        private TextBox SumMarvelBox;
        private Label MarvelSumLabel;
        private TextBox SumDCBox;
        private Label DCSumLabel;
        private TextBox SumAnimeBox;
        private Label AnimeSumLabel;
        private TextBox SumGameBox;
        private Label GameSumLabel;
        private TextBox BalanceBox;
        private Label BalanceLabel;
        private Button UpgradeButton;
    }
}
