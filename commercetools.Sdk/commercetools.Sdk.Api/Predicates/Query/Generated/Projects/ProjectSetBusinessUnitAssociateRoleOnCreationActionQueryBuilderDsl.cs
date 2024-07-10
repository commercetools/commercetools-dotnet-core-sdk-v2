using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl
    {
        public ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl()
        {
        }

        public static ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl Of()
        {
            return new ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl>(p, ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl.Of())),
                ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl.Of);
        }


    }
}
