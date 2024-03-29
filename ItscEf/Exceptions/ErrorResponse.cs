﻿namespace CMU.Budget.API.Exceptions
{
    public class ErrorResponse
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public ErrorResponse()
        {

        }
        public ErrorResponse(string message, string stackTrace)
        {
            Message = message;
            StackTrace = stackTrace;
        }
        public ErrorResponse(string message)
        {
            Message = message;
        }
    }
}
