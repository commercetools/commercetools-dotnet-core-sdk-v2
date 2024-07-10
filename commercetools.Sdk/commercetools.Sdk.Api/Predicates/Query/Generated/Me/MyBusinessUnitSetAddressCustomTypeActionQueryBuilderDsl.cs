using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl
    {
        public MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(p, MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(p, MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
