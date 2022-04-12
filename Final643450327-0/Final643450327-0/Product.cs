using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final643450327_0
{
    internal class Product
    {
        private string name;
        private double price = 0;
        private double notebook;
        private double pen;
        private double pencil;
        private double ruler;
        private double eraser;
        private double liquid;
        private double color12;
        private double color24;
        private double color36;
        private double color48;
        private int pricenotebook = 20;
        private int pricepen = 7;
        private int pricepencil = 5;
        private int priceruler = 15;
        private int priceeraser = 5;
        private int priceliquid = 20;
        private int pricecolor12 = 60;
        private int pricecolor24 = 80;
        private int pricecolor36 = 120;
        private int pricecolor48 = 175;


        /// <summary>
        /// /
        /// </summary>
        /// <param name="notebook"></param>
        public void addNotebook(double notebook)
        {
            this.notebook = (pricenotebook * notebook);
        }
        public double getNotebook()
        {
            return notebook;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pen"></param>
        public void addPen(double pen)
        {
            this.pen = (pricepen * pen);
        }
        public double getPen()
        {
            return pen;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pencil"></param>
        public void addPencil(double pencil)
        {
            this.pencil = (pricepencil * pencil);
        }
        public double getPencil()
        {
            return pencil;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruler"></param>
        public void addRuler(double ruler)
        {
            this.ruler = (priceruler * ruler);
        }
        public double getRuler()
        {
            return ruler;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eraser"></param>
        public void addEraser(double eraser)
        {
            this.eraser = (priceeraser * eraser);
        }
        public double getEraser()
        {
            return eraser;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="liquiz"></param>
        public void addLiquid(double liquid)
        {
            this.liquid = (priceliquid * liquid);
        }
        public double getLiquid()
        {
            return liquid;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color12"></param>
        public void addColor12(double color12)
        {
            this.color12 = (pricecolor12 * color12);
        }
        public double getColor12()
        {
            return color12;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color24"></param>
        public void addColor24(double color24)
        {
            this.color24 = (pricecolor24 * color24);
        }
        public double getColor24()
        {
            return color24;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color36"></param>
        public void addColor36(double color36)
        {
            this.color36 = (pricecolor36 * color36);
        }
        public double getColor36()
        {
            return color36;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color48"></param>
        public void addColor48(double color48)
        {
            this.color48 = (pricecolor48 * color48);
        }
        public double getColor48()
        {
            return color48;
        }

        public double getPrice()
        {
            this.price = this.notebook + this.pen + this.pencil + this.ruler + this.eraser + this.liquid + this.color12 + this.color24 + this.color36 + this.color48;
            return price;
        }
    }
}
