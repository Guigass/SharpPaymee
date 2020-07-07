using Newtonsoft.Json;
using Paymee.API.Models;
using Paymee.API.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paymee.API
{
    public class Paymee : IDisposable
    {
        private RestService _restClient;

        private string _apiKey;
        private string _apiToken;
        public Paymee(string apiKey, string apiToken, bool production = true, bool logger = false)
        {
            string url = "https://apisandbox.paymee.com.br/v1.1";

            if (production)
               url = "https://api.paymee.com.br/v1.1";

            _restClient = new RestService(apiKey, apiToken, url, logger);

            _apiKey = apiKey;
            _apiToken = apiToken;
        }

        public async Task<ApiResponse<CheckOutResponse>> GenerateCheckout(CheckOutRequest checkOutRequest, bool transparent = false)
        {
            var action = "checkout";
            if (transparent)
                action = "checkout/transparent";

            var response = await _restClient.Post<CheckOutResponse>(action, checkOutRequest);

            return response;
        }

        public async Task<ApiResponse<PayoutBatchResponse>> GeneratePayoutBatch(PayoutBatchRequest payoutBatchRequest)
        {
            var response = await _restClient.Post<PayoutBatchResponse>("payout/create/batch", payoutBatchRequest);

            return response;
        }

        public async Task<ApiResponse<PayoutResponse>> GeneratePayout(Payment payoutBatchRequest)
        {
            var response = await _restClient.Post<PayoutResponse>("payout/create/batch", payoutBatchRequest);

            return response;
        }

        public async Task<ApiResponse<string>> DeletePayout(CancelPayoutRequest cancelPayoutRequest)
        {
            var response = await _restClient.Delete("payout", cancelPayoutRequest);

            return response;
        }

        public async Task<ApiResponse<TransactionResponse>> GetTransaction(Guid transactionUUID)
        {
            var response = await _restClient.Get<TransactionResponse>($"transactions/{transactionUUID}");

            return response;
        }

        public async Task<ApiResponse<BalanceResponse>> GetBalance()
        {
            var response = await _restClient.Get<BalanceResponse>($"balance");

            return response;
        }

        public async Task<ApiResponse<TransactionResponse>> GetTransactions(DateTime? initialDate = null, DateTime? finalDate = null, string currency = null, double? amount = null, string referenceCode = null,string situation = null,int? maxPageResults = null,int? page = null)
        {
            string query = "";

            if (initialDate != null)
                query += $"initialDate={initialDate.Value.ToString("yyyy-MM-dd")}";

            if (finalDate != null)
                query += $"finalDate={finalDate.Value.ToString("yyyy-MM-dd")}";

            if (currency != null)
                query += $"currency={currency}";

            if (amount != null)
                query += $"amount={amount.Value}";

            if (referenceCode != null)
                query += $"referenceCode={referenceCode}";

            if (situation != null)
                query += $"situation={situation}";

            if (maxPageResults != null)
                query += $"maxPageResults={maxPageResults.Value}";

            if (page != null)
                query += $"page={page.Value}";

            var response = await _restClient.Get<TransactionResponse>($"transactions", query);

            return response;
        }

        public async Task<ApiResponse<GenericResponse>> CancelTransaction(Guid saleUUID)
        {
            var response = await _restClient.Put<GenericResponse>($"transactions/{saleUUID}/void", null);

            return response;
        }

        public async Task<ApiResponse<SaleRefundResponse>> SaleRefund(Guid saleUUID, SaleRefundRequest saleRefundRequest)
        {
            var response = await _restClient.Put<SaleRefundResponse>($"transactions/{saleUUID}/refund", saleRefundRequest);

            return response;
        }

        public async Task<ApiResponse<RedeliverResponse>> RequestRedeliverWebHook(Guid transactionUUID)
        {
            var response = await _restClient.Get<RedeliverResponse>($"transactions/{transactionUUID}/webhook/redeliver");

            return response;
        }

        public async Task<ApiResponse<WebhooksResponse>> GetWebhook(Guid transactionUUID)
        {
            var response = await _restClient.Get<WebhooksResponse>($"transactions/{transactionUUID}/webhook");

            return response;
        }

        public PaymentNotification GetNotification(string authHeader, string bodyContent)
        {
            string encodedAuthHeader = authHeader.Substring("Basic ".Length).Trim();

            Encoding encoding = Encoding.GetEncoding("iso-8859-1");

            string apiFromRequest = encoding.GetString(Convert.FromBase64String(encodedAuthHeader));
            string apiFromClient = $"{_apiKey}:{_apiToken}";

            if (apiFromClient != apiFromRequest)
                throw new Exception("A Autenticação falhou");

            return JsonConvert.DeserializeObject<PaymentNotification>(bodyContent);
        }

        public void Dispose()
        {
            _restClient.Dispose();
        }
    }
}
