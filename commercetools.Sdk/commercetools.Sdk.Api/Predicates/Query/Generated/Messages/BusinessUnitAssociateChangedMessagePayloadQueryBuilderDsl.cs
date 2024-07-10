using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
