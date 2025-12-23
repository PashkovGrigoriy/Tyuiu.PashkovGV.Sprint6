using Tyuiu.PashkovGV.Sprint6.Task0.V6.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Accept_Click(object sender, EventArgs e)
        {
            int x = 3;
            DataService ds = new DataService();
            Res.Text = Math.Round((ds.Calculate(x)),3).ToString();
        }
    }
}
