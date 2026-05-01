using E_ecommerce.Enums;
using E_ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ecommerce.Services
{
    internal class OrderService
    {
        private List<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>
            {
                new Order(1, 101, 1, 2, 120,new DateOnly(2026,4,3), OrderStatus.Received),
                new Order(2, 102, 2, 1, 70, new DateOnly(2026,4,6), OrderStatus.Delivered),
                new Order(3, 101, 1, 3, 180,new DateOnly(2026,4,7), OrderStatus.Shipped),
                new Order(4, 103, 3, 1, 250,new DateOnly(2026,4,9), OrderStatus.Preparing),
                new Order(5, 101, 4, 2, 120,new DateOnly(2026,4,11), OrderStatus.Shipped),
                new Order(6, 104, 1, 4, 400,new DateOnly(2026,4,27), OrderStatus.Delivered),
                new Order(7, 102, 3, 1, 70, new DateOnly(), OrderStatus.Shipped)
            };
        }

        public void ShowAllOrders()
        {
            Console.WriteLine("ALL ORDERS");
            foreach (var order in _orders)
            {
                Console.WriteLine(order);
            }
        }

        public void ShowTotalAmount()
        {
            decimal totalAmount = _orders.Sum(o => o.TotalPrice);
            Console.WriteLine($"TOTAL ORDER'S AMOUNT: {totalAmount}");
        }

        public void ShowUserTotalAmount(int userId)
        {
            decimal userTotal = _orders
                .Where(o => o.UserId == userId)
                .Sum(o => o.TotalPrice);

            Console.WriteLine($"UserId {userId}'S TOTAL AMOUNT: {userTotal}");
        }

        public void ShowMostOrderedProduct()
        {
            var mostOrderedProduct = _orders
                .GroupBy(o => o.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    OrderCount = g.Count(),
                    TotalCount = g.Sum(x => x.TotalCount)
                })
                .OrderByDescending(x => x.OrderCount)
                .ThenByDescending(x => x.TotalCount)
                .FirstOrDefault();

            if (mostOrderedProduct != null)
            {
                Console.WriteLine($"MOST ORDERED PRODUCT: ProductId = {mostOrderedProduct.ProductId}, Sifaris sayi = {mostOrderedProduct.OrderCount}, Umumi say = {mostOrderedProduct.TotalCount}");
            }
        }

        public void ShowOrdersLast3Days()
        {
            var last3DaysOrders = _orders
                .Where(o => o.OrderDate >= new DateOnly());

            Console.WriteLine("Orders placed in the last 3 days");
            foreach (var order in last3DaysOrders)
            {
                Console.WriteLine(order);
            }
        }

        public void ShowShippedOrders()
        {
            var shippedOrders = _orders
                .Where(o => o.OrderStatus == OrderStatus.Shipped);

            Console.WriteLine("Shipped orders");
            foreach (var order in shippedOrders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
