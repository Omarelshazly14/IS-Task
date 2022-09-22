using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IOrderDetailsRepo
    {
        List<OrderDetails> GetById(int Id);
        List<OrderDetailsVM> Search(string name);
        //EditOrderDetails GetDetails(int id);

        //void Create(OrderDetails order);
        void SaveChanges();

        bool Exists(string num);
    }
}
