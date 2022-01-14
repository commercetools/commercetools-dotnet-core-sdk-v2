using System;
using commercetools.Api.CheckoutApp.Services;
using Microsoft.AspNetCore.Http;

namespace commercetools.Api.CheckoutApp.Extensions
{
    public class InCookiesStoreManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InCookiesStoreManager(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }
        
        public void SetInCookie(string key,string value)
        {
            var response = _httpContextAccessor?.HttpContext?.Response;
            response?.Cookies.Append(key, value,
                new CookieOptions()
                {
                    Path = "/",
                    Secure = true,
                    HttpOnly = true,
                    Expires = DateTimeOffset.Now.AddDays(Settings.ExpireInDays)
                });
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