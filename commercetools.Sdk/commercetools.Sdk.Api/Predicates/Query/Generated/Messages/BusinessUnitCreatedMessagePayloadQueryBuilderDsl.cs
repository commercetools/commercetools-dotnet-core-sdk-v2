using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCreatedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCreatedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCreatedMessagePayloadQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl.Of())),
                BusinessUnitCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
