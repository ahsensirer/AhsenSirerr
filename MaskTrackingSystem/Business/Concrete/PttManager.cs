using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // bir iş sınıfı ya da veri grubu başka bir iş sınıfını kullanırken
    // new'liyorsa ileriye dönük değişiklik olduğunda uygulama direnç gösterir.
    //PersonManager personManager = new PersonManager(); dersek bağımlı oluruz o yüzden orayı siliyoruz

    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        //PersonManager personManager = new PersonManager();
        //ben ptt manager olarak başka bir sınıfa ihtiyaç duyduğum
        //sınıfı newlemek yerine onun interfaceini yazıyorum

        public PttManager(IApplicantService applicantService) //Constructor, new yapıldığında çalışır
        {
            _applicantService = applicantService;
            //classlarda fieldlerin alt çizgiyle başlamasının nedeni budur
            //constructordan set etmek için

        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi ");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ ");
            }


        }
    }
}
