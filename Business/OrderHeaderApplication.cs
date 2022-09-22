using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class OrderHeaderApplication : IOrderHeaderApplication
    {
        private readonly IOrderHeaderRepo _orderHeaderRepository;
        public OrderHeaderApplication(IOrderHeaderRepo repo)
        {
            _orderHeaderRepository = repo;
        }

        public List<OrderHeaderVM> Search(string name)
        {
            return _orderHeaderRepository.Search(name);
        }
    }
}
