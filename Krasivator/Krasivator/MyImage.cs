using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasivator
{
    
    public class MyImage
    {

        public System.Drawing.Bitmap bmp;

        public MyImage(string filename)    //конструктор - открывает изображение по имени файла
        {
            bmp = (Bitmap)Image.FromFile(filename);
        }

        public MyImage(int w, int h)  //конструктор - создает пустое изображения задонного размера, w Х h - Ширина Х Выстона 
        {
            bmp = new Bitmap(w, h);
        }

        public (int, int, int) getPixel(int x, int y) //Получение значения пикселя с координатами x y
        {
            var p = bmp.GetPixel(x, y);
            return (p.R, p.G, p.B);
        }

        public void setPixel(int x, int y, int r, int g, int b)     //Установка цвета r g b  у пикселя с координатами x y
        {
            bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
        }

        public (int, int) getSize()  //получение размера изображения (Ширина, Выстота)
        {
            return (bmp.Width, bmp.Height);
        }

        public void save(string filename)  //сохранить изображение по имени файла
        {
            bmp.Save(filename);
        }
    }
    static class HELP
    {
        //Ф-ция "жестко вгоняет" значение val в границы диапазона [min, max], если оно из него выбивается
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }
    }
}
