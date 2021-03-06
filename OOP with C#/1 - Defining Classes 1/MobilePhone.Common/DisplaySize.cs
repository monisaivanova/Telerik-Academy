﻿using System;

namespace MobilePhone.Common
{
    public struct DisplaySize
    {
        public int? width;
        public int? Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.width = value;
            }
        }

        public int? height;
        public int? Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.height = value;
            }
        }

        public DisplaySize(int? width, int? height)
            : this()
        {
            this.Height = height;
            this.Width = width;
        }

        override public string ToString()
        {
            return this.Height + "x" + this.Width;
        }
    }
}
