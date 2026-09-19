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
    public partial class UpgradeForm : Form
    {
        private Logic logic;
        public UpgradeForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
            ListUpgradeFigure.Items.Clear();
            foreach (var figure in this.logic.ReadFigures())
            {
                ListViewItem item = new ListViewItem(figure.Id.ToString());
                item.SubItems.Add(figure.Name);
                item.SubItems.Add(figure.Universe);
                item.SubItems.Add(figure.Series);
                item.SubItems.Add(figure.Character);
                item.SubItems.Add(figure.Price.ToString() + "$");
                item.Tag = figure;
                ListUpgradeFigure.Items.Add(item);
            }
            decimal chance = (decimal)0.85 / CoefBox.Value * 100;
            ChanceBar.Value = (int)chance;
        }


        private void CoefBox_ValueChanged(object sender, EventArgs e)
        {
            decimal chance = (decimal)0.85 / CoefBox.Value * 100;
            ChanceBar.Value = (int)chance;
            if (ListUpgradeFigure.SelectedItems.Count > 0)
            {
                var item = ListUpgradeFigure.SelectedItems[0].Tag;
                if (item is Figure figure)
                {
                    PriceUpBox.Text = $"{figure.Price} -> {figure.Price * CoefBox.Value}";
                }
            }
            else
            {
                PriceUpBox.Text = "";
            }
        }

        private void ListUpgradeFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoefBox_ValueChanged(sender, e);
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            bool flag = logic.UpgradeFigure(ListUpgradeFigure.SelectedItems[0].Index, CoefBox.Value);
            if (flag)
            {
                MessageBox.Show("Улучшение прошло успешно!");
            }
            else
            {
                MessageBox.Show("Улучшение провалено(((");
            }
            this.Close();
        }
    }
}
