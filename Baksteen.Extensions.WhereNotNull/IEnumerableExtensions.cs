using System.Collections.Generic;
using System.Linq;

namespace Baksteen.Extensions.WhereNotNull;

public static class IEnumerableExtensions
{
    /// <summary>
    /// Skips all null elements from the given sequence. This is the overload that handles nullable reference types.
    /// </summary>
    /// <typeparam name="T">The type of the elements of source</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to filter</param>
    /// <returns>An <see cref="IEnumerable{T}"/> of non-null elements</returns>
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : class =>
        from item in source
        where item != null
        select item;

    /// <summary>
    /// Skips all null elements from the given sequence. This is the overload that handles nullable value types.
    /// </summary>
    /// <typeparam name="T">The type of the elements of source</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to filter</param>
    /// <returns>An <see cref="IEnumerable{T}"/> of non-null elements</returns>
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : struct =>
        from item in source
        where item.HasValue
        select item.Value;
}
