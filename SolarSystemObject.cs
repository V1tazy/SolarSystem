﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SolarSystem
{
    public class SolarSystemObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double orbit;

        public double Orbit
        {
            get { return orbit; }
            set { orbit = value; }
        }

        private double diameter;

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        private Uri image;

        public Uri Image
        {
            get { return image; }
            set { image = value; }
        }

        private string details;
        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public SolarSystemObject(string name, double orbit, double diameter, Uri image, string details)
        {
            this.name = name;
            this.orbit = orbit;
            this.diameter = diameter;
            this.image = image;
            this.details = details;
        }

        public override string ToString()
        {
            return this.name;
        }


    }
}
