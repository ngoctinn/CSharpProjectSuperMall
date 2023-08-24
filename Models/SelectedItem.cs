using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SelectedItem : Item
    {
        public int NumberOfSelectedItem { get; set; }
        public int PriceAfterDiscount { get; set; }

        public SelectedItem() { }
        public SelectedItem(int numberOfSelectedItem)
        {
            NumberOfSelectedItem = numberOfSelectedItem;
            CaculatePriceAfterDiscount();
        }

        private void CaculatePriceAfterDiscount()
        {
            if (Discount == null)
            {
                PriceAfterDiscount = Price;

            }
            else
            {
                var currenTime =DateTime.Now;
                if(currenTime >= Discount.StartTime && currenTime < Discount.EndTime)
                {
                    if(Discount.DiscountPricePercent > 0)
                    {
                        PriceAfterDiscount = (int)(Price * (1 - 1.0f * Discount.DiscountPricePercent / 100));
                    }
                    if(Discount.DiscountPriceAmount > 0)
                    {
                        PriceAfterDiscount = Price - Discount.DiscountPriceAmount;
                    }
                }
            }
        }

        public SelectedItem(int itemId, string itemName, string itemType,
            int quatity, string brand, DateTime releaseDate,
            int price, Discount discount, int numberOfSelectedItem) : 
            base(itemId,itemName, itemType, quatity, brand, releaseDate, price,discount)
        {
            NumberOfSelectedItem = numberOfSelectedItem;
            
        }
    }
}
