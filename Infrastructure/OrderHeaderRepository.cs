using Application;
using Domain;
using Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class OrderHeaderRepository : IOrderHeaderRepo
    {
        private readonly Context db;
        public OrderHeaderRepository(Context _db)
        {
            db = _db;
        }
        public bool Exists(int num)
        {
            return db.Orders.Any(c => c.OrderNo == num);
        }

        public OrderHeader GetById(int Id)
        {
            return db.Orders.Include(o=>o.OrderDetails).FirstOrDefault(o=>o.Id == Id);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public List<OrderHeaderVM> Search(string name)
        {
            var query = db.Orders.Select(c => new OrderHeaderVM()
            {
                CustomerName = c.CustomerName,
                OrderNo = c.OrderNo,
                Address = c.Address,
                Phone = c.Phone,
                //add helper function
                Date = c.Date.ToHijriDate(),
                TotalCost = c.TotalCost
            });

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(c => c.CustomerName.Contains(name));
            }

            return query.OrderBy(c => c.Date).ThenByDescending(c => c.Phone).ToList();
        }
    }
}
