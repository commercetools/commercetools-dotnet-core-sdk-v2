using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetContactEmailActionQueryBuilderDsl
    {
        public BusinessUnitSetContactEmailActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetContactEmailActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetContactEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetContactEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetContactEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetContactEmailActionQueryBuilderDsl>(p, BusinessUnitSetContactEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSetContactEmailActionQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetContactEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<BusinessUnitSetContactEmailActionQueryBuilderDsl>(p, BusinessUnitSetContactEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
