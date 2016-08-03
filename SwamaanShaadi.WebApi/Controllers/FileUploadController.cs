using SwamaanShaadi.DataLayer;
using SwamaanShaadi.WebApi.FileUploadLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SwamaanShaadi.WebApi.Controllers
{
    [Authorize()]
    public class FileUploadController : ApiController
    {
        private MemberRepository memberRepository = new MemberRepository();

        //[MimeMultipart]
        //public async Task<FileUploadResult> Post(string userName)
        //{
        //    var uploadPath = HttpContext.Current.Server.MapPath("~/MemberPhotographs/" + userName);

        //    bool exists = System.IO.Directory.Exists(uploadPath);

        //    if (!exists)
        //        System.IO.Directory.CreateDirectory(uploadPath);

        //    var multipartFormDataStreamProvider = new UploadMultipartFormProvider(uploadPath);

        //    // Read the MIME multipart asynchronously 
        //    await Request.Content.ReadAsMultipartAsync(multipartFormDataStreamProvider);

        //    string _localFileName = multipartFormDataStreamProvider
        //        .FileData.Select(multiPartData => multiPartData.LocalFileName).FirstOrDefault();


        //    //Insert in Database
        //    memberRepository.AddMemberPhotograph(userName, _localFileName);

        //    // Create response
        //    return new FileUploadResult
        //    {
        //        FileName = Path.GetFileName(_localFileName),
        //    };
        //}

        ////Delete
        //// PUT: api/fileupload/12345
        //public IHttpActionResult Put(string userName, FileUploadResult fileUploadResult)
        //{
        //    string root = HttpContext.Current.Server.MapPath("~");
        //    string photographPath = root + fileUploadResult.FileName;
        //    try
        //    {
        //        File.Delete(photographPath);
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = ex;
        //    }

        //    memberRepository.DeleteMemberPhotograph(userName, photographPath);

        //    return Ok();
        //}
    }
}
