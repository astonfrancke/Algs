using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Stack;

namespace Algs.UnitTests.Fundamentals.Stack
{
    public class Extra
    {
        private static IEnumerable<string> GetTobeInput()
        {
            var tobe = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../../InputData/tobe.txt"));

            var input = tobe.Split(" ");

            return input;
        }

        [Fact]
        public void LinkedListTobe()
        {
            var input = GetTobeInput();
            var output = "";


            var stack = new LinkedListStack<string>();

            foreach (var word in input)
            {
                if (!word.Equals("-"))
                    stack.Push(word);
                else if (!stack.IsEmpty())
                    output += stack.Pop() + " ";
            }

            output += "(" + stack.Size() + " left on stack)";

            Assert.Equal("to be not that or be (2 left on stack)", output);
        }



        [Fact]
        public void ResizingArrayTobe()
        {
            var input = GetTobeInput();
            var output = "";

            var stack = new ResizingArrayStack<string>();

            foreach (var word in input)
            {
                if (!word.Equals("-"))
                    stack.Push(word);
                else if (!stack.IsEmpty())
                    output += stack.Pop() + " ";
            }

            output += "(" + stack.Size() + " left on stack)";

            Assert.Equal("to be not that or be (2 left on stack)", output);
        }

        [Theory]
        [InlineData("( 1 + ( ( 2 + 3 ) * ( 4 * 5 ) ) )", 101.0)]
        [InlineData("( ( 1 + sqrt ( 5,0 ) ) / 2,0 )", 1.618033988749895)]
        public void LinkedListDijkstraEval(string input, double output)
        {
            var ops = new LinkedListStack<string>();
            var vals = new LinkedListStack<double>();
            var chars = input.Split(" ");
            foreach (var s in chars)
            { // Read token, push if operator.
                if (s.Equals("(")) ;
                else if (s.Equals("+")) ops.Push(s);
                else if (s.Equals("-")) ops.Push(s);
                else if (s.Equals("*")) ops.Push(s);
                else if (s.Equals("/")) ops.Push(s);
                else if (s.Equals("sqrt")) ops.Push(s);
                else if (s.Equals(")"))
                { // Pop, evaluate, and push result if token is ")".
                    string op = ops.Pop();
                    double v = vals.Pop();
                    if (op.Equals("+")) v = vals.Pop() + v;
                    else if (op.Equals("-")) v = vals.Pop() - v;
                    else if (op.Equals("*")) v = vals.Pop() * v;
                    else if (op.Equals("/")) v = vals.Pop() / v;
                    else if (op.Equals("sqrt")) v = Math.Sqrt(v);
                    vals.Push(v);
                } // Token not operator or paren: push double value.
                else vals.Push(double.Parse(s));
            }

            Assert.Equal(output, vals.Pop());
        }

        [Theory]
        [InlineData("( 1 + ( ( 2 + 3 ) * ( 4 * 5 ) ) )", 101.0)]
        [InlineData("( ( 1 + sqrt ( 5,0 ) ) / 2,0 )", 1.618033988749895)]
        public void ResizingArrayDijkstraEval(string input, double output)
        {
            var ops = new ResizingArrayStack<string>();
            var vals = new ResizingArrayStack<double>();
            var chars = input.Split(" ");
            foreach (var s in chars)
            { // Read token, push if operator.
                if (s.Equals("(")) ;
                else if (s.Equals("+")) ops.Push(s);
                else if (s.Equals("-")) ops.Push(s);
                else if (s.Equals("*")) ops.Push(s);
                else if (s.Equals("/")) ops.Push(s);
                else if (s.Equals("sqrt")) ops.Push(s);
                else if (s.Equals(")"))
                { // Pop, evaluate, and push result if token is ")".
                    string op = ops.Pop();
                    double v = vals.Pop();
                    if (op.Equals("+")) v = vals.Pop() + v;
                    else if (op.Equals("-")) v = vals.Pop() - v;
                    else if (op.Equals("*")) v = vals.Pop() * v;
                    else if (op.Equals("/")) v = vals.Pop() / v;
                    else if (op.Equals("sqrt")) v = Math.Sqrt(v);
                    vals.Push(v);
                } // Token not operator or paren: push double value.
                else vals.Push(double.Parse(s));
            }

            Assert.Equal(output, vals.Pop());
        }
    }
}
