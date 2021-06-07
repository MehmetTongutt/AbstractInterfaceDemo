using System;
using System.Collections.Generic;
using System.Text;

namespace Projectx1
{
    class WorkerManager : IWorkerService
    {
        ICheckPerson _checkPerson;

        public WorkerManager(ICheckPerson checkPerson)
        {
            _checkPerson = checkPerson;
        }

        public void GetSalary(Worker worker)
        {
            if (_checkPerson.CheckPerson(worker))
            {
                Console.WriteLine("Maaş Alındı ..!");
            }
            else
            {
                Console.WriteLine("Maaş Alımı Başarısız ..! Lütfen Bilgilerinizi Kontrol Ediniz...");
            }
        }

        public void SigorataYatir()
        {
            Console.WriteLine("Sigorta Yatırıldı ..!!");
        }
    }
}
