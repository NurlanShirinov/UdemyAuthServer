using System.Text.Json.Serialization;

namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class
    {
        public T Data { get; set; }
        public int StatusCode { get; private set; }
        public ErrorDto Error { get;  private set; }

        [JsonIgnore]  //json formatina serileze olunduqda bu property serilize olmmuyacaq
        public bool IsSuccessful { get; private set; }



        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful= true };
        }
        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
        }
        public static Response<T> Fail(ErrorDto errorDto, int statusCode)
        {
            return new Response<T> { StatusCode = statusCode, Error = errorDto, IsSuccessful = false };
        }
        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);
            return new Response<T> { Error = errorDto, StatusCode = statusCode, IsSuccessful = false };
        }

    }
}