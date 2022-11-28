using System;
using System.Collections.Generic;
using System.Text;
using GameBackend.Abstract;
using Mernis;

namespace GameBackend.Adapters
{
    public class MernisManager : IUserValidationService
    {
        public bool RealPersonValidation(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var stateValidation= Convert.ToBoolean(client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName, user.LastName, user.BirthDate.Year));
            return stateValidation;
            //Methodun async olarak gelmesi yüzünden burada hata alıyorum...
        }
    }
}
