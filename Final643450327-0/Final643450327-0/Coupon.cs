using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final643450327_0
{
    internal class Coupon
    {
        private string couponCode = string.Empty;
        private double minimunPrice;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <returns></returns>
       public  void createCoupon(double min)
        {
            this.minimunPrice = min;
            if(min >= 50 && min < 100)
            {
                this.minimunPrice = min - (this.minimunPrice * 0.05);
                this.couponCode = "NSDFE";
            }
            if(min >= 100 && min < 150)
            {
                this.minimunPrice = min - (this.minimunPrice * 0.10);
                this.couponCode = "SDEWR";
            }
            if(min >= 150 && min < 200)
            {
                this.minimunPrice = min - (this.minimunPrice * 0.15);
                this.couponCode = "LIFRT";
            }
            if(min >= 200)
            {
                this.minimunPrice = min - (this.minimunPrice * 0.20);
                this.couponCode = "QEWRA";
            }
        }
        public double getCoupon()
        {
           
            return this.minimunPrice;
        }
        public string getCouponCode()
        {
             return couponCode; 
        }
    }
}
