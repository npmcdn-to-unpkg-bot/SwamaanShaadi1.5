using SwamaanShaadi.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwamaanShaadi.WebApi.Controllers
{
    public class LookupDataController : ApiController
    {
        private MemberRepository memberRepository = new MemberRepository();
        // GET: api/AllDropDownData
        //public IHttpActionResult Get()
        //{
        //    try
        //    {
        //        AllDropDownData allDDData = memberRepository.GetAllDropDownData();
        //        return Ok(allDDData);
        //    }
        //    catch (Exception ex)
        //    {
        //        return InternalServerError(new Exception("Error getting AllDropDownData. " + ex.Message));
        //    }
        //}
    }
}
