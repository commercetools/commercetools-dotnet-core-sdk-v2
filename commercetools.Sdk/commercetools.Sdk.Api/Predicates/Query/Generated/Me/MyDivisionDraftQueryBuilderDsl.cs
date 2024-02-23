using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyDivisionDraftQueryBuilderDsl
    {
        public MyDivisionDraftQueryBuilderDsl()
        {
        }

        public static MyDivisionDraftQueryBuilderDsl Of()
        {
            return new MyDivisionDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                MyDivisionDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyDivisionDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyDivisionDraftQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<MyDivisionDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string> ShippingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddresses")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, long> DefaultShippingAddress()
        {
            return new ComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddress")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string> BillingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<MyDivisionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddresses")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, long> DefaultBillingAddress()
        {
            return new ComparisonPredicateBuilder<MyDivisionDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddress")),
            p => new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(p, MyDivisionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl> ParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyDivisionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parentUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                MyDivisionDraftQueryBuilderDsl.Of);
        }


    }
}
