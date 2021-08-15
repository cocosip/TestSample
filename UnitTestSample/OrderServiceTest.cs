using Moq;
using Xunit;

namespace UnitTestSample
{
    public class OrderServiceTest
    {
        [Fact]
        public void GetOrder_Test()
        {
            var mockOrderAddressService = new Mock<OrderAddressService>();
            mockOrderAddressService.Setup<string>(x => x.Name).Returns("张三");
            //mockOrderAddressService.Setup<string>(x => x.Name).Returns("李四");
            mockOrderAddressService.Setup(x => x.GetOrderAddressByOrderId(It.IsAny<int>())).Returns(new OrderAddress()
            {
                Province = "浙江省",
                City = "温州市",
                Area = "鹿城区",
                Name = "张三"
            });

            //mockOrderAddressService.Setup(x => x.GetOrderAddressByOrderId(It.IsAny<int>())).Returns(new OrderAddress()
            //{
            //    Province = "江苏省",
            //    City = "苏州市",
            //    Area = "xx区",
            //    Name = "李四"
            //});

            var orderService = new OrderService(mockOrderAddressService.Object);
            var order = orderService.GetOrder(1);

            Assert.Equal(1, order.Id);
            Assert.Equal("20210815001", order.OrderNo);

            Assert.Equal("浙江省", order.OrderAddress.Province);
            Assert.Equal("温州市", order.OrderAddress.City);

            //Assert.Equal("江苏省", order.OrderAddress.Province);
            //Assert.Equal("苏州市", order.OrderAddress.City);

            //var order2 = orderService.GetOrder(2);

            //mockOrderAddressService.Verify(x => x.GetOrderAddressByOrderId(It.IsAny<int>()), Times.Once);
            mockOrderAddressService.Verify(x => x.GetOrderAddressByOrderId(It.IsAny<int>()), Times.AtLeastOnce);
        }


    }
}
