using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace James
{
    class _debug
    {
        public _debug(string[] args)
        {
            var response = Hey(args.DefaultIfEmpty(string.Empty).FirstOrDefault());
            Console.WriteLine(response);
        }

        private static string Hey(string arg)
        {
            var bob = new Bob();
            return bob.Hey(arg);
        }
    }
}
