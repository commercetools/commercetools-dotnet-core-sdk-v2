using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ObjectNotFoundErrorQueryBuilderDsl
    {
        public ObjectNotFoundErrorQueryBuilderDsl()
        {
        }

        public static ObjectNotFoundErrorQueryBuilderDsl Of()
        {
            return new ObjectNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ObjectNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ObjectNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ObjectNotFoundErrorQueryBuilderDsl>(p, ObjectNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ObjectNotFoundErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ObjectNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ObjectNotFoundErrorQueryBuilderDsl>(p, ObjectNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
