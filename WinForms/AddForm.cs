using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace WinForms
{
    public partial class AddForm : Form
    {


        private Logic logic;
        public AddForm(Logic logic)
        {
            this.logic = logic;
            InitializeComponent();
            UniverseBox.Items.AddRange(logic.ReadUniverse().Skip(1).ToArray());
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || UniverseBox.Text == "" || CharacterBox.Text == "" || SeriesBox.Text == "")
            {
                MessageBox.Show("Для создания фигурки нужно заполнить все поля");
            }
            else
            {
                try
                {
                    logic.FigureAdd(NameBox.Text, UniverseBox.Text, SeriesBox.Text, CharacterBox.Text);
                    logic.ChangeBalance(-logic.ReadFigures().Last().Price);
                    this.Close();

                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Имя занято");
                }

            }
        }

      
    }
}
