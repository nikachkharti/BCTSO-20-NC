﻿namespace Todo.Web.Models
{
    public class ApiResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
        public int StatusCode { get; set; }
    }
}
