using System.Collections.Generic;

namespace UnitTestSample
{
    public class OrderAddressService
    {
        public virtual string Name { get; set; }
        private readonly Dictionary<int, OrderAddress> _orderAddressDict;
        public OrderAddressService()
        {
            _orderAddressDict = new Dictionary<int, OrderAddress>
            {
                { 1, new OrderAddress("浙江省", "温州市", "鹿城区", "xxxx") },
                { 2, new OrderAddress("浙江省", "杭州市", "滨江区", "xxxx") }
            };
        }

        public virtual OrderAddress GetOrderAddressByOrderId(int orderId)
        {
            var orderAddress = _orderAddressDict[orderId];
            orderAddress.Name = Name;
            return orderAddress;
        }

    }
}
