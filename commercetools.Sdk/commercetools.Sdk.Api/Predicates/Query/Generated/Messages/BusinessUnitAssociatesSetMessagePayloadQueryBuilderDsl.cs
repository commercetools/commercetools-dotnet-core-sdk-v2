using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl> Associates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl> Associates()
        {
            return new CollectionPredicateBuilder<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associates")),
                    p => new CombinationQueryPredicate<BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
