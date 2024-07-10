using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ReplicaCartDraftQueryBuilderDsl
    {
        public ReplicaCartDraftQueryBuilderDsl()
        {
        }

        public static ReplicaCartDraftQueryBuilderDsl Of()
        {
            return new ReplicaCartDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReplicaCartDraftQueryBuilderDsl, string> Reference()
        {
            return new ComparisonPredicateBuilder<ReplicaCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reference")),
            p => new CombinationQueryPredicate<ReplicaCartDraftQueryBuilderDsl>(p, ReplicaCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReplicaCartDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ReplicaCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ReplicaCartDraftQueryBuilderDsl>(p, ReplicaCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
