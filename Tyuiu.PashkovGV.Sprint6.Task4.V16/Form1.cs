using Tyuiu.PashkovGV.Sprint6.Task4.V16.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task4.V16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Done_Click(object sender, EventArgs e)
        {
            int startStep = -5;
            int stopStep = 5;

            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);
            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                startStep++;
            }
            int x = -5;
            int y = 5;

            string s;

            int w = ds.GetMassFunction(x, y).Length;

            double[] res = ds.GetMassFunction(x, y);
            textBox1.AppendText("+----------+----------+" + Environment.NewLine);
            textBox1.AppendText("|         X        |       f(x)      |" + Environment.NewLine);
            textBox1.AppendText("+----------+----------+" + Environment.NewLine);
            for (int i = 0; i <= w - 1; i++)
            {
                s = String.Format("|   {0,12:d}   |  {1,10:f2}   | ", x, res[i]);
                textBox1.AppendText(s + Environment.NewLine);
                x++;
            }
            textBox1.AppendText("+----------+----------+");

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            int startStep = -5;
            int stopStep = 5;

            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];
            
            valueArray = ds.GetMassFunction(startStep, stopStep);

            string r = Path.GetTempPath();
            string p = Path.Combine(r, "OutPutFileTask4V16.txt");

            File.WriteAllLines(p, valueArray.Select(h => h.ToString()));

            DialogResult result = MessageBox.Show("файл " + p + " сохранен. Открыть?" ,"Сообщение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = p;
                txt.Start();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
