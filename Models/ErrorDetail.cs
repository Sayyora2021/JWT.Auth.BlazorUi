using System.ComponentModel;

namespace JWT.Auth.BlazorUi.Models
{   
    //Contains data from the Web API
    //See https://learn.microsoft.com/powerapps/developer/data-platform/webapi/compose-http-requests-handle-errors#parse-errors-from-the-response
     public class ErrorDetail
    {
        public string code { get; set; }
        public string message { get; set; }
    }
}
