using GameDemo.Abstract;
using GameDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameDemo.Adapter
{   
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(player.NationalityId, player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
