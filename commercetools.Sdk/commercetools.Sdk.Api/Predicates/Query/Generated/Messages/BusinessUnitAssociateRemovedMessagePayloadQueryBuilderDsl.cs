using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
