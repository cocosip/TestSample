namespace UnitTestSample
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public OrderAddress OrderAddress { get; set; }

        public Order()
        {

        }

        public Order(int id, string orderNo)
        {
            Id = id;
            OrderNo = orderNo;
        }
    }

    public class OrderAddress
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Detail { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        public OrderAddress()
        {

        }

        public OrderAddress(string province, string city, string area, string detail)
        {
            Province = province;
            City = city;
            Area = area;
            Detail = detail;
        }
    }

}
