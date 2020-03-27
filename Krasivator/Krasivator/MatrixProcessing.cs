using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasivator
{
    class MatrixProcessing
    {
        static int imageW, imageH;
        static FormWait frmWait = new FormWait();

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
        private static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static int part(int[] arr, int low, int high)
        {
            int pivot = arr[high], loc = low, c;
            for (int i = low; i <= high; i++)
            {
                
                if (arr[i] < pivot)
                {
                    c = arr[i];
                    arr[i] = arr[loc];
                    arr[loc] = c;
                    loc++;
                }
            }             
            c = arr[high];
            arr[high] = arr[loc];
            arr[loc] = c;

            return loc;
        }        
        static int quickSelect(int[] arr, int low, int high, int k)
        {
            int p = part(arr, low, high);
            if (p == k)
                return arr[p];
            else if (p < k)
                return quickSelect(arr, p + 1, high, k);
            else
                return quickSelect(arr, low, p - 1, k);
        }
        public static void Median(MyImage img, int m)
        {
            wait();
            (imageW, imageH) = img.getSize();
            MyImage newImage = new MyImage(imageW, imageH);
            newImage.bmp = (Bitmap)img.bmp.Clone();
            int[] matrixR = new int[m*m];
            int[] matrixG = new int[m * m];
            int[] matrixB = new int[m * m];
            int n = m / 2;
            for (int i = 0; i < imageH; ++i)
            {
                double c = 100 / (double)imageH;
                wait((int)(c * i));
                for (int j = 0; j < imageW; ++j)
                {
                    int it = 0;
                    for (int _i = 0; _i < m; _i++)
                    {
                        for (int _j = 0; _j <m; _j++)
                        {
                            int nj, ni;
                            nj = j - m / 2 + _j;
                            ni = i - m / 2 + _i;
                            if (nj < 0)
                                nj = j + m / 2 - _j;
                            if (ni < 0)
                                ni = i + m / 2 - _i;
                            if (nj >= imageW)
                            {
                                nj = nj - 2 * (nj - j);
                            }
                            if (ni >= imageH)
                            {
                                ni = ni - 2 * (ni - i);
                            }

                            var (r, g, b) = img.getPixel(nj, ni);
                            matrixR[it] = r;
                            matrixG[it] = g;
                            matrixB[it] = b;
                            it++;
                        }
                    }
                    int medianR = quickSelect(matrixR, 0, m * m - 1, m + 1);
                    int medianG = quickSelect(matrixG, 0, m * m - 1, m + 1);
                    int medianB = quickSelect(matrixB, 0, m * m - 1, m + 1);

                    newImage.setPixel(j, i, medianR, medianG, medianB);
                }
            }
            img.bmp = (Bitmap)newImage.bmp.Clone();
            unWait();
        }
        public static void Mask(MyImage img, double[,] matrix,int m,int n)
        {
            (imageW, imageH) = img.getSize();
            wait();
            MyImage newImage = new MyImage(imageW, imageH);
            newImage.bmp = (Bitmap)img.bmp.Clone();
            for (int i = 0; i < imageH; ++i)
            {
                double c = 100 / (double)imageH;
                wait((int)(c * i));
                for (int j = 0; j < imageW; ++j)
                {
                    
                    double sumR = 0;
                    double sumG = 0;
                    double sumB = 0;
                    for (int _i = 0; _i < m; _i++)
                    {
                        for (int _j = 0; _j < n; _j++)
                        {
                            int nj, ni;
                            nj = j - n / 2 + _j;
                            ni = i - m / 2 + _i;
                            if (nj < 0)
                                nj = j + n / 2 - _j;
                            if (ni < 0)
                                ni = i + m / 2 - _i;
                            if(nj>=imageW)
                            {
                                nj = nj - 2 * (nj - j);
                            }
                            if(ni>=imageH)
                            {
                                ni = ni - 2 * (ni - i);
                            }
                            var (r, g, b) = img.getPixel(nj, ni);
                            sumR += (r * matrix[_j, _i]);
                            sumG += (g * matrix[_j, _i]);
                            sumB += (b * matrix[_j, _i]);
                        }
                    }
                    if (sumR < 0) sumR = 0;
                    if (sumR > 255) sumR = 255;

                    if (sumG < 0) sumG = 0;
                    if (sumG > 255) sumG = 255;

                    if (sumB < 0) sumB = 0;
                    if (sumB > 255) sumB = 255;
                    newImage.setPixel(j, i, (int) sumR, (int)sumG, (int)sumB);
                }
            }
            img.bmp = (Bitmap)newImage.bmp.Clone();
            
            unWait();
        }
    }
}
