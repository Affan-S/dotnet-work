using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class ExpenseType
    {
        public string label;

        public double value;

        public ExpenseType(string label, double value)
        {
            this.label = label;

            this.value = value;
        }

        public override string ToString()
        {
            return " " + label + ": R" + value + " ";
        }
    }
}
