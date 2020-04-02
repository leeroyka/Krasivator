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
        static int part(int[] arr, int low, int high)
        {
            int pivot = arr[high], loc = low, c;
            for (int i = low; i <= high; i++)
            {
                
                if (arr[i] <pivot)
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

        static int forgetfulSelect(int[] arr,int n)
        {
            int x = (n - 3) / 2;
            int[] a = new int[3 + x];
            int[] b = new int[x];
            Array.Copy(arr, 0, a, 0, 3 + x);
            Array.Copy(arr, 3 + x, b, 0, x);
            
            int shift = 0;
            int it = 0;
            
            while(true)
            {
                //for(int i=0+shift+1;i<a.Length;i++)
                //{
                //    if(a[i]>a[i-1])
                //    {
                //        int c = a[i-1];
                //        a[i - 1] = a[i];
                //        a[i] = c;
                //    }
                //}
                //for (int i = a.Length-2; i >=0+shift; i--)
                //{
                //    if (a[i] < a[i + 1])
                //    {
                //        int c = a[i + 1];
                //        a[i + 1] = a[i];
                //        a[i] = c;
                //    }
                //}
                int max = 0, min = 255,imax=0,imin=0;
                for(int i=0+shift;i<a.Length;i++)
                {
                    if(a[i]>=max)
                    {
                        max = a[i];
                        imax = i;
                    }
                    if(a[i]<=min)
                    {
                        min = a[i];
                        imin = i;
                    }

                }
                int c = a[shift];
                a[shift] = a[imax];
                a[imin] = c;
                c =a[a.Length - 1];
                a[a.Length - 1] = a[imax];
                a[imax] = c;
                shift++;
                if (it >= x)
                    break;
                a[a.Length - 1] = b[it];
                it++;



            }

            return a[a.Length-2];
        }
        
        public static TimeSpan timeResult;
        public static void Median(MyImage img, int m)
        {
            wait();
            DateTime timeStart = DateTime.Now;

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
                    //int medianR = quickSelect(matrixR, 0, m * m - 1, m * m / 2);
                    //int medianG = quickSelect(matrixG, 0, m * m - 1, m * m / 2);
                    //int medianB = quickSelect(matrixB, 0, m * m - 1, m * m / 2);
                    int medianR = forgetfulSelect(matrixR, m * m);
                    int medianG = forgetfulSelect(matrixG, m * m);
                    int medianB = forgetfulSelect(matrixB, m * m);
                    newImage.setPixel(j, i, medianR, medianG, medianB);
                }
            }
            img.bmp = (Bitmap)newImage.bmp.Clone();

            timeResult = DateTime.Now.Subtract(timeStart);
            
            unWait();
        }
        public static void Mask(MyImage img, double[,] matrix,int m,int n)
        {
            (imageW, imageH) = img.getSize();

            DateTime timeStart = DateTime.Now;
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

            timeResult = DateTime.Now.Subtract(timeStart);
            unWait();
        }
       
    }
    
}
