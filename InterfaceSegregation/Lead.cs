using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation
{
    class Lead : ICreate, IAssign, IWork
    {
        public void assginTask()
        {
            //Code to assign a task.
        }

        public void createTask()
        {
            //Code to create a task.  
        }

        public void workOnTask()
        {
            //Code to work on a task
        }
    }
}
