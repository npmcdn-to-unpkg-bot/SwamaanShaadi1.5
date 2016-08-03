using log4net;
using SwamaanShaadi.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace SwamaanShaadi.WebApi.Controllers
{
    [Authorize()]
    public class MemberMatchHistoryController : ApiController
    {
        private JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private MemberRepository memberRepository = new MemberRepository();

        // GET: api/MemberMatchHistory/5
        public IHttpActionResult Get(string userName)
        {
            try
            {
                var identityName = RequestContext.Principal.Identity.Name;
                Log.Info("GET Request recieved for MemberMatchHistory. identityName " + identityName);

                //List<MemberMatchHistory> matches = memberRepository.GetMemberMatchHistory(userName);
                //return Ok(matches.AsQueryable());
                return Ok();
            }
            catch (Exception ex)
            {
                var errorMsg = string.Format("Error getting MemberMatchHistory for userName {0}.{1}", userName, ex.Message);
                return InternalServerError(new Exception(errorMsg));
            }
        }
    }
}
