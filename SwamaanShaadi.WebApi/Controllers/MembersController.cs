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
    [Authorize()]
    public class MembersController : ApiController
    {
        private JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        private MemberRepository memberRepository = new MemberRepository();
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        // GET: api/Members/5
        public IHttpActionResult Get(int memberId)
        {
            string clientIPAddress = HttpContext.Current.Request.UserHostAddress;

            Member member = memberRepository
                            .AllIncluding(
                                m => m.AccountStatus,
                                m => m.Address,
                                m => m.Caste,
                                m => m.CompanyName,
                                m => m.DateOfBirth,
                                m => m.District,
                                m => m.Education,
                                m => m.EmailAlertActive,
                                m => m.EmploymentType,
                                m => m.FatherName,
                                m => m.FirstName,
                                m => m.Gender,
                                m => m.HomeState,
                                m => m.LastName,
                                m => m.MaritalStatus,
                                m => m.MemberPhotographs,
                                m => m.MiddleName,
                                m => m.MobileAlertActive,
                                m => m.MobileNumber,
                                m => m.PartnerCastes,
                                m => m.PartnerDistricts,
                                m => m.PartnerEducations,
                                m => m.PartnerMaritalStatuses,
                                m => m.PartnerMaxAge,
                                m => m.PartnerMinAge,
                                m => m.ProfileFor,
                                m => m.RegistrationDate,
                                m => m.Religion,
                                m => m.State,
                                m => m.WorkLocationAddress
                            ).Where(m => m.MemberId == memberId).SingleOrDefault();

            if (member == null)
            {
                Log.Error("No member found for GET Request recieved for member id: " + memberId);
                return NotFound();
            }
            string memberValues = jsSerializer.Serialize(member);
            return Ok(member);
        }


        //Update
        // PUT: api/Members/5
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
                memberRepository.InsertOrUpdate(member);
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
