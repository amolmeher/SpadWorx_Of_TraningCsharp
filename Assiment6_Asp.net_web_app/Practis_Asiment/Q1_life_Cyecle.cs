using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment6_Asp.net_web_app.Practis_Asiment
{
    public class Q1_life_Cyecle
    {

    }
}
/*                          Asp.net Core Life Sycle
 Routing ->
            Asp.net Routing is the first step in MVC request cycle. Basically it is a pattern matching system that matches the request’s
                 against the registered URL patterns in the Route Table. When a matching pattern found in the Route Table, 
                the Routing engine forwards the request to the corresponding IRouteHandler for that request.
MvcHandler  ->
                The MvcHandler is responsible for initiating the real processing inside ASP.NET MVC. MVC handler
                implements IHttpHandler interface and further process the request by using ProcessRequest
                protected internal virtual void ProcessRequest(HttpContextBase httpContext)
{
                 SecurityUtil.ProcessInApplicationTrust(delegate {
                 IController controller;
                 IControllerFactory factory;
                 this.ProcessRequestInit(httpContext, out controller, out factory);
                 try
                 {
                 controller.Execute(this.RequestContext);
                 }
                 finally
                 {
                 factory.ReleaseController(controller);
                 }
                 });
                }

Controller  ->
                As shown in above code, MvcHandler uses the IControllerFactory instance and tries to get a IController instance.
                If successful, the Execute method is called. The IControllerFactory could be the default controller factory or 
                a custom factory initialized at the Application_Start event, as shown below:

Action Execution ->
                    Once the controller has been instantiated, Controller's ActionInvoker determines which specific action to invoke on the controller. 
                    Action to be execute is chosen based on attributes

View Result  ->
                    The action method receives user input, prepares the appropriate response data, 
                    and then executes the result by returning a result type. The result type can be ViewResult, 
                    RedirectToRouteResult, RedirectResult, ContentResult, JsonResult, FileResult, and EmptyResult.



View Engine ->
                 The first step in the execution of the View Result involves the selection of the appropriate View Engine to render the View Result.

Viwe        ->
                Action method may returns a text string,a binary file or a Json formatted data. The most important Action Result is the ViewResult, 
which renders and returns an HTML page to the browser by using the current view engine.








*/

