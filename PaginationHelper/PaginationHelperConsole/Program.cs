public class PaginationHelper<T>(IList<T> collection, int itemsPerPage)
{
    private readonly IList<T> _collection = collection;
    private readonly int _itemsPerPage = itemsPerPage;

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount => _collection.Count;

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount => (int)Math.Ceiling((double)_collection.Count / _itemsPerPage);

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        if (pageIndex < 0 || pageIndex >= PageCount)
            return -1;

        return pageIndex == PageCount - 1
            ? _collection.Count % _itemsPerPage == 0 ? _itemsPerPage : _collection.Count % _itemsPerPage
            : _itemsPerPage;
    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        if (itemIndex < 0 || itemIndex >= _collection.Count)
            return -1;

        return itemIndex / _itemsPerPage;
    }
}

class Program
{
    static void Main()
    {
        var helper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);

        Console.WriteLine($"Page Count: {helper.PageCount}"); // should == 2
        Console.WriteLine($"Item Count: {helper.ItemCount}"); // should == 6

        Console.WriteLine($"PageItemCount 0: {helper.PageItemCount(0)}"); // should == 4
        Console.WriteLine($"PageItemCount 1: {helper.PageItemCount(1)}"); // last page - should == 2
        Console.WriteLine($"PageItemCount 2: {helper.PageItemCount(2)}"); // should == -1 ); // last page - ssince the page is invalid

        // pageIndex takes an item index and returns the page that it belongs on
        Console.WriteLine($"PageIndex 5: {helper.PageIndex(5)}"); // should == 1 (zero based index)
        Console.WriteLine($"PageIndex 2: {helper.PageIndex(2)}"); // should == 0
        Console.WriteLine($"PageIndex 20: {helper.PageIndex(20)}"); // should == -1
        Console.WriteLine($"PageIndex -10: {helper.PageIndex(-10)}"); // should == -1
    }
}
