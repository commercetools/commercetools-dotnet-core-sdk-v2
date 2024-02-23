using System;
namespace commercetools.Base.Client.Domain
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
                expiresIn = value;
                RefreshExpirationDate();
            }
        }

        public string Scope { get; set; }

        public string RefreshToken { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; private set; }

        public bool Expired => ExpirationDate < DateTime.Now;

        public void RefreshExpirationDate()
        {
            ExpirationDate = CreationDate.AddSeconds(ExpiresIn - 300);
        }
    }
}
