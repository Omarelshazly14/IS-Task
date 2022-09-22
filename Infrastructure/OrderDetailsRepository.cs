using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class OrderDetailsRepository:IOrderDetailsRepo
    {
        private readonly Context db;
        public OrderDetailsRepository(Context _db)
        {
            db = _db;
        }

        public bool Exists(string num)
        {
            return db.OrderDetails.Any(c => c.ItemNo == num);
        }

        public List<OrderDetails> GetById(int Id)
        {
            return db.OrderDetails.Where(o => o.OrderID == Id).ToList();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public List<OrderDetailsVM> Search(string name)
        {
            var query = db.OrderDetails.Select(c => new OrderDetailsVM()
            {
             ItemNo = c.ItemNo,
             ItemDescription = c.ItemDescription,
             ItemPrice = c.ItemPrice,
             Quantity = c.Quantity

            });

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(c => c.ItemDescription.Contains(name));
            }

            return query.OrderBy(c => c.ItemNo).ThenByDescending(c => c.ItemPrice).ToList();
        }
    }
}
