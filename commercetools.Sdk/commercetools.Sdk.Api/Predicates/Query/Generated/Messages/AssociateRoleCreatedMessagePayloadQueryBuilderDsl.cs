using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRoleCreatedMessagePayloadQueryBuilderDsl
    {
        public AssociateRoleCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRoleCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRoleCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRoleCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRoleCreatedMessagePayloadQueryBuilderDsl>(p, AssociateRoleCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleCreatedMessagePayloadQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl.Of())),
                AssociateRoleCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
