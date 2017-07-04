using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2008, 5, 1, 8, 6, 32,
                                 new TimeSpan(1, 0, 0));
            }
            return order;
        }

        public bool Save()
        {
            return true;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //Code that retrieves the defined order fields.

            // Temporary hard coded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(1, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "MiddleEarth",
                    PostalCode = "144"
                };
            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            //Code that retrieves the order items.

            //Temporary hard coded data
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };

                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay; 
        }


    }
}
