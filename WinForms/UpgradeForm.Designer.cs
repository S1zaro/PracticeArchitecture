namespace WinForms
{
    partial class UpgradeForm
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
            ListUpgradeFigure = new ListView();
            IdColumn = new ColumnHeader();
            NameColumn = new ColumnHeader();
            UniverseColumn = new ColumnHeader();
            SeriesColumn = new ColumnHeader();
            CharacterColumn = new ColumnHeader();
            PriceColumn = new ColumnHeader();
            CoefBox = new NumericUpDown();
            UpgradeButton = new Button();
            label1 = new Label();
            PriceUpBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CoefBox).BeginInit();
            SuspendLayout();
            // 
            // ListUpgradeFigure
            // 
            ListUpgradeFigure.Activation = ItemActivation.OneClick;
            ListUpgradeFigure.Columns.AddRange(new ColumnHeader[] { IdColumn, NameColumn, UniverseColumn, SeriesColumn, CharacterColumn, PriceColumn });
            ListUpgradeFigure.FullRowSelect = true;
            ListUpgradeFigure.Location = new Point(49, 100);
            ListUpgradeFigure.Name = "ListUpgradeFigure";
            ListUpgradeFigure.Size = new Size(549, 314);
            ListUpgradeFigure.TabIndex = 1;
            ListUpgradeFigure.UseCompatibleStateImageBehavior = false;
            ListUpgradeFigure.View = View.Details;
            ListUpgradeFigure.SelectedIndexChanged += ListUpgradeFigure_SelectedIndexChanged;
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
            // CoefBox
            // 
            CoefBox.DecimalPlaces = 1;
            CoefBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            CoefBox.Location = new Point(240, 448);
            CoefBox.Maximum = new decimal(new int[] { 25, 0, 0, 65536 });
            CoefBox.Minimum = new decimal(new int[] { 15, 0, 0, 65536 });
            CoefBox.Name = "CoefBox";
            CoefBox.Size = new Size(150, 27);
            CoefBox.TabIndex = 2;
            CoefBox.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            CoefBox.ValueChanged += CoefBox_ValueChanged;
            // 
            // UpgradeButton
            // 
            UpgradeButton.Location = new Point(253, 520);
            UpgradeButton.Name = "UpgradeButton";
            UpgradeButton.Size = new Size(123, 30);
            UpgradeButton.TabIndex = 3;
            UpgradeButton.Text = "Улучшить";
            UpgradeButton.UseVisualStyleBackColor = true;
            UpgradeButton.Click += UpgradeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 425);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 4;
            label1.Text = "Множитель:";
            // 
            // PriceUpBox
            // 
            PriceUpBox.Location = new Point(229, 487);
            PriceUpBox.Name = "PriceUpBox";
            PriceUpBox.ReadOnly = true;
            PriceUpBox.Size = new Size(176, 27);
            PriceUpBox.TabIndex = 5;
            // 
            // UpgradeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 571);
            Controls.Add(PriceUpBox);
            Controls.Add(label1);
            Controls.Add(UpgradeButton);
            Controls.Add(CoefBox);
            Controls.Add(ListUpgradeFigure);
            Name = "UpgradeForm";
            Text = "UpgradeForm";
            ((System.ComponentModel.ISupportInitialize)CoefBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListUpgradeFigure;
        private ColumnHeader IdColumn;
        private ColumnHeader NameColumn;
        private ColumnHeader UniverseColumn;
        private ColumnHeader SeriesColumn;
        private ColumnHeader CharacterColumn;
        private ColumnHeader PriceColumn;
        private NumericUpDown CoefBox;
        private Button UpgradeButton;
        private Label label1;
        private TextBox PriceUpBox;
    }
}