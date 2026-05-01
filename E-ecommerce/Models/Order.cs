using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_ecommerce.Enums;

namespace E_ecommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int TotalCount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateOnly OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Order(int id, int productId, int userId, int totalCount, decimal totalPrice, DateOnly orderDate, OrderStatus orderStatus)
        {
            Id = id;
            ProductId = productId;
            UserId = userId;
            TotalCount = totalCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }

        public override string ToString()
        {
            return $"Order Id: {Id}, ProductId: {ProductId}, UserId: {UserId}, Count: {TotalCount}, Price: {TotalPrice}, Date: {OrderDate}, Status: {OrderStatus}";
        }
    }
}
