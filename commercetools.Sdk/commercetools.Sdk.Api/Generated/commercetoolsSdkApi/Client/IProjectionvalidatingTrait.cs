using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IProjectionvalidatingTrait<T> where T : IProjectionvalidatingTrait<T>
    {
        List<string> GetPriceCurrency();

        List<string> GetPriceCountry();

        List<string> GetPriceCustomerGroup();

        List<string> GetPriceChannel();

        List<string> GetLocaleProjection();

        List<string> GetFilterAttributes();

        /**
         * set priceCurrency with the specificied value
         */
        T WithPriceCurrency(string priceCurrency);

        /**
         * set priceCountry with the specificied value
         */
        T WithPriceCountry(string priceCountry);

        /**
         * set priceCustomerGroup with the specificied value
         */
        T WithPriceCustomerGroup(string priceCustomerGroup);

        /**
         * set priceChannel with the specificied value
         */
        T WithPriceChannel(string priceChannel);

        /**
         * set localeProjection with the specificied value
         */
        T WithLocaleProjection(string localeProjection);

        /**
         * set filterAttributes with the specificied value
         */
        T WithFilterAttributes(string filterAttributes);


        IProjectionvalidatingTrait<T> AsProjectionvalidatingTrait()
        {
            return this;
        }

        T AsProjectionvalidatingTraitToBaseType()
        {
            return (T)this;
        }
    }
}
