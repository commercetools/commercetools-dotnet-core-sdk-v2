using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class ReplicaMyCartDraftQueryBuilderDsl
    {
        public ReplicaMyCartDraftQueryBuilderDsl()
        {
        }

        public static ReplicaMyCartDraftQueryBuilderDsl Of()
        {
            return new ReplicaMyCartDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReplicaMyCartDraftQueryBuilderDsl, string> Reference()
        {
            return new ComparisonPredicateBuilder<ReplicaMyCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reference")),
            p => new CombinationQueryPredicate<ReplicaMyCartDraftQueryBuilderDsl>(p, ReplicaMyCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
