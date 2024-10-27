using System;

namespace Marktguru.WebAPI.Middleware
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = "", string type = "", string? details = null)
        {
            StatusCode = statusCode;
            Message = message;
            Type = type;
            Details = details;
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Type { get; set; }

        public string? Details { get; set; }
    }
}