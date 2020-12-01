using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Abzal_s
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();

            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;

            manager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.studentsDataSet.table);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StudentClass.id = -1;
            Data data = new Data();
            data.ShowDialog();
            if (StudentClass.state)
            {
                studentsDataSet.table.Rows.Add(new object[] {StudentClass.name, StudentClass.lang,StudentClass.age, StudentClass.category });
                StudentClass.state = false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Grid.CurrentCell.Selected)
            {
                StudentClass.id = Grid.CurrentCell.RowIndex;
                StudentClass.name = studentsDataSet.table.Rows[StudentClass.id][0].ToString();
                StudentClass.lang = studentsDataSet.table.Rows[StudentClass.id][1].ToString();
                StudentClass.age = Convert.ToUInt16(studentsDataSet.table.Rows[StudentClass.id][2]);
                StudentClass.category = studentsDataSet.table.Rows[StudentClass.id][3].ToString();
                Data data = new Data();
                data.ShowDialog();
                if (StudentClass.state)
                {
                    studentsDataSet.table.Rows[StudentClass.id][0] = StudentClass.name;
                    studentsDataSet.table.Rows[StudentClass.id][1] = StudentClass.lang;
                    studentsDataSet.table.Rows[StudentClass.id][2] = StudentClass.age;
                    studentsDataSet.table.Rows[StudentClass.id][3] = StudentClass.category;
                    StudentClass.state = false;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Grid.CurrentCell.Selected)
            {
                studentsDataSet.table.Rows.RemoveAt(Grid.CurrentCell.RowIndex);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            tableTableAdapter.Update(studentsDataSet);
        }
    }
    public static class StudentClass
    {
        public static bool state { get; set; }
        public static int id { get; set; }
        public static string name { get; set; }
        public static string lang { get; set; }
        public static UInt16 age { get; set; }
        public static string category { get; set; }
    }
}
