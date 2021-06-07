using System;
using System.Collections.Generic;
using System.Text;

namespace Projectx1
{
    class CustomerManager : ICustomerService
    {
        public void Add()
        {
            Console.WriteLine("Kayıt Eklendi ..!");
        }

        public void Delete()
        {
            Console.WriteLine("Kayıt Silindi ..!");
        }

        public void Update()
        {
            Console.WriteLine("Kayıt Güncellendi ..!");
        }
    }
}
