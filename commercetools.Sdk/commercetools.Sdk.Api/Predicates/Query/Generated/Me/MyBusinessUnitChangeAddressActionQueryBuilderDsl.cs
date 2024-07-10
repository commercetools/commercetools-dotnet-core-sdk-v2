using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitChangeAddressActionQueryBuilderDsl
    {
        public MyBusinessUnitChangeAddressActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitChangeAddressActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitChangeAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitChangeAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitChangeAddressActionQueryBuilderDsl>(p, MyBusinessUnitChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitChangeAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitChangeAddressActionQueryBuilderDsl>(p, MyBusinessUnitChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitChangeAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitChangeAddressActionQueryBuilderDsl>(p, MyBusinessUnitChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitChangeAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitChangeAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyBusinessUnitChangeAddressActionQueryBuilderDsl.Of);
        }


    }
}
