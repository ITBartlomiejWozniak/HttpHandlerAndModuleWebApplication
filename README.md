# HttpHandlerAndModuleWebApplication

HTTP Handlers and HTTP Modules are associated with all the client requests. One request can have multiple HTTP Modules associated with it but can be handled by only one HTTP Handler.  HTTP handlers allow you to inject logic based on the extension of the file name requested. They are executed based of file extensions, URLs and HTTP verbs. 
HTTP modules are event driven and inject logic before a resource is requested. HttpModules take part in processing of the request by handling the Application events. There are number of events which you can handle during the HttpModule processing. For example - BeginRequest(), EndRequest(), AuthenticateRequest() etc.

HttpHandler processes HTTP endpoints requests whereas, HttpModule gives you access to the HTTP pipeline, which allows it to inspect incoming requests and outgoing responses by subscribing to events.

References: 
* https://www.c-sharpcorner.com/article/http-handlers-and-http-modules-in-asp-net/
* https://www.dotnetcurry.com/aspnet/1264/aspnet-http-handlers-http-modules
