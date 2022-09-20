using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IOrderHeaderRepo
    {
        IEnumerable<OrderHeader> GetAll();
        OrderHeader GetById(int Id);
    }
}
