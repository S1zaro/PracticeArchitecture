using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class UpdateForm : Form
    {
        private Logic logic;
        private Figure FigureToUpadte;
        public UpdateForm(int index, Logic logic)
        {
            this.logic = logic;
            FigureToUpadte = this.logic.ReadFigures()[index];
            InitializeComponent();
            NameBox.Text = FigureToUpadte.Name;
            CharacterBox.Text = FigureToUpadte.Character;
            SeriesBox.Text = FigureToUpadte.Series;
            PriceBox.Text = FigureToUpadte.Price.ToString();
            UniverseBox.Text = FigureToUpadte.Universe;
            UniverseBox.Items.AddRange(logic.ReadUniverse().Skip(1).ToArray());
            UniverseBox.SelectedItem = UniverseBox.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || UniverseBox.Text == "" || CharacterBox.Text == "" || SeriesBox.Text == "" || PriceBox.Text == "")
            {
                MessageBox.Show("Для изменения фигурки нужно заполнить все поля");
            }
            else
            {
                if (decimal.TryParse(PriceBox.Text, out decimal price))
                {

                    try
                    {
                        logic.FigureUpdate(FigureToUpadte.Id, NameBox.Text, UniverseBox.Text, SeriesBox.Text, CharacterBox.Text, price);
                        this.Close();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Число должно быть положительным");
                    }
                    catch(ArgumentException)
                    {
                        MessageBox.Show("Данное название фигурки уже существует, введите другое");
                    }
                }
                else
                {
                    MessageBox.Show("Неккоректное значение в поле Цена, введите число");
                }

            }
        }
    }
}
