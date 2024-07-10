using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRoleDeletedMessagePayloadQueryBuilderDsl
    {
        public AssociateRoleDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRoleDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRoleDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRoleDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRoleDeletedMessagePayloadQueryBuilderDsl>(p, AssociateRoleDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
