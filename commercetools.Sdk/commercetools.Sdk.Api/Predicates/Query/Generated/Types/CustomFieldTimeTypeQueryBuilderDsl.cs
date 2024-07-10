using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldTimeTypeQueryBuilderDsl
    {
        public CustomFieldTimeTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldTimeTypeQueryBuilderDsl Of()
        {
            return new CustomFieldTimeTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldTimeTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldTimeTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldTimeTypeQueryBuilderDsl>(p, CustomFieldTimeTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
