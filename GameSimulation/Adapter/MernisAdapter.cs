using GameSimulation.Abstract;
using GameSimulation.Entities;
using Mernis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Adapter
{
    public class MernisAdapter : IAuthenticationService
    {
        public bool Authenticate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.Id), gamer.Name.ToUpper(),
                gamer.Surname.ToUpper(), gamer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }

        //public bool Authenticate(Gamer gamer)
        //{
        //    KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);



        //    return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalityId), gamer.Name.ToUpper(), gamer.Surname.ToUpper(), gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        //}

        
            
        
    }
}
