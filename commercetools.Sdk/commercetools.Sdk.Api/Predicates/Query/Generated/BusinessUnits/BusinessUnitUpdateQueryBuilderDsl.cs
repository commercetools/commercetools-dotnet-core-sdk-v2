using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitUpdateQueryBuilderDsl
    {
        public BusinessUnitUpdateQueryBuilderDsl()
        {
        }

        public static BusinessUnitUpdateQueryBuilderDsl Of()
        {
            return new BusinessUnitUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitUpdateQueryBuilderDsl>(p, BusinessUnitUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitUpdateActionQueryBuilderDsl.Of())),
                BusinessUnitUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<BusinessUnitUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<BusinessUnitUpdateQueryBuilderDsl>(p, BusinessUnitUpdateQueryBuilderDsl.Of));
        }

    }
}
