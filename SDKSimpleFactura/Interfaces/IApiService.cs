﻿using System.Net.Http;
using System.Threading.Tasks;
using SDKSimpleFactura.Models.Response;

namespace SDKSimpleFactura.Interfaces
{
    public interface IApiService
    {
        Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string url, TRequest request);
        Task<ApiResponse<byte[]>> PostForByteArrayAsync<TRequest>(string url, TRequest request);
        Task<ApiResponse<TResponse>> PostMultipartAsync<TResponse>(string url, MultipartFormDataContent content);
    }

}
