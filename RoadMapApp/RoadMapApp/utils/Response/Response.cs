namespace RoadMapApp.utils.Response
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;

        public Response()
        {
        }
        
        public Response(T data)
        {
            Data = data;
        }

        public Response(string message)
        {
            Success = false;
            Message = message;
        }
    }
}