using Model;

namespace WinForms
{
    public partial class MainForm : Form
    {
        private Logic logic = new Logic();
        public MainForm()
        {
            InitializeComponent();
            SortBox.Items.AddRange(logic.ReadGroupList());
            SortBox.SelectedItem = SortBox.Items[0];
            UpdateMainForm();
        }


        private void UpdateMainForm()
        {
            Dictionary<string, decimal> sumList = logic.SumCollectionFigure();
            if (sumList.ContainsKey("Marvel"))
            {
                SumMarvelBox.Text = sumList["Marvel"].ToString()+"$";
            }
            else
            {
                SumMarvelBox.Text = "0$";
            }
            if (sumList.ContainsKey("DC"))
            {
                SumDCBox.Text = sumList["DC"].ToString() + "$";
            }
            else
            {
                SumDCBox.Text = "0$";
            }
            if (sumList.ContainsKey("Anime"))
            {
                SumAnimeBox.Text = sumList["Anime"].ToString() + "$";
            }
            else
            {
                SumAnimeBox.Text = "0$";
            }
            if (sumList.ContainsKey("Game"))
            {
                SumGameBox.Text = sumList["Game"].ToString() + "$";
            }
            else
            {
                SumGameBox.Text = "0$";
            }
            SumAllBox.Text = sumList.Sum(i => i.Value).ToString()+"$";
            listFigure.Items.Clear();
            if (SortBox.Text == "")
            {
                foreach (var figure in logic.ReadFigures())
                {
                    ListViewItem item = new ListViewItem(figure.Id.ToString());
                    item.SubItems.Add(figure.Name);
                    item.SubItems.Add(figure.Universe);
                    item.SubItems.Add(figure.Series);
                    item.SubItems.Add(figure.Character);
                    item.SubItems.Add(figure.Price.ToString() + "$");
                    item.Tag = figure;
                    listFigure.Items.Add(item);
                }
            }
            else
            {
                Dictionary<string, List<Figure>> list = logic.GroupFigure(SortBox.Text);
                foreach (var k in list)
                {
                    foreach (var v in k.Value)
                    {
                        ListViewItem item = new ListViewItem(v.Id.ToString());
                        item.SubItems.Add(v.Name);
                        item.SubItems.Add(v.Universe);
                        item.SubItems.Add(v.Series);
                        item.SubItems.Add(v.Character);
                        item.SubItems.Add(v.Price.ToString() + "$");
                        item.Tag = v;
                        listFigure.Items.Add(item);
                    }
                }
            }

        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(logic);
            form.ShowDialog();
            UpdateMainForm();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var item = listFigure.SelectedItems[0].Tag;
                if (item is Figure figure)
                {
                    logic.FigureRemove(figure.Id);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Фигурки с данным Id не существует или вы не выбрали фигурку");
            }
            UpdateMainForm();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

            if (listFigure.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала выделите фигурку, которую хоитие изменить");
            }
            else
            {
                ListViewItem item = listFigure.SelectedItems[0];
                UpdateForm form = new UpdateForm(item.Index, logic);
                form.ShowDialog();
            }
            UpdateMainForm();
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMainForm();
        }

        
    }
}
