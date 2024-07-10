using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerDraftQueryBuilderDsl
    {
        public MyCustomerDraftQueryBuilderDsl()
        {
        }

        public static MyCustomerDraftQueryBuilderDsl Of()
        {
            return new MyCustomerDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> Password()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("password")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> MiddleName()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("middleName")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, Date> DateOfBirth()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dateOfBirth")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> CompanyName()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("companyName")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> VatId()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("vatId")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyCustomerDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyCustomerDraftQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<MyCustomerDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, long> DefaultShippingAddress()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddress")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, long> DefaultBillingAddress()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddress")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                MyCustomerDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<MyCustomerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                MyCustomerDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyCustomerDraftQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<MyCustomerDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<MyCustomerDraftQueryBuilderDsl>(p, MyCustomerDraftQueryBuilderDsl.Of));
        }

    }
}
