using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;


namespace Abzal_s
{
    public partial class Data : MaterialForm
    {
        public Data()
        {
            InitializeComponent();

            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;

            manager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
        }

        private void Data_Load(object sender, EventArgs e)
        {
            if(StudentClass.id != -1)
            {
                this.Text = "Edit";
                NameBox.Text = StudentClass.name;
                LangBox.Text = StudentClass.lang;
                AgeBox.Text = StudentClass.age.ToString();
                CategoryBox.Text = StudentClass.category;
            }
            else
            {
                this.Text = "Add";
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text !="" || LangBox.Text != "" || AgeBox.Text != "" || CategoryBox.Text != "")
            {
                StudentClass.name = NameBox.Text;
                StudentClass.lang = LangBox.Text;
                try { StudentClass.age = Convert.ToUInt16(AgeBox.Text); } catch(Exception ex) { MessageBox.Show("Это точно целое число?"); }
                StudentClass.category = CategoryBox.Text;
                StudentClass.state = true;
                Close();
            }
        }
    }
}
