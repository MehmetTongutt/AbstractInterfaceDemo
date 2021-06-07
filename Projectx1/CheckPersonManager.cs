using System;
using System.Collections.Generic;
using System.Text;

namespace Projectx1
{
    class CheckPersonManager : ICheckPerson
    {
        public bool CheckPerson(Worker worker)
        {
            if (worker.Id==1 && worker.FirstName=="Mehmet")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
