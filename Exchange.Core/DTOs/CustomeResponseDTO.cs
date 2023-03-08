using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdvancedSearch.Core.DTOs
{
    public class CustomeResponseDTO<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<String> Errors { get; set; }

        public static CustomeResponseDTO<T> Success(int statusCode, T data)
        {
            return new CustomeResponseDTO<T> { Data = data, StatusCode = statusCode };
        }
        public static CustomeResponseDTO<T> Success(int statusCode)
        {
            return new CustomeResponseDTO<T> { StatusCode = statusCode };
        }
        public static CustomeResponseDTO<T> Fail(int statusCode ,List<string>errors)
        {
            return new CustomeResponseDTO<T> { StatusCode = statusCode,Errors=errors };
        }
        public static CustomeResponseDTO<T> Fail(int statusCode, string error)
        {
            return new CustomeResponseDTO<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}