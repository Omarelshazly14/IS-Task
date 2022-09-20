using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrderHeaderRepo : IOrderHeaderRepo
    {
        private IRepository<OrderHeader> repository;

        public OrderHeaderRepo(IRepository<OrderHeader> _repository)
        {
            repository = _repository;
        }

        public IEnumerable<OrderHeader> GetAll()
        {
            return repository.GetAll();
        }

        public OrderHeader GetById(int Id)
        {
            //Here we should include the order details
            return repository.GetById(Id);
        }
    }
}
