﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Car
    {
        private string _make;
        private string _model;
        private int _year;

        public string Make { get { return _make; } set { _make = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int Year {  get { return _year; } set { _year = value; } }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;

        }
    }
}
