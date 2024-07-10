using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class UpdateActionQueryBuilderDsl
    {
        public UpdateActionQueryBuilderDsl()
        {
        }

        public static UpdateActionQueryBuilderDsl Of()
        {
            return new UpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<UpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<UpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<UpdateActionQueryBuilderDsl>(p, UpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
