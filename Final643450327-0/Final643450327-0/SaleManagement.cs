using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final643450327_0
{
    internal class SaleManagement
    {
      //  private Coupon[10] coupon;
        private Bill bill;
        double totalPrice = 0;
        public void newBill()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pay"></param>
        /// <param name="getmoney"></param>
        public void Bill(double pay,double getmoney)
        {
            this.totalPrice = getmoney - pay;
        }
        public bool addCoupontoBill(string couponCode)
        {
            return true;
        }
        public bool addProducttoBill(Product p)
        {
            return false;
        }
        public double getBillTotalPrice()
        {
            return 0;
        }
        public double payBill()
        {

            return totalPrice;
        }
    }
}
