using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Discount
    {
        private static int s_autoId = 1000000;
        public int DiscountId { get; set; }
        public  string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DiscountType  { get; set; }
        public int DiscountPriceAmount { get; set; }
        public int DiscountPricePercent { get; set; }
        public Discount()        {    }
        public Discount(int discountId, string name, DateTime startTime,DateTime endTime, string discountType, int discountPriceAmount, int discountPricePercent)
        {
            DiscountId = discountId;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            DiscountType = discountType;
            DiscountPriceAmount = discountPriceAmount;
            DiscountPricePercent = discountPricePercent;
        }

        public override bool Equals(object obj)
        {
            return obj is Discount discount &&
                   DiscountId == discount.DiscountId;
        }

        public override int GetHashCode()
        {
            return 1574009819 + DiscountId.GetHashCode();
        }
        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }
    }
}
