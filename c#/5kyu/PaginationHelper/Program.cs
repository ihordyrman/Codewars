using System;
using System.Collections.Generic;

namespace PaginationHelper
{
    /*
     * https://www.codewars.com/kata/515bb423de843ea99400000a/train/csharp
     * For this exercise you will be strengthening your page-fu mastery.
     * You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.
     *
     * The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page.
     * The types of values contained within the collection/array are not relevant.
     */
    internal static class Program
    {
        private static void Main()
        {
            var pg = new PagnationHelper<int>(new List<int> {1, 2, 3, 4, 5, 6}, 2);
            Console.WriteLine(pg.PageCount);
            Console.WriteLine(pg.PageItemCount(3));
            Console.WriteLine(pg.PageIndex(5));
        }
    }

    public class PagnationHelper<T>
    {
        public IList<T> Collection { get; }

        public int ItemsPerPage { get; }


        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            Collection = collection;
            ItemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount => Collection.Count;

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount => (int) Math.Ceiling((double) ItemCount / ItemsPerPage);

        /// <summary>
        /// Returns the number of items in the page at the given page index
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < PageCount && pageIndex >= 0)
                return pageIndex + 1 == PageCount
                    ? ItemCount % ItemsPerPage
                    : ItemsPerPage;

            return -1;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex) => itemIndex < ItemCount && itemIndex >= 0 ? itemIndex / ItemsPerPage : -1;
    }
}