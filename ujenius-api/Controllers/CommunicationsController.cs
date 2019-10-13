using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using ujenius_api.Models;

namespace ujenius_api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CommunicationsController:Controller
    {

        [HttpPost]
        [Route("send_sms")]
        public ActionResult<SendSMSResponse> SendSMS([FromBody]SendSMSRequest request)
        {
            try
            {
                var destination = request.Number;
                var message = request.Message;

                var req = new RestRequest("https://api4.apidaze.io/f0b4155d/sms/send")
                {
                    RequestFormat = DataFormat.Json
                };

                req.AddParameter("api_secret", "2de71b8f1655ccfa35e9c53bcf1956ca");
                req.AddParameter("number", $"00{destination}");
                req.AddParameter("subject", "A Message From UJenius Service");
                req.AddParameter("body", message);

                var client = new RestClient();

                var response = client.Post(req);

                if (!response.IsSuccessful)
                {
                    throw new Exception("Request unsuccessful");
                }

                return new SendSMSResponse { Message = $"message sent to {destination}" };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
