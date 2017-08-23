using SO_45840307_Pagination.Controllers;

namespace SO_45840307_Pagination.ViewModels
{
    public class ApiResponseViewModel<T>
    {
        public string StatusCode { get; set; }
        public ResultViewModel Result { get; set; }
        public string Success { get; set; }
    }
}