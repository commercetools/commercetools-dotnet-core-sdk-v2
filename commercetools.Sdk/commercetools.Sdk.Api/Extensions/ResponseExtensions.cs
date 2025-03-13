#nullable enable
using System;
using System.Linq;
using commercetools.Sdk.Api.Models;

namespace commercetools.Sdk.Api.Extensions;

public static class ResponseExtensions
{
    /**
     * Tries to access the first element of the result list.
     * Use case: query by slug which should contain zero or one element in the result list.
     */
    static T? Head<T>(this IResourcePagedQueryResponse<T> response)
    {
        return response.Results.FirstOrDefault();
    }

    /**
     * Calculates the page number of the result, the pages are indexed staring 0, which means that {@code getPageIndex()}
     * returns a value in [0,n) , given 'n' is the total number of pages
     */
    static long PageIndex<T>(this IResourcePagedQueryResponse<T> response)
    {
        if (response.Total == null || response.Limit == 0)
        {
            throw new ArgumentException("Can only be used if the limit & total are known and limit is non-zero.");
        }
        return (long)Math.Floor(response.Offset / Convert.ToDecimal(response.Limit));
    }

    /**
     * Calculates the total number of pages matching the request.
     */
    static long TotalPages<T>(this IResourcePagedQueryResponse<T> response)
    {
        if (response.Total == null || response.Limit == 0)
        {
            throw new ArgumentException("Can only be used if the limit & total are known and limit is non-zero.");
        }
        return (long)Math.Ceiling((response.Total ?? 0) / Convert.ToDecimal(response.Limit));
    }

    /**
     * Checks if this is the first page of a result.
     */
    static bool IsFirst<T>(this IResourcePagedQueryResponse<T> response)
    {
        return response.Offset == 0;
    }

    /**
     * Checks if it is the last possible page.
     */
    static bool IsLast<T>(this IResourcePagedQueryResponse<T> response)
    {
        if (response.Total == null)
        {
            throw new ArgumentException("Can only be used if the offset & total are known.");
        }
        //currently counting the total amount is performed in a second database call, so it is possible
        //that the left side can be greater than total
        return response.Offset + response.Count >= response.Total;
    }
}