using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Abzal_s
{
    public partial class Help : MaterialForm
    {
        public Help()
        {
            InitializeComponent();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
