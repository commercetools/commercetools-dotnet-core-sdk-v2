using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl> TopLevelUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("topLevelUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl> OldTopLevelUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldTopLevelUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
