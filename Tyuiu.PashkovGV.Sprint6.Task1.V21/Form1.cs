using Tyuiu.PashkovGV.Sprint6.Task1.V21.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task1.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonforresult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;

            string s;

            int w = ds.GetMassFunction(x, y).Length;

            double[] res = ds.GetMassFunction(x,y);
            
            
            result.AppendText("+----------+----------+"+ Environment.NewLine);
            result.AppendText("|         X        |       f(x)      |" + Environment.NewLine);
            result.AppendText("+----------+----------+" + Environment.NewLine); 
            for (int i = 0; i <= w - 1; i++)
            {
                s = String.Format("|   {0,12:d}   |  {1,10:f2}   | ", x, res[i]);
                result.AppendText(s + Environment.NewLine);
                x ++;
            }
            result.AppendText("+----------+----------+");
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
