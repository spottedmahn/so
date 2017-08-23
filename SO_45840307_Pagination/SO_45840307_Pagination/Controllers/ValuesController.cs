using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SO_45840307_Pagination.Models;
using SO_45840307_Pagination.ViewModels;

namespace SO_45840307_Pagination.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ApiResponseViewModel<Model> Get()
        {
            var data = GetData();
            var apiResp = new ApiResponse<Model>("200", data, "success");
            var res = Mapper.Map<ApiResponseViewModel<Model>>(apiResp);
            return res;
        }

        private IPagedList<Model> GetData()
        {
            var res = new PagedList<Model>();
            res.TotalPages = 50;
            res.TotalCount = 908945;
            res.Add(new Model { MyProperty = "Hello World" });
            return res;
        }
    }
}
