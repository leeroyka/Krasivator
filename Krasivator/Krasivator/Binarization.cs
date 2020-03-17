using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasivator
{
    class Binarization
    {
        static int sum = 0;
        static int imageW, imageH;
        static FormWait frmWait = new FormWait();
        static int[] hist;
        static int maxI;
        private static void SetMonochrome(MyImage img)
        {
            sum = 0;
            maxI = 0;
            (imageW, imageH) = img.getSize();
            for (int i = 0; i < imageH; ++i)
            {
                double c = 50 / (double)imageH;
                wait((int)(c * i));
                for (int j = 0; j < imageW; ++j)
                {
                    var (r, g, b) = img.getPixel(j, i);

                    int paramI = (int)(0.215 * (double)r + 0.7154 * (double)g + 0.01725 * (double)b);
                    sum += paramI;
                    if (paramI > maxI)
                        maxI = paramI;
                    img.setPixel(j, i, paramI, paramI, paramI);
                }
            }
        }
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
        public static void MethodGavr (MyImage img)
        {
            wait();
            SetMonochrome(img);
            int t = sum / (imageW*imageH);
            for (int i = 0; i < imageH; ++i)
            {
                double c = 50 / (double)imageH;
                wait((int)(c * i)+50);
                for (int j = 0; j < imageW; ++j)
                {
                    var (r, g, b) = img.getPixel(j, i);

                    if(r<t)
                        img.setPixel(j, i, 0, 0, 0);
                    else
                        img.setPixel(j, i, 255, 255, 255);
                }
            }
            unWait();
        }
        public static void CalculateHistogram(MyImage img)
        {
            for (int i = 0; i < imageH; ++i)
            {
                double c = 25 / (double)imageH;
                wait((int)(c * i) + 50);
                for (int j = 0; j < imageW; ++j)
                {
                    var (r, g, b) = img.getPixel(j, i);

                    hist[r]++;
                }
            }
        }
        public static void MethodNiblec(MyImage img,int param,double k)
        {
            wait();
            SetMonochrome(img);
            int a = param / 2;
            for (int i = 0; i < imageH; ++i)
            {
                double c = 50 / (double)imageH;
                wait((int)(c * i) + 50);
                for (int j = 0; j < imageW; ++j)
                {
                    
                    int sum = 0;
                    int sum2 = 0;
                    int count = 0;

                    var (r, g, b) = img.getPixel(j, i);
                    for (int _i=i-a;_i<=i+a;_i++)
                    {
                        for(int _j=j-a;_j<=j+a;_j++)
                        {
                            if (_j < 0 || _j >= imageW || _i < 0 || _i >= imageH)
                                continue;
                            var (_r, _g, _b) = img.getPixel(_j, _i);
                            sum += _r;
                            sum2 += _r * _r;
                            count++;
                        }
                    }
                    double m = sum / count;
                    double m2 = sum2 / count;
                    double d = m2 - m * m;
                    double otkl = Math.Sqrt(d);
                    double t = m + k * otkl;
                    if (r <= t)
                        img.setPixel(j, i, 0, 0, 0);
                    else
                        img.setPixel(j, i, 255, 255, 255);
                }
            }
            unWait();
        }
        public static void MethodOtsu(MyImage img)
        {
            hist = new int[256];
            wait();
            SetMonochrome(img);
            
            CalculateHistogram(img);
            int delta = 0;
            int maxt = 0;
            for(int t=2;t<=maxI;t++)
            {
                int sumN = 0;
                for (int i = 0; i < t; i++)
                    sumN += hist[i];
                int w1 = sumN;         
                int w2 = 1 - w1;
                if (w1 == 0 || w2 == 0)
                    continue;
                int sumIN = 0;
                for (int i = 0; i < t; i++)
                {
                    sumIN += i * hist[i];
                }
                int sumIN2 = 0;
                for (int i = 0; i <= maxI; i++)
                {
                    sumIN2 += i * hist[i];
                }
                int q1 = sumIN/ w1;
                int q2 = (sumIN2 - q1 * w1) / w2;
                int d = w1 * w2 * (q1 - q2) * (q1 - q2);
                if (d > delta)
                {
                    delta = d;
                    maxt = t;
                }


            }


            for (int i = 0; i < imageH; ++i)
            {
                double c = 25 / (double)imageH;
                wait((int)(c * i) + 75);
                for (int j = 0; j < imageW; ++j)
                {
                    var (r, g, b) = img.getPixel(j, i);

                    if (r < maxt)
                        img.setPixel(j, i, 0, 0, 0);
                    else
                        img.setPixel(j, i, 255, 255, 255);
                }
            }
            unWait();
        }


            
    }
}
