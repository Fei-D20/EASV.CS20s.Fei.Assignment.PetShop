namespace EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering
{
    /// <summary>
    /// this is the Filter class which used for control the record paging
    /// it include two property
    /// count is the record on one page
    /// page is how many page skiped
    /// 
    /// </summary>
    public class Filter
    {
        public int Count { get; set; }
        public int Page { get; set; }
        
    }
}