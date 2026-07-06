using ApiService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Web.Configuration;
using ApiService.Filters;

namespace ApiService.Controllers
{
    public class PromotionController : ApiController
    {
        private readonly ApiServerController _apiServerService;

        public PromotionController() {
            _apiServerService = new ApiServerController();
        }

        // GET: Promotion
        [HttpPost]
        [Route("Promotion/IndexAuthen")]
        [ApiKeyAuthorize]
        public IHttpActionResult IndexAuthen(string keyword) {
            if (string.IsNullOrWhiteSpace(keyword)) {
                return Content(HttpStatusCode.BadRequest, new {
                    Success = false,
                    Message = "Missing required parameter: keyword."
                });
            }

            return Ok(new {
                Success = true,
                Message = "FN IndexAuthen Success",
                Keyword = keyword
            });
        }

        [HttpPost]
        [Route("Promotion/IndexUnAuthen")]
        public string IndexUnAuthen() {
            return "FN IndexUnAuthen Success";
        }
    }
}