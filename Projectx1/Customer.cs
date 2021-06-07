using System;
using System.Collections.Generic;
using System.Text;

namespace Projectx1
{
    class Customer: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
