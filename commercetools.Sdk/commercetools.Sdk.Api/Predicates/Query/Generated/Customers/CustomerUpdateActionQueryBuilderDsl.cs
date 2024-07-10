using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerUpdateActionQueryBuilderDsl
    {
        public CustomerUpdateActionQueryBuilderDsl()
        {
        }

        public static CustomerUpdateActionQueryBuilderDsl Of()
        {
            return new CustomerUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(p, CustomerUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsAddAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddAddressActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsAddBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddBillingAddressIdActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsAddShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddShippingAddressIdActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsAddStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerAddStoreActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsChangeAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerChangeAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerChangeAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerChangeAddressActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsChangeEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerChangeEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerChangeEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerChangeEmailActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsRemoveAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveAddressActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsRemoveBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsRemoveShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsRemoveStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerRemoveStoreActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAddressCustomFieldActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAddressCustomTypeActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetAuthenticationMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAuthenticationModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAuthenticationModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetAuthenticationModeActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetCompanyName(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCompanyNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCompanyNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCompanyNameActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomFieldActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomTypeActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomerGroupActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomerGroupActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomerGroupActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetCustomerNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomerNumberActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomerNumberActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetCustomerNumberActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetDateOfBirth(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDateOfBirthActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDateOfBirthActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDateOfBirthActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetDefaultBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDefaultBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDefaultBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetDefaultShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDefaultShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDefaultShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetExternalId(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetExternalIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetExternalIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetExternalIdActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetFirstName(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetFirstNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetFirstNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetFirstNameActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetKeyActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetLastName(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetLastNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetLastNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetLastNameActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetLocale(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetLocaleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetLocaleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetLocaleActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetMiddleName(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetMiddleNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetMiddleNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetMiddleNameActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetSalutation(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetSalutationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetSalutationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetSalutationActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetStores(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetStoresActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetStoresActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetStoresActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetTitleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetTitleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetTitleActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl> AsSetVatId(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetVatIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetVatIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerSetVatIdActionQueryBuilderDsl.Of()),
                CustomerUpdateActionQueryBuilderDsl.Of);
        }
    }
}
