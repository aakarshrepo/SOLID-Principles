using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation
{
    class Manager : ICreate, IAssign
    {
        public void assginTask()
        {
            //Code to assign a task.
        }

        public void createTask()
        {
            //Code to create a task.  
        }
        
        //public void workOnTask()
        //{
        //    throw new Exception("Manager can't work on Task");
        //}
    }
}
