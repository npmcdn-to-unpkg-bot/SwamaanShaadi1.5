using log4net;
using SwamaanShaadi.DataLayer;
using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace SwamaanShaadi.WebApi.Controllers
{
    public class MemberController : ApiController
    {
        private JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        private MemberRepository memberRepository = new MemberRepository();
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        // GET: api/Member/5
        public IHttpActionResult Get(int memberId)
        {
            string clientIPAddress = HttpContext.Current.Request.UserHostAddress;

            Member member = memberRepository.GetMemberProfile(memberId);

            if (member == null)
            {
                Log.Error("No member found for GET Request recieved for member id: " + memberId);
                return NotFound();
            }
            string memberValues = jsSerializer.Serialize(member);
            return Ok(member);
        }


        //Update
        // PUT: api/Member/5
        public IHttpActionResult Put(int memberId, [FromBody]Member member)
        {
            string clientIPAddress = HttpContext.Current.Request.UserHostAddress;

            string memberValues = jsSerializer.Serialize(member);
            Log.Info(string.Format("Put request to update member {0} recieved from IP address {1}.", memberValues, clientIPAddress));

            if (member == null)
            {
                return BadRequest("Member cannot be null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                memberRepository.UpdateMemberProfile(memberId, member);
                return Ok();
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Error updating member for Put request to update {0}.", ex.Message));
                return BadRequest(ex.Message);
            }

        }

    }
}
