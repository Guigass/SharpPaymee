using Paymee.API.Models;
using Paymee.API.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paymee.API
{
    public class Paymee : IDisposable
    {
        private RestService _restClient;
        public Paymee(string apiKey, string apiToken, bool production = true)
        {
            string url = "https://apisandbox.paymee.com.br";

            if (production)
               url = "https://api.paymee.com.br/";

            _restClient = new RestService(apiKey, apiToken, url);
        }

        public async Task<ApiResponse<CheckOutResponse>> GenerateCheckout(CheckOutRequest checkOutRequest)
        {
            var response = await _restClient.Post<CheckOutResponse>("checkout/transparent", checkOutRequest);

            return response;
        }

        public void Dispose()
        {
            _restClient.Dispose();
        }
    }
}
