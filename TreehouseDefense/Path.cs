using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }
    }
}
