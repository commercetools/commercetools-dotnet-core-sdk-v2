using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCompanyDraftQueryBuilderDsl
    {
        public MyCompanyDraftQueryBuilderDsl()
        {
        }

        public static MyCompanyDraftQueryBuilderDsl Of()
        {
            return new MyCompanyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                MyCompanyDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyCompanyDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyCompanyDraftQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<MyCompanyDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string> ShippingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddresses")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, long> DefaultShippingAddress()
        {
            return new ComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddress")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string> BillingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<MyCompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddresses")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, long> DefaultBillingAddress()
        {
            return new ComparisonPredicateBuilder<MyCompanyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddress")),
            p => new CombinationQueryPredicate<MyCompanyDraftQueryBuilderDsl>(p, MyCompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
