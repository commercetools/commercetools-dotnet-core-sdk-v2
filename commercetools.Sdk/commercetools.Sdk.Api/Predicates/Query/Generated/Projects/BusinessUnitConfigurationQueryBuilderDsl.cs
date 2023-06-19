using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class BusinessUnitConfigurationQueryBuilderDsl
    {
        public BusinessUnitConfigurationQueryBuilderDsl()
        {
        }

        public static BusinessUnitConfigurationQueryBuilderDsl Of()
        {
            return new BusinessUnitConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitConfigurationQueryBuilderDsl, string> MyBusinessUnitStatusOnCreation()
        {
            return new ComparisonPredicateBuilder<BusinessUnitConfigurationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("myBusinessUnitStatusOnCreation")),
            p => new CombinationQueryPredicate<BusinessUnitConfigurationQueryBuilderDsl>(p, BusinessUnitConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitConfigurationQueryBuilderDsl> MyBusinessUnitAssociateRoleOnCreation(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitConfigurationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("myBusinessUnitAssociateRoleOnCreation"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitConfigurationQueryBuilderDsl.Of);
        }


    }
}
