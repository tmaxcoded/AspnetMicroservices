using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {

        public ShoppingCart()
        {

        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }


        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

       

        public decimal TotalPrice
        {
            get  {
                decimal totalprice = 0;

                if (Items.Count == 0) return totalprice;
                foreach (var item in Items)
                {
                    totalprice = totalprice + (item.Price * item.Quantity);
                }

                return totalprice;
               
            }
        }
    }
}
