﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace AVL
{
    public class Lingkaran
    {
        public int x;
        public int y;
        public string value;
        public string meaning;
        public Brush brush;
        public Lingkaran(int x, int y, string value,string meaning)
        {
            this.x = x;
            this.y = y;
            this.value = value;
            this.meaning = meaning;
            brush = new SolidBrush(Color.Black);
        }
    }
}
