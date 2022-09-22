using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class OrderDetailsApplication : IOrderDetailsApplication
    {
        private readonly IOrderDetailsRepo orderDetailsRepo;
        public OrderDetailsApplication(IOrderDetailsRepo _repo)
        {
            orderDetailsRepo = _repo;
        }

        public List<OrderDetailsVM> Search(string command)
        {
            return orderDetailsRepo.Search(command);
        }
    }
}
