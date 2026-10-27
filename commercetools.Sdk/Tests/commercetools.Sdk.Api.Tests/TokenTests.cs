using System;
using commercetools.Base.Client.Domain;
using Xunit;

namespace commercetools.Sdk.Api.Tests
{
    public class TokenTests
    {
        private const long TwoDays = 172800;

        [Fact]
        public void ExpirationDateIsUtcElapsedTimeAcrossDstFallBack()
        {
            var transitionUtc = FindFallBackTransitionUtc(TimeZoneInfo.Local) ?? new DateTime(2026, 10, 25, 1, 0, 0, DateTimeKind.Utc);
            var creationUtc = transitionUtc.AddDays(-1);

            var token = new Token
            {
                CreationDate = TimeZoneInfo.ConvertTimeFromUtc(creationUtc, TimeZoneInfo.Local),
                ExpiresIn = TwoDays
            };

            Assert.Equal(DateTimeKind.Utc, token.ExpirationDate.Kind);
            Assert.Equal(creationUtc.AddSeconds(TwoDays - 300), token.ExpirationDate);
        }

        [Fact]
        public void UnspecifiedCreationDateIsTreatedAsUtc()
        {
            var creationUtc = new DateTime(2026, 10, 27, 8, 0, 0, DateTimeKind.Utc);

            var token = new Token
            {
                CreationDate = DateTime.SpecifyKind(creationUtc, DateTimeKind.Unspecified),
                ExpiresIn = TwoDays
            };

            Assert.Equal(DateTimeKind.Utc, token.ExpirationDate.Kind);
            Assert.Equal(creationUtc.AddSeconds(TwoDays - 300), token.ExpirationDate);
        }

        [Fact]
        public void TokenPastExpiryIsExpired()
        {
            var token = new Token { CreationDate = DateTime.UtcNow.AddSeconds(-TwoDays), ExpiresIn = TwoDays - 600 + 300 };

            Assert.True(token.Expired);
        }

        [Fact]
        public void TokenBeforeExpiryIsNotExpired()
        {
            var token = new Token { CreationDate = DateTime.UtcNow.AddSeconds(-TwoDays), ExpiresIn = TwoDays + 600 + 300 };

            Assert.False(token.Expired);
        }

        [Fact]
        public void NewTokenUsesUtc()
        {
            var token = new Token { ExpiresIn = TwoDays };

            Assert.Equal(DateTimeKind.Utc, token.CreationDate.Kind);
            Assert.False(token.Expired);
        }

        private static DateTime? FindFallBackTransitionUtc(TimeZoneInfo zone)
        {
            var t = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var end = t.AddYears(1);
            for (; t < end; t = t.AddHours(1))
            {
                if (zone.GetUtcOffset(t.AddHours(1)) < zone.GetUtcOffset(t))
                {
                    return t.AddHours(1);
                }
            }
            return null;
        }
    }
}
