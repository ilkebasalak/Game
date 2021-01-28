using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IorderService
    {
        void Add(Order order);
        void Update(Order order);

        void Delete(Order order);
    }
}
