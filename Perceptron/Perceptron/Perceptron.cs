using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Perceptron
    {
        private int[,] scaled;
        private int[,] weights;
        private int[,] input;
        private int limit;

        private int inputWidth;
        private int inputHeight;

        private int sum;
        
        public Perceptron(Bitmap inp)
        {
            inputWidth = inp.Width;
            inputHeight = inp.Height;
            scaled = new int[inputWidth, inputHeight];
            weights = new int[inputWidth, inputHeight];
            input = new int[inputWidth, inputHeight];
            limit = inputWidth * inputHeight / 100;
        }

        public bool Recognize(Bitmap inp)
        {
            for (int i = 0; i < inputWidth; i++)
            {
                for (int j = 0; j < inputHeight; j++)
                {
                    input[i, j] = (inp.GetPixel(i, j).R == 255) ? 0 : 1;
                    scaled[i, j] = weights[i, j] * input[i, j]; 
                }
            }

            sum = scaled
                .Cast<int>()
                .Sum();

            return sum > limit;
        }
        
        public void WrongAnswer(bool actualAnswer)
        {
            for (int i = 0; i < inputWidth; i++)
            {
                for (int j = 0; j < inputHeight; j++)
                {
                    if (actualAnswer)
                    {
                        weights[i, j] -= input[i, j];
                    }
                    else
                    {
                        weights[i, j] += input[i, j];
                    }
                }
            }
        }

        public void SaveWeights(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            for (int i = 0; i < inputHeight; i++)
            {
                for (int j = 0; j < inputWidth; j++)
                {
                    sw.Write(weights[j, i]);
                    sw.Write(' ');
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public void LoadWeights(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            int[,] temp = new int[inputWidth, inputHeight];
            for (int i = 0; i < inputHeight; i++)
            {
                var sp = sr.ReadLine().Split(' ');
                for (int j = 0; j < inputWidth; j++)
                {
                    temp[j, i] = int.Parse(sp[j]);
                }
            }
            weights = temp;
            sr.Close();
        }
    }
}
