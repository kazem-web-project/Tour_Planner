

namespace Server
{
    public interface IHttpEndpoint
    {
        bool HandleRequest(HttpRequest rq, HttpResponse rs);
    }
}
