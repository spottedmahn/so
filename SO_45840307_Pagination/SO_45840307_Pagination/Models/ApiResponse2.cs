namespace SO_45840307_Pagination.Models
{
    public class ApiResponse2
    {
        public string StatusCode { get; set; }
        public object Data { get; set; }
        public string Success { get; set; }
        public string Error { get; set; }

        public ApiResponse2(string statusCode, object data, string success)
        {
            StatusCode = statusCode;
            Data = data;
            Success = success;
        }
    }
}