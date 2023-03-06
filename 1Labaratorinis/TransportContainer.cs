using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1Labaratorinis
{
    class TransportContainer
    {
        private Transport[] Transports;
        public int Count { get; private set; }
        public int Compacity { get; private set; }
        public TransportContainer( int compacity=16)
        {
            Count = 0;
            Compacity = compacity;
            Transports=new Transport[compacity];
        }
      //  public void ()
    }
}
