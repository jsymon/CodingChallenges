using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etl
{
    class _debug
    {
        public _debug(string[] args)
        {
            new ETLTest().Transforms_one_value();
        }

        static void delegateTest()
        {
            var a = new Action<string>(delegate(string arg) { });
            var b = new Action<string>((string arg) => { });
            var c = new Action<string>(arg => { });
            var d = new Action<string>((string bob) => { });
        }
    }
}
