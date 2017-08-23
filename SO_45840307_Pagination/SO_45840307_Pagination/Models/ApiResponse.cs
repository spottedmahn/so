namespace SO_45840307_Pagination.Models
{
    public class ApiResponse<T>
    {
        public string StatusCode { get; set; }
        public IPagedList<T> Data { get; set; }
        public string Success { get; set; }

        public ApiResponse(string statusCode, IPagedList<T> data, string success)
        {
            StatusCode = statusCode;
            Data = data;
            Success = success;
        }
    }
}