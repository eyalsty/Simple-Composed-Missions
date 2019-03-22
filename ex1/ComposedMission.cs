using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
        private List<Operation> operations;

        public String Name { get; }
        public String Type { get; }

        public ComposedMission(string s)
        {
            Name = s;
            Type = "Composed";
            operations = new List<Operation>();
        }

        public ComposedMission Add(Operation op)
        {
            operations.Add(op);
            return this;
        }
        public double Calculate(double value)
        {
            double result = value;
            foreach (var op in operations)  //do all the operations on list
            {
                result = op(result);
            }
            OnCalculate?.Invoke(this, result); //check if not null- invoke the event
            return result;
        }
    }
}
