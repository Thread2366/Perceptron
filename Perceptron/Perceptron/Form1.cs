using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        Bitmap input = new Bitmap(300, 300);
        Graphics gr;
        Pen drawingPen;
        Pen washingPen;

        Perceptron recognizer;
        bool answer;

        public Form1()
        {
            InitializeComponent();

            recognizer = new Perceptron(input);
            button_clear_Click(this, new EventArgs());
        }

        private void pictureBox_input_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gr.DrawEllipse(drawingPen, new Rectangle(e.X, e.Y, 10, 10));
                pictureBox_input.Image = input;
            }
            else if (e.Button == MouseButtons.Right)
            {
                gr.DrawEllipse(washingPen, new Rectangle(e.X, e.Y, 20, 20));
                pictureBox_input.Image = input;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            pictureBox_input.Image = input;
            gr = Graphics.FromImage(input);
            drawingPen = new Pen(new SolidBrush(Color.Black), 10);
            washingPen = new Pen(new SolidBrush(Color.White), 20);
            gr.Clear(Color.White);
            pictureBox_indicator.BackColor = Color.White;
            panel_learning.Enabled = false;
        }

        private void button_recognize_Click(object sender, EventArgs e)
        {
            answer = recognizer.Recognize(input);
            if (answer)
                pictureBox_indicator.BackColor = Color.Green;
            else
                pictureBox_indicator.BackColor = Color.Red;
            panel_learning.Enabled = true;
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            panel_learning.Enabled = false;
            button_clear_Click(this, new EventArgs());
        }

        private void button_wrong_Click(object sender, EventArgs e)
        {
            panel_learning.Enabled = false;
            recognizer.WrongAnswer(answer);
            button_clear_Click(this, new EventArgs());
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            openFileDialog_weights.Title = "Открыть";
            openFileDialog_weights.FileName = "";
            openFileDialog_weights.InitialDirectory = 
                Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Weights"));
            openFileDialog_weights.ShowDialog();
            string fileName = openFileDialog_weights.FileName;
            try
            {
                if (fileName != "")
                {
                    recognizer.LoadWeights(fileName);
                    MessageBox.Show("Веса успешно загружены!");
                }
            }
            catch
            {
                MessageBox.Show("Файл отсутсвует или поврежден.");
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog_weights.Title = "Сохранить";
            saveFileDialog_weights.FileName = "";
            saveFileDialog_weights.InitialDirectory =
                Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Weights"));
            saveFileDialog_weights.ShowDialog();
            string fileName = saveFileDialog_weights.FileName;
            if (fileName != "")
            {
                recognizer.SaveWeights(fileName);
                MessageBox.Show("Веса успешно сохранены!");
            }
        }
    }
}
