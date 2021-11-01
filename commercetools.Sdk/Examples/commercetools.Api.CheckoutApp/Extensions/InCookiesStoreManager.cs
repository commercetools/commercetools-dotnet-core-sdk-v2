using System;
using Microsoft.AspNetCore.Http;

namespace commercetools.Api.CheckoutApp.Extensions
{
    public class InCookiesStoreManager
    {
        private const int ExpireInDays = 2;
        public const string TokenKey = "CTP_TokenKey";
        public const string UserNameKey = "CTP_Username";
        public const string PasswordKey = "CTP_Password";
        public const string AnonymousKey = "CTP_AnonymousId";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InCookiesStoreManager(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }
        
        public void SetInCookie(string key,string value)
        {
            var request = _httpContextAccessor?.HttpContext?.Request;
            var response = _httpContextAccessor?.HttpContext?.Response;
            if (request != null && !request.Cookies.ContainsKey(key))
            {
                response?.Cookies.Append(key, value,
                    new CookieOptions()
                    {
                        Path = "/",
                        Secure = true,
                        HttpOnly = true,
                        Expires = DateTimeOffset.Now.AddDays(ExpireInDays)
                    });
            }
        }
        public string GetFromCookie(string key)
        {
            var request = _httpContextAccessor?.HttpContext?.Request;
            return request?.Cookies[key];
        }
        public void ClearCookie(string key)
        {
            var response = _httpContextAccessor?.HttpContext?.Response;
            response?.Cookies.Delete(key);
        }
    }
}