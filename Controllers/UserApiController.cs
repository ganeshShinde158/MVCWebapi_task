using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCWebapi_task.Models;
using MVCWebapi_task.Services;

namespace MVCWebapi_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        IUserServices UserServices;
        public UserApiController(IUserServices userServices)
        {
            UserServices = userServices;
        }
        [HttpGet]
        public List<User> GetAllUsers()
        {

            return UserServices.GetUsers();

        }

    }
}
