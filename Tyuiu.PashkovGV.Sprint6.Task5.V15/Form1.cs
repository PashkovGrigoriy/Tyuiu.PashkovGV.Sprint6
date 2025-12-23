using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.PashkovGV.Sprint6.Task5.V15.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task5.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Done_Click(object sender, EventArgs e)
        {

            
            string a = @"D:\DataSprint5";
            string b = "InPutDataFileTask5V15.txt";

            string f = Path.Combine(a, b);
            double[] res = ds.LoadFromDataFile(f);
            int len = ds.LoadFromDataFile(f).Length;
            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridView1.Rows.Add(Convert.ToString(res[i]));
            }

        }
    }
}
