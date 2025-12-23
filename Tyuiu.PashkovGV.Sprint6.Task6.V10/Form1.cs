using Tyuiu.PashkovGV.Sprint6.Task6.V10.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task6.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Data ds = new Data();
        private void Done_Click(object sender, EventArgs e)
        {
            string a = @"D:\DataSprint5";
            string b = "InPutDataFileTask5V15.txt";

            string f = Path.Combine(a, b);
            string c = ds.CollectTextFromFile(f);
            textBox2.Text = c;

        }
    }
}
