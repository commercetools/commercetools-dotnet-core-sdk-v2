using System;
namespace commercetools.Api.Client.Domain
{
    public class Token
    {
        public Token()
        {
            this.CreationDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
        }

        public string AccessToken { get; set; }

        public string TokenType { get; set; }

        private long expiresIn;

        public long ExpiresIn
        {
            get => expiresIn;
            set
            {
                ExpirationDate = CreationDate.AddSeconds(value - 300);
                expiresIn = value;
            }
        }

        public string Scope { get; set; }

        public string RefreshToken { get; set; }

        public DateTime CreationDate { get; }
        public DateTime ExpirationDate { get; private set; }

        public bool Expired => ExpirationDate < DateTime.Now;
    }
}
