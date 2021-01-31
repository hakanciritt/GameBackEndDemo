using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEndDemo
{
    interface ISalesService
    {
        void Sales(Gamer gamer, List<string> games);
    }
}
