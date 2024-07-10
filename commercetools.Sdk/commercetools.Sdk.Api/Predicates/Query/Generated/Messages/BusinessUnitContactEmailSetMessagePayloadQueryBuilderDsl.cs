using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
