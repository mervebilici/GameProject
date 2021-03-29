using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderService
    {
        public void Add(Order order, Campaign campaign);
        public void Update(Order order);
        public void Delete(Order order);
    }
}
