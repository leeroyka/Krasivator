using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Krasivator
{
    class FreqFilter
    {
        public static Complex[] DFT(Complex[] X, double n = 1)
        {
            int N = X.Length;
            Complex[] G = new Complex[N];
            for (int u = 0; u < N; ++u)
            {
                for (int k = 0; k < N; ++k)
                {
                    double fi = -2.0 * Math.PI * u * k / N;
                    G[u] += (new Complex(Math.Cos(fi), Math.Sin(fi)) * X[k]);
                }
                G[u] *= n; 
            }
            return G;
        }
        static int imageW, imageH;
        static FormWait frmWait = new FormWait();
        static MyImage dftImage;
        private static void wait()
        {
            frmWait.Show();
        }
        private static void wait(int value)
        {
            frmWait.setValue(value);
        }
        private static void unWait()
        {
            frmWait.Hide();
        }
        static Complex[,] matrixR, matrixG, matrixB;
        

        // С данного момента лучше не смотреть

        public static MyImage deDFT(MyImage img,int[,] matrix)
        {

            wait();
            for (int i=0;i<imageH;i++)
            {
                for(int j=0;j<imageW;j++)
                {

                    matrixR[j, i] = new Complex(matrixR[j, i].Real, -matrixR[j, i].Imaginary);
                    matrixG[j, i] = new Complex(matrixG[j, i].Real, -matrixG[j, i].Imaginary);
                    matrixB[j, i] = new Complex(matrixB[j, i].Real, -matrixB[j, i].Imaginary);

                    if(matrix[j,i]==0)
                    {
                        matrixR[j, i] = new Complex();
                        matrixG[j, i] = new Complex();
                        matrixB[j, i] = new Complex();
                    }
                }
            }
           

            for(int i=0;i<imageH;i++)
            {
                double c = 50 / (double)imageH;
                wait((int)(c * i));
                Complex[] cR = new Complex[imageW];
                Complex[] cG = new Complex[imageW];
                Complex[] cB = new Complex[imageW];
                for (int j=0;j<imageW;j++)
                {
                    cR[j] = matrixR[j, i];
                    cG[j] = matrixG[j, i];
                    cB[j] = matrixB[j, i];

                }
                cR = DFT(cR);
                cG = DFT(cG);
                cB = DFT(cB);
                for(int j=0;j<imageW;j++)
                {
                    matrixR[j, i] = cR[j];
                    matrixG[j, i] = cG[j];
                    matrixB[j, i] = cB[j];
                }
            }

            Complex[] columnR = new Complex[imageH];
            Complex[] columnG = new Complex[imageH];
            Complex[] columnB = new Complex[imageH];
            for (int i=0;i<imageW;i++)
            {
                double c = 50 / (double)imageW;
                wait((int)(c * i)+50);
                for (int j=0;j<imageH;j++)
                {
                    columnR[j] = matrixR[i, j];
                    columnG[j] = matrixG[i, j];
                    columnB[j] = matrixB[i, j];
                }
                columnR = DFT(columnR);
                columnG = DFT(columnG);
                columnB = DFT(columnB);
                for(int j=0;j<imageH;j++)
                {
                    int r, g, b;
                    r = Convert.ToInt32(columnR[j].Real * Math.Pow(-1, i + j));
                    g = Convert.ToInt32(columnG[j].Real * Math.Pow(-1, i + j));
                    b = Convert.ToInt32(columnB[j].Real * Math.Pow(-1, i + j));

                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;
                    img.setPixel(i, j, r, g, b);
                }
            }
            unWait();
            return img;
        }
        public static MyImage createDFT(MyImage img)
        {
            (imageW, imageH) = img.getSize();
            dftImage = new MyImage(imageW, imageH);
            wait();


            int[] rowR = new int[imageW];
            
            int[] rowG = new int[imageW];
            int[] rowB = new int[imageW];
             matrixR = new Complex[imageW, imageH];
             matrixG = new Complex[imageW, imageH];
             matrixB = new Complex[imageW, imageH];

            for (int i = 0; i < imageH; ++i)
            {
                double c = 50 / (double)imageH;
                wait((int)(c * i));
                for (int j = 0; j < imageW; ++j)
                {
                    int r, g, b;
                    (r, g, b) = img.getPixel(j, i);
                    rowR[j] = r * (int)Math.Pow(-1,i+j);
                    rowG[j] = g * (int)Math.Pow(-1, i + j);
                    rowB[j] = b * (int)Math.Pow(-1, i + j);
                }
                var cR = rowR.Select(x => new Complex(x, 0)).ToArray();
                var cG = rowG.Select(x => new Complex(x, 0)).ToArray();
                var cB = rowB.Select(x => new Complex(x, 0)).ToArray();
                
                var furierR = DFT(cR, 1.0 / imageW);
                var furierG = DFT(cG, 1.0 / imageW);
                var furierB = DFT(cB, 1.0 / imageW);
                for (int j = 0; j < imageW; ++j)
                {
                    matrixR[j, i] = furierR[j];
                    matrixG[j, i] = furierG[j];
                    matrixB[j, i] = furierB[j];
                }

            }
            Complex[] columnR = new Complex[imageH];
            Complex[] columnG = new Complex[imageH];
            Complex[] columnB = new Complex[imageH];
            double maxR=0, maxG=0, maxB = 0;
            for (int i = 0; i < imageW; ++i)
            {
                double c = 50 / (double)imageW;
                wait((int)(c * i)+50);
                for (int j = 0; j < imageH; ++j)
                {
                    columnR[j] = matrixR[i, j];
                    columnG[j] = matrixG[i, j];
                    columnB[j] = matrixB[i, j];

                }

                var furierR = DFT(columnR, 1.0 / imageH);
                var furierG = DFT(columnG, 1.0 / imageH);
                var furierB = DFT(columnB, 1.0 / imageH);
                for (int j = 0; j < imageH; ++j)
                {

                    matrixR[i, j] = furierR[j];
                    matrixG[i, j] = furierG[j];
                    matrixB[i, j] = furierB[j];

                    int r, g, b;
                    int ca = 50;
                    
                    r = Convert.ToInt32(Math.Log(furierR[j].Magnitude+1))*ca;
                    g = Convert.ToInt32(Math.Log(furierG[j].Magnitude+1)) * ca;
                    b = Convert.ToInt32(Math.Log(furierB[j].Magnitude+1)) * ca;
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;
                    dftImage.setPixel(i, j, r, g, b);
                }

            }

            unWait();
            return dftImage;
        }
    }
}
