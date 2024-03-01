using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //bir class yazmaya başladığımızda onun interface'ini oluşturmuş olmamız lazım
    //interface içinde sadece metod imzası barındırılır.
    //
    public interface IApplicantService
    {

        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
       
    }

    //interface -->belli metod imzalarını barındırırlar
    //birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar
    //yani yabancı uyrukların/tc vatandaşlarının kontrolünü yapma

}

