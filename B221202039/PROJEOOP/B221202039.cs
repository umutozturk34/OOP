// ******************************************************************
// **             STUDENT NAME : Mustafa Umut ÖZTÜRK               **
// **             STUDENT NUMBER : B221202039                      **
// ******************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace B221202039
{
    public partial class B221202039 : Form
    {
        private Random random = new Random(); // Random number generator
        private Polygon polygon = new Polygon(); // Create polygon object

        public B221202039()
        {
            InitializeComponent(); // Initialize form components
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default values in textboxes
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 4.ToString();
            textBox4.Text = 5.ToString();
            textBox5.Text = 30.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generate random values for polygon properties
            textBox1.Text = random.Next(0, 4).ToString();
            textBox2.Text = random.Next(0, 4).ToString();
            textBox3.Text = random.Next(3, 10).ToString();
            textBox4.Text = random.Next(3, 11).ToString();
            textBox5.Text = random.Next(0, 360).ToString();
        }

        private void DrawPolygon()
        {
            if (polygon.Vertices != null) // Check if vertices are set
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White); // Clear the picturebox
                Pen pen = new Pen(Color.Black, 2);

                double pictureboxCenterX = pictureBox1.Size.Width / 2; // Find center X
                double pictureboxCenterY = pictureBox1.Size.Height / 2; // Find center Y
                double scaling = 12; // Scaling factor for drawing

                Point[] points = new Point[polygon.Vertices.Length];
                for (int i = 0; i < polygon.Vertices.Length; i++)
                {
                    // Convert vertex coordinates to picturebox coordinates
                    int x = (int)((polygon.Vertices[i].x - polygon.Center.x) * scaling + pictureboxCenterX);
                    int y = (int)((polygon.Vertices[i].y - polygon.Center.y) * scaling + pictureboxCenterY);
                    points[i] = new Point(x, y);
                    listBox1.Items.Add($"Vertex {i + 1}: ({Math.Round(polygon.Vertices[i].x, 2)}, {Math.Round(polygon.Vertices[i].y, 2)})");
                }

                g.DrawPolygon(pen, points); // Draw the polygon
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Read values from textboxes
                polygon.Center.x = double.Parse(textBox1.Text);
                polygon.Center.y = double.Parse(textBox2.Text);
                polygon.Length = double.Parse(textBox3.Text);
                polygon.NumberOfEdges = int.Parse(textBox4.Text);

                polygon.CalculateEdgeCoordinates(); // Calculate vertices
                listBox1.Items.Clear();
                pictureBox1.Refresh();

                DrawPolygon(); // Draw the polygon
            }
            catch (FormatException)
            {
                // Show error if inputs are invalid
                MessageBox.Show("Please enter valid numbers in all text boxes.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (polygon.Vertices != null && polygon.Vertices.Length > 0)
            {
                try
                {
                    // Rotate polygon by given angle
                    double angle = double.Parse(textBox5.Text);
                    polygon.RotatePolygon(angle);
                    listBox1.Items.Clear();
                    DrawPolygon();
                }
                catch (FormatException)
                {
                    // Show error if angle is invalid
                    MessageBox.Show("Please enter a valid angle.");
                }
            }
            else
            {
                // Show error if polygon is not drawn
                MessageBox.Show("Please draw a polygon first.");
            }
        }
    }

    public class Point2D
    {
        public double x { get; set; } // X coordinate
        public double y { get; set; } // Y coordinate

        public Point2D()
        {
            x = 0; // Initialize X
            y = 0; // Initialize Y
        }

        public Point2D(double X, double Y)
        {
            x = X; // Set X
            y = Y; // Set Y
        }

        public void printCoordinates()
        {
            Console.WriteLine($"({x},{y})"); // Print Cartesian coordinates
        }

        public (double, double) calculatePolarCoordinates()
        {
            double r = Math.Sqrt(x * x + y * y); // Calculate radius
            double theta = Math.Atan2(y, x) * (180 / Math.PI); // Calculate angle in degrees
            return (r, theta); // Return polar coordinates
        }

        public void calculateCartesianCoordinates(double r, double theta)
        {
            x = r * Math.Cos(theta); // Calculate X from polar coordinates
            y = r * Math.Sin(theta); // Calculate Y from polar coordinates
        }

        public void printPolarCoordinates()
        {
            double r = Math.Sqrt(x * x + y * y); // Calculate radius
            double theta = Math.Atan2(y, x) * (180 / Math.PI); // Calculate angle in degrees
            Console.WriteLine($"Polar Coordinates: (r={r}, Degree={theta})"); // Print polar coordinates
        }
    }

    public class Polygon
    {
        public Point2D Center { get; set; } // Center point
        public double Length { get; set; } // Side length
        public int NumberOfEdges { get; set; } // Number of edges
        public Point2D[] Vertices; // Vertices array

        public Polygon()
        {
            Center = new Point2D(0, 0); // Initialize center
            Length = 0; // Initialize length
            NumberOfEdges = 0; // Initialize number of edges
            Vertices = new Point2D[NumberOfEdges]; // Initialize vertices array
        }

        public Polygon(double r, Point2D center, int a)
        {
            Center = center; // Set center
            Length = r; // Set length
            NumberOfEdges = a; // Set number of edges
            Vertices = new Point2D[NumberOfEdges]; // Initialize vertices array
        }

        public void CalculateEdgeCoordinates()
        {
            Vertices = new Point2D[NumberOfEdges]; // Initialize vertices array
            double radius = Length / (2 * Math.Sin(Math.PI / NumberOfEdges)); // Calculate radius
            double theta = 360.0 / NumberOfEdges; // Angle between vertices

            for (int i = 0; i < NumberOfEdges; i++)
            {
                double currentTheta = Math.PI * i * theta / 180; // Convert angle to radians
                double x = Center.x + radius * Math.Cos(currentTheta); // Calculate X
                double y = Center.y + radius * Math.Sin(currentTheta); // Calculate Y
                Vertices[i] = new Point2D(x, y); // Assign vertex
            }
        }

        public void RotatePolygon(double angle)
        {
            double radian = angle * Math.PI / 180; // Convert angle to radians
            for (int i = 0; i < NumberOfEdges; i++)
            {
                // Rotate each vertex around the center
                double newX = (Vertices[i].x - Center.x) * Math.Cos(radian) - (Vertices[i].y - Center.y) * Math.Sin(radian) + Center.x;
                double newY = (Vertices[i].x - Center.x) * Math.Sin(radian) + (Vertices[i].y - Center.y) * Math.Cos(radian) + Center.y;
                Vertices[i].x = newX; // Set new X
                Vertices[i].y = newY; // Set new Y
            }
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new B221202039()); // Start form
        }
    }
}
