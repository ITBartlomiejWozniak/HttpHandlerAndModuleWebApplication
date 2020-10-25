using System;
using System.Diagnostics;
using System.Web;

namespace HttpHandlerAndModuleWebApplication.Modules
{
    public class MyHttpModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler((sender, e) => LogEvent(sender, e, "BeginRequest"));
            context.AuthenticateRequest += new EventHandler((sender, e) => LogEvent(sender, e, "AuthenticateRequest"));
            context.AuthorizeRequest += new EventHandler((sender, e) => LogEvent(sender, e, "AuthorizeRequest"));
            context.ResolveRequestCache += new EventHandler((sender, e) => LogEvent(sender, e, "ResolveRequestCache"));
            context.AcquireRequestState += new EventHandler((sender, e) => LogEvent(sender, e, "AcquireRequestState"));
            context.PreRequestHandlerExecute += new EventHandler((sender, e) => LogEvent(sender, e, "PreRequestHandlerExecute"));
            context.PostRequestHandlerExecute += new EventHandler((sender, e) => LogEvent(sender, e, "PostRequestHandlerExecute"));
            context.ReleaseRequestState += new EventHandler((sender, e) => LogEvent(sender, e, "ReleaseRequestState"));
            context.UpdateRequestCache += new EventHandler((sender, e) => LogEvent(sender, e, "UpdateRequestCache"));
            context.EndRequest += new EventHandler((sender, e) => LogEvent(sender, e, "EndRequest"));

        }

        public void LogEvent(object sender, EventArgs e, string eventName)
        {
            Debug.WriteLine(eventName);
        }
    }
}