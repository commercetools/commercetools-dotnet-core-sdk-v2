using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IPriceselectingTrait<T> where T : IPriceselectingTrait<T>
    {
        List<string> GetPriceCurrency();

        List<string> GetPriceCountry();

        List<string> GetPriceCustomerGroup();

        List<string> GetPriceCustomerGroupAssignments();

        List<string> GetPriceChannel();

        List<string> GetPriceRecurrencePolicy();

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
         * set priceCustomerGroupAssignments with the specificied value
         */
        T WithPriceCustomerGroupAssignments(string priceCustomerGroupAssignments);

        /**
         * set priceChannel with the specificied value
         */
        T WithPriceChannel(string priceChannel);

        /**
         * set priceRecurrencePolicy with the specificied value
         */
        T WithPriceRecurrencePolicy(string priceRecurrencePolicy);


        IPriceselectingTrait<T> AsPriceselectingTrait()
        {
            return this;
        }

        T AsPriceselectingTraitToBaseType()
        {
            return (T)this;
        }
    }
}
