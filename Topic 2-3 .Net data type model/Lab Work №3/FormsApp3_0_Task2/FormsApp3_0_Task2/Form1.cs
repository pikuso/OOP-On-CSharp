namespace FormsApp3_0_Task2
{
    public partial class Form1 : Form
    {
        private Point[] trianglePoints;
        private double area;

        public Form1()
        {
            InitializeComponent(); 
            this.Paint += new PaintEventHandler(Form1_PPaint); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(textBoxX1.Text);
            int y1 = int.Parse(textBoxY1.Text);
            int x2 = int.Parse(textBoxX2.Text);
            int y2 = int.Parse(textBoxY2.Text);
            int x3 = int.Parse(textBoxX3.Text);
            int y3 = int.Parse(textBoxY3.Text);

            trianglePoints = new Point[] {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
            labelArea.Text = "??????? ????????????: " + area.ToString();

            this.Invalidate();
        }

        private void Form1_PPaint(object sender, PaintEventArgs e)
        {
            if (trianglePoints != null)
            {
                Pen pen = new Pen(Color.Black);
                e.Graphics.DrawPolygon(pen, trianglePoints);
            }
        }
    }
}
