using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using commercetools.Base.Client.Error;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client
{
    public class ExceptionFactory
    {
        public static ApiHttpException Create(HttpRequestMessage request, HttpResponseMessage response, Func<HttpResponseMessage, Object> errorResponseBodyFactory)
        {
            return (int) response.StatusCode >= 500
                ? CreateServerException(request, response, errorResponseBodyFactory)
                : CreateClientException(request, response, errorResponseBodyFactory);
        }

        
        private static ApiHttpException CreateServerException(HttpRequestMessage request, HttpResponseMessage response, Func<HttpResponseMessage, Object> errorResponseBodyFactory)
        {
            var statusCode = (int) response.StatusCode;
            var body = response.ExtractResponseBody();
            var message = $"Server error response {request.RequestUri} {statusCode} {response.ReasonPhrase}";
            List<KeyValuePair<string, string>> t = new List<KeyValuePair<string, string>>();
            var headers = new ApiHttpHeaders(response.Headers.SelectMany(pair => pair.Value.Select(v => new KeyValuePair<string, string>(pair.Key, v))).ToList());
            var errorResponse = errorResponseBodyFactory(response);
            switch (statusCode)
            {
                case 500:
                    return new InternalServerErrorException(statusCode, body,
                        headers, errorResponse, message);
                case 502:
                    return new BadGatewayException(statusCode, body,
                        headers, errorResponse, message);
                case 503:
                    return new ServiceUnavailableException(statusCode, body,
                        headers, errorResponse, message);
                case 504:
                    return new GatewayTimeoutException(statusCode, body,
                        headers, errorResponse, message);
            }

            return new ApiServerException(statusCode, body,
                headers, errorResponse, message);
        }

        private static ApiHttpException CreateClientException(HttpRequestMessage request, HttpResponseMessage response, Func<HttpResponseMessage, Object> errorResponseBodyFactory)
        {
            var statusCode = (int) response.StatusCode;
            var body = response.ExtractResponseBody();
            var message = $"Client error response {request.RequestUri} {statusCode} {response.ReasonPhrase}";
            var headers = new ApiHttpHeaders(response.Headers.SelectMany(pair => pair.Value.Select(v => new KeyValuePair<string, string>(pair.Key, v))).ToList());
            var errorResponse = errorResponseBodyFactory(response);
            switch (statusCode)
            {
                case 400:
                    return new BadRequestException(statusCode, body,
                        headers, errorResponse, message);
                case 401:
                    return new UnauthorizedException(statusCode, body,
                        headers, errorResponse, message);
                case 403:
                    return new ForbiddenException(statusCode, body,
                        headers, errorResponse, message);
                case 404:
                    return new NotFoundException(statusCode, body,
                        headers, errorResponse, message);
                case 409:
                    return new ConcurrentModificationException(statusCode, body,
                        headers, errorResponse, message);
            }

            return new ApiClientException(statusCode, body,
                headers, errorResponse, message);
        }
    }
}