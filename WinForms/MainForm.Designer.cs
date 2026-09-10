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
            createButton = new Button();
            deleteButton = new Button();
            changeButton = new Button();
            groupBySeriesButton = new Button();
            showUniverse = new ComboBox();
            SuspendLayout();
            // 
            // listFigure
            // 
            listFigure.Location = new Point(23, 88);
            listFigure.Name = "ListFigure";
            listFigure.Size = new Size(518, 393);
            listFigure.TabIndex = 0;
            listFigure.UseCompatibleStateImageBehavior = false;
            // 
            // createButton
            // 
            createButton.Location = new Point(595, 103);
            createButton.Name = "CreateButton";
            createButton.Size = new Size(161, 46);
            createButton.TabIndex = 1;
            createButton.Text = "Создать Фигурку";
            createButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(595, 180);
            deleteButton.Name = "DeleteButton";
            deleteButton.Size = new Size(161, 46);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить Фигурку";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(595, 253);
            changeButton.Name = "ChangeButton";
            changeButton.Size = new Size(161, 46);
            changeButton.TabIndex = 3;
            changeButton.Text = "Изменить Фигурку";
            changeButton.UseVisualStyleBackColor = true;
            // 
            // groupBySeriesButton
            // 
            groupBySeriesButton.Location = new Point(595, 331);
            groupBySeriesButton.Name = "GroupBySeriesButton";
            groupBySeriesButton.Size = new Size(161, 46);
            groupBySeriesButton.TabIndex = 4;
            groupBySeriesButton.Text = "Сгруппировать по серии";
            groupBySeriesButton.UseVisualStyleBackColor = true;
            // 
            // showUniverse
            // 
            showUniverse.FormattingEnabled = true;
            showUniverse.Location = new Point(595, 405);
            showUniverse.Name = "ShowUniverse";
            showUniverse.Size = new Size(151, 28);
            showUniverse.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(showUniverse);
            Controls.Add(groupBySeriesButton);
            Controls.Add(changeButton);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(listFigure);
            Name = "MainForm";
            Text = "mainForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listFigure;
        private Button createButton;
        private Button deleteButton;
        private Button changeButton;
        private Button groupBySeriesButton;
        private ComboBox showUniverse;
    }
}
