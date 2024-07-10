using System;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerDraftQueryBuilderDsl
    {
        public CustomerDraftQueryBuilderDsl()
        {
        }

        public static CustomerDraftQueryBuilderDsl Of()
        {
            return new CustomerDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> CustomerNumber()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerNumber")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> Password()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("password")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> MiddleName()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("middleName")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> AnonymousCartId()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousCartId")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerDraftQueryBuilderDsl> AnonymousCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("anonymousCart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl.Of())),
                CustomerDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, Date> DateOfBirth()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dateOfBirth")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> CompanyName()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("companyName")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> VatId()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("vatId")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerDraftQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CustomerDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerDraftQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<CustomerDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, long> DefaultShippingAddress()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddress")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CustomerDraftQueryBuilderDsl, string> ShippingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddresses")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, long> DefaultBillingAddress()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddress")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CustomerDraftQueryBuilderDsl, string> BillingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddresses")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, bool> IsEmailVerified()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isEmailVerified")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerDraftQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                CustomerDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CustomerDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerDraftQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CustomerDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerDraftQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CustomerDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string> AuthenticationMode()
        {
            return new ComparisonPredicateBuilder<CustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authenticationMode")),
            p => new CombinationQueryPredicate<CustomerDraftQueryBuilderDsl>(p, CustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
