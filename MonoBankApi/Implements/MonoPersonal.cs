﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Implements.Requests;
using MonoBankApi.Models.Responses;
using MonoBankApi.Services;

namespace MonoBankApi.Implements
{
    public class MonoPersonal : MonoHttp, IMonoPersonal
    {
        public MonoPersonal(string token) : base(token) { }

        public async Task<WebhookStatus> SetWebHookAsync(string webhookUrl) =>
            await HttpPostAsync<WebhookStatus>(new WebhookRequest(webhookUrl));

        public async Task<ClientInfoResponse> ReturnClientInfoAsync() =>
            await HttpGetAsync<ClientInfoResponse>(new ClientInfoRequest());

        public async Task<ICollection<StatementResponse>> ReturnStatementAsync(DateTime from, DateTime to, string acc = "0") =>
            await HttpGetAsync<ICollection<StatementResponse>>(new StatementRequest(from, to, acc));
    }
}
