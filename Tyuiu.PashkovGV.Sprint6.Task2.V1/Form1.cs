using Tyuiu.PashkovGV.Sprint6.Task2.V1.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task2.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = -5;
                int stopStep = 5;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len]; // Здесь ошибка: должно быть new double[len]

                valueArray = ds.GetMassFunction(startStep, stopStep);

                //this.chartFunction.Titles.Add("График функции sin(x)");
                //this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                //this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    //this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Done_MouseEnter(object sender, EventArgs e)
        {
            Done.BackColor = Color.Red;
        }

        private void Done_MouseLeave(object sender, EventArgs e)
        {
            Done.BackColor = Color.Green;
        }

        private void Done_MouseDown(object sender, MouseEventArgs e)
        {
            Done.BackColor = Color.Blue;
        }
        

        private void Help_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Задание 2 выполнил студент группы АCОиУб-25-1 Пашков Григорий", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
    
