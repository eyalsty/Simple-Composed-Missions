using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private Operation operation;
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        public String Name { get; }
        public String Type { get; }

        public SingleMission(Operation op, string s)
        {
            operation = op;
            Name = s;
            Type = "Single";
        }

        public double Calculate(double value)
        {
            double result = operation(value);

            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
