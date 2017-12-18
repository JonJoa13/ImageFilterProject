using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    public class BusinessLogic
    {
        private readonly IInputOutput inputOutput;
        private readonly IGUI GUI;

        public BusinessLogic (IInputOutput inputOutput, IGUI GUI)
        {
            this.inputOutput = inputOutput;
            this.GUI = GUI;
        }


    }
}
