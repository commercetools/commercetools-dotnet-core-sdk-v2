using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl
    {
        public BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(p, BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>(p, BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
