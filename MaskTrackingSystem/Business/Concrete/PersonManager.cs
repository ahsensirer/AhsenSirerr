using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    //maske verilecek ortamı sunacak
    //Çıplak class kalmasın
    public class PersonManager : IApplicantService
    {
        //kim başvuracak? person, bu yüzden paranteze yazdık
        //parantez içine yazarak gruplandırmak--> encapsulation

        public void ApplyForMask(Person person)
        {


        }
        //şimdiye kadar kimler başvurmuş, list of person demek
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
