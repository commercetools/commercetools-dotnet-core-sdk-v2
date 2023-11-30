using System;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace commercetools.Api.NewRelicExample.Extensions
{
    public class InSessionStoreManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InSessionStoreManager(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }

        public void SetInSession(string key, string value)
        {
            var session = _httpContextAccessor?.HttpContext?.Session;
            session?.SetString(key, value);
        }
        public string GetFromSession(string key)
        {
            var session = _httpContextAccessor?.HttpContext?.Session;
            return session?.GetString(key);
        }

        public bool IsKeyExists(string key)
        {
            return _httpContextAccessor?.HttpContext?.Session.Keys.Contains(key) ?? false;
        }
        public void ClearSession(string key)
        {
            var session = _httpContextAccessor?.HttpContext?.Session;
            session?.Remove(key);
        }
    }
}