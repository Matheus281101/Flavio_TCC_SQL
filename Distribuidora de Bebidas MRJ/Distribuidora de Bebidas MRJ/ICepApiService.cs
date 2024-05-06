using Refit;
using System.Net;
using System.Threading.Tasks;

namespace Distribuidora_de_Bebidas_MRJ
{
    internal interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<WebResponse> GetAddressAsync(string cep);
    }
}