using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Funcionary
    {
        public String name;
        public double salaryGross;
        public double tax;

        public double salaryLiquid()
        {
            return this.salaryGross - this.tax;
        }
        
        public void increaseSalary(double increase)
        {
            this.salaryGross += (this.salaryGross * increase);
        }

    }
}
