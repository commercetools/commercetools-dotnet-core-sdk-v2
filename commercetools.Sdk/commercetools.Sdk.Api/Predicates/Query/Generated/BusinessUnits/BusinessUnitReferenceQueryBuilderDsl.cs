using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitReferenceQueryBuilderDsl
    {
        public BusinessUnitReferenceQueryBuilderDsl()
        {
        }

        public static BusinessUnitReferenceQueryBuilderDsl Of()
        {
            return new BusinessUnitReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<BusinessUnitReferenceQueryBuilderDsl>(p, BusinessUnitReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitReferenceQueryBuilderDsl>(p, BusinessUnitReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl.Of())),
                BusinessUnitReferenceQueryBuilderDsl.Of);
        }


    }
}
