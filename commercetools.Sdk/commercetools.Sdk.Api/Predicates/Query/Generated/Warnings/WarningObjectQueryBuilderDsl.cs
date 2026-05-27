using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Warnings
{

    public partial class WarningObjectQueryBuilderDsl
    {
        public WarningObjectQueryBuilderDsl()
        {
        }

        public static WarningObjectQueryBuilderDsl Of()
        {
            return new WarningObjectQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<WarningObjectQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<WarningObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<WarningObjectQueryBuilderDsl>(p, WarningObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<WarningObjectQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<WarningObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<WarningObjectQueryBuilderDsl>(p, WarningObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<WarningObjectQueryBuilderDsl> AsCannotChangeReservationExpiry(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.CannotChangeReservationExpiryWarningQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.CannotChangeReservationExpiryWarningQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<WarningObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.CannotChangeReservationExpiryWarningQueryBuilderDsl.Of()),
                WarningObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<WarningObjectQueryBuilderDsl> AsCannotCreateReservation(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.CannotCreateReservationWarningQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.CannotCreateReservationWarningQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<WarningObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.CannotCreateReservationWarningQueryBuilderDsl.Of()),
                WarningObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<WarningObjectQueryBuilderDsl> AsCannotUpdateReservation(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.CannotUpdateReservationWarningQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.CannotUpdateReservationWarningQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<WarningObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.CannotUpdateReservationWarningQueryBuilderDsl.Of()),
                WarningObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<WarningObjectQueryBuilderDsl> AsImageProcessingOngoing(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.ImageProcessingOngoingWarningQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.ImageProcessingOngoingWarningQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<WarningObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.ImageProcessingOngoingWarningQueryBuilderDsl.Of()),
                WarningObjectQueryBuilderDsl.Of);
        }
    }
}
