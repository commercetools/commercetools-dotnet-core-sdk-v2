using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitDraftQueryBuilderDsl
    {
        public MyBusinessUnitDraftQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitDraftQueryBuilderDsl Of()
        {
            return new MyBusinessUnitDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                MyBusinessUnitDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyBusinessUnitDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string> ShippingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddresses")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, long> DefaultShippingAddress()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddress")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string> BillingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddresses")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, long> DefaultBillingAddress()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddress")),
            p => new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(p, MyBusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl> AsCompany(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCompanyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCompanyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCompanyDraftQueryBuilderDsl.Of()),
                MyBusinessUnitDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl> AsDivision(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyDivisionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyDivisionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyDivisionDraftQueryBuilderDsl.Of()),
                MyBusinessUnitDraftQueryBuilderDsl.Of);
        }
    }
}
