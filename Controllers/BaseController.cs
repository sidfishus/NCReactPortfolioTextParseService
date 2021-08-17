using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NCReactPortfolioTextParseService.Controllers
{
    public class BaseController : ControllerBase
    {
        public ActionResult<T> ControllerFunction<T>(Func<ActionResult<T>> func)
        {
            try
            {
                return func();
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }

        public async Task<ActionResult<T>> ControllerFunctionAsync<T>(Func<Task<ActionResult<T>>> func)
        {
            try
            {
                return await func();
            }
            catch (Exception exception)
            {
                var msg = exception.ToString();
                return StatusCode(500, msg);
            }
        }
    }
}
