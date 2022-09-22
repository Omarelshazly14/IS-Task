using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IOrderDetailsApplication
    {
        List<OrderDetailsVM> Search(string command);

    }
}
