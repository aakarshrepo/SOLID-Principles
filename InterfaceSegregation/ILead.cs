using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation
{
    //public interface ILead
    //{
    //    void createTask();
    //    void assginTask();
    //    void workOnTask();
    //}

    public interface ICreate
    {
        void createTask();
    }

    public interface IAssign
    {
        void assginTask();
    }

    public interface IWork
    {
        void workOnTask();
    }
}
