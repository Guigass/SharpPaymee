using Paymee.API.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Paymee.API.Helpers
{
    public class LoggingHandler : DelegatingHandler
    {
        private bool _logger { get; set; }
        public LoggingHandler(HttpMessageHandler innerHandler, bool log = false) : base(innerHandler)
        {
            _logger = log;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var sbRequest = new StringBuilder();

            sbRequest.AppendLine("Request:");
            sbRequest.AppendLine(request.ToString());

            if (request.Content != null)
                sbRequest.AppendLine(await request.Content.ReadAsStringAsync());

            if (_logger)
                LogService.DebugWrite(sbRequest.ToString());

            var sbResponse = new StringBuilder();

            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

            sbResponse.AppendLine("Response:");
            sbResponse.AppendLine(response.ToString());

            if (response.Content != null)
                sbResponse.AppendLine(await response.Content.ReadAsStringAsync());

            if (_logger)
                LogService.DebugWrite(sbResponse.ToString());

            return response;
        }
    }
}
