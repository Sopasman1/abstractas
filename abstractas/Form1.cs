using ShapesForms;
using System.Drawing;

namespace abstractas
{
    public partial class Form1 : Form
    {
        private rectangle rectangle;
        private Circle circle;
        public Form1()
        {
            InitializeComponent();
            rectangle = new rectangle { Width = 5, Height = 10 };
            circle = new Circle { Radius = 7 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Rectangle Area: {rectangle.CalculateArea()}", "Shape Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Circle Area: {circle.CalculateArea()}", "Shape Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
