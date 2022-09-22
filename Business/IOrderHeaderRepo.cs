using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IOrderHeaderRepo
    {
        OrderHeader GetById(int Id);
        List<OrderHeaderVM> Search(string name);
        //EditOrderHeader GetDetails(int id);

        //void Create(OrderHeader order);
        void SaveChanges();

        bool Exists(int num);
    }
}
