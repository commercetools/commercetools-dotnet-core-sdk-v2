using System;
using System.Net.Http;
using commercetools.Base.Client.Error;

namespace commercetools.Base.Client
{
    public class ExceptionFactory
    {
        public static ApiHttpException Create(HttpRequestMessage request, HttpResponseMessage response)
        {
            return (int) response.StatusCode >= 500
                ? CreateServerException(request, response)
                : CreateClientException(request, response);
        }

        private static ApiHttpException CreateServerException(HttpRequestMessage request, HttpResponseMessage response)
        {
            var statusCode = (int) response.StatusCode;
            var body = response.ExtractResponseBody();
            var message = $"Server error response {request.RequestUri} {statusCode} {response.ReasonPhrase}";
            var headers = request.GetHeaders();

            switch (statusCode)
            {
                case 500:
                    return new InternalServerErrorException(statusCode, body,
                        headers, message);
                case 502:
                    return new BadGatewayException(statusCode, body,
                        headers, message);
                case 503:
                    return new ServiceUnavailableException(statusCode, body,
                        headers, message);
                case 504:
                    return new GatewayTimeoutException(statusCode, body,
                        headers, message);
            }

            return new ApiServerException(statusCode, body,
                headers, message);
        }

        private static ApiHttpException CreateClientException(HttpRequestMessage request, HttpResponseMessage response)
        {
            var statusCode = (int) response.StatusCode;
            var body = response.ExtractResponseBody();
            var message = $"Client error response {request.RequestUri} {statusCode} {response.ReasonPhrase}";
            var headers = request.GetHeaders();

            switch (statusCode)
            {
                case 400:
                    return new BadRequestException(statusCode, body,
                        headers, message);
                case 401:
                    return new UnauthorizedException(statusCode, body,
                        headers, message);
                case 403:
                    return new ForbiddenException(statusCode, body,
                        headers, message);
                case 404:
                    return new NotFoundException(statusCode, body,
                        headers, message);
                case 409:
                    return new ConcurrentModificationException(statusCode, body,
                        headers, message);
            }

            return new ApiClientException(statusCode, body,
                headers, message);
        }
    }
}