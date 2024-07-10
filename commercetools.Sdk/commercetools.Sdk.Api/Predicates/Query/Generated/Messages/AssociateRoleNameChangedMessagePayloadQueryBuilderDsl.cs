using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRoleNameChangedMessagePayloadQueryBuilderDsl
    {
        public AssociateRoleNameChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRoleNameChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRoleNameChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleNameChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRoleNameChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRoleNameChangedMessagePayloadQueryBuilderDsl>(p, AssociateRoleNameChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleNameChangedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AssociateRoleNameChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AssociateRoleNameChangedMessagePayloadQueryBuilderDsl>(p, AssociateRoleNameChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
