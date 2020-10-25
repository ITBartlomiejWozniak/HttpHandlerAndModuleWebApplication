using System.Web;

namespace HttpHandlerAndModuleWebApplication.Handlers
{
    public class MyHttpHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            var response = context.Response;
            response.StatusCode = (int)System.Net.HttpStatusCode.Forbidden;
            response.Write("<h1>HttpHandler Test</h1>");
            response.Write($"HttpStatusCode: { response.StatusCode}<br>");
            response.Write($"CurrentExecutionFilePathExtension: {context.Request.CurrentExecutionFilePathExtension}<br>");
            response.Write($"Type: {context.Request.Browser.Type}<br>");
            response.Write($"Version: {context.Request.Browser.Version}");
        }
    }
}