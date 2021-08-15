using System.Collections.Generic;
using System.Linq;

namespace UnitTestSample
{
    public class OrderService
    {
        private readonly List<Order> _orders;
        private readonly OrderAddressService _orderAddressService;
        public OrderService(OrderAddressService orderAddressService)
        {
            _orderAddressService = orderAddressService;

            _orders = new List<Order>
            {
                new Order(1, "20210815001"),
                new Order(2, "20150705985")
            };
        }

        public Order GetOrder(int orderId)
        {
            var order = _orders.FirstOrDefault(x => x.Id == orderId);
            if (order != null)
            {
                var orderAddress = _orderAddressService.GetOrderAddressByOrderId(orderId);
                if (orderAddress != null)
                {
                    order.OrderAddress = orderAddress;
                }
            }
            return order;
        }

    }
}
