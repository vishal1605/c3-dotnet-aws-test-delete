namespace first_web_api_dot_net.Models
{
    public class ServerResponseModal
    {
        public bool IsSuccess { get; set; } = false;
        public dynamic Data { get; set; }

        public string Message { get; set; } = "";

        public bool IsError { get; set; } = false;
    }
}
