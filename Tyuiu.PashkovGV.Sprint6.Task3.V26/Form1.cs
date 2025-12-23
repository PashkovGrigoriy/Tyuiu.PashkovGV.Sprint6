using Tyuiu.PashkovGV.Sprint6.Task3.V26.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task3.V26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,]
            {
                { 16,  19,  17,   2,   8 },

                { -17,   8, -17,  -8,   1 },

                {  -7,  17,  -2,   1,  -3 },

                {-12,   0, -17,  15,   6 },

                { 17,  -6, -17,  18, -19, }
            };
   

            int[,] res = ds.Calculate(matrix);

            // Вывод в DataGridView
            dataGridView1.RowCount = res.GetLength(0);
            dataGridView1.ColumnCount = res.GetLength(1);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = res[i, j];
                }
            }
        }
    }
}
