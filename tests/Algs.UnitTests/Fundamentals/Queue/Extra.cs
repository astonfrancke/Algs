using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Queue;

namespace Algs.UnitTests.Fundamentals.Queue
{
    public class Extra
    {
        private static IEnumerable<string> GetTobeInput()
        {
            var tobe = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../../InputData/tobe.txt"));

            var input = tobe.Split(" ");

            return input;
        }
    }
}
