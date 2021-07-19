using System;


namespace Assiment6_Asp.net_web_app.Practis_Asiment
{
    public class Q2_state_mang
    {
    }
}

/*                                                State Management In ASP.NET MVC

ASP.NET MVC also provides state management techniques that can help us to maintain the data when redirecting from
one page to other page or in the same page after reloading. There are several ways to do this in ASP.NET MVC -

Hidden Field
Cookies
Query String
ViewData
ViewBag
TempData  

1)
    It is not new, we all know it from HTML programming. Hidden field is used to hide your data on client side.
        It is not directly visible to the user on UI but we can see the value in the page source
        if you want to store a sensitive data. It’s only used to store a small amount of data which is frequently changed.
       eg :-@Html.HiddenFor(x=>x.Id)  
            <input data-val="true" data-val-number="The field Id must be a number." 
            data-val-required="The Id field is required." id="Id" name="Id" type="hidden" value="1001" />  

2) 

        Cookies are used for storing the data but that data should be small. It is like a small text file where we can store our data. 
        The good thing is that a cookie is created on client side memory in the browser.
        Most of the times, we use a cookie for storing the user information after login with some expiry time.
        Basically, a cookie is created by the server and sent to the browser in response. The browser saves it in client-side memory.

3)
        we generally use a query string to pass the value from one page to the next page. Same we can do in ASP.NET MVC as well.

4)
        It helps us to maintain your data when sending the data from Controller to View. It is a dictionary object and derived from ViewDataDictionary. As it is a dictionary object, it takes the data in a key-value pair.
        Once you create ViewData object, pass the value, and make redirection; the value will become null.
        The data of ViewData is not valid for next subsequent request. Take care of two things when using ViewData, 
        first, check for null and second, check for typecasting for complex data types.
5)
        The ViewBag’s task is same as that of ViewData. It is also used to transfer the data from Controller to View. However, 
            the only difference is that ViewBag is an object of Dynamic property introduced in C# 4.a. It is a wrapper around ViewData. 
            If you use ViewBag rather than ViewData, you will not have to do typecasting with the 
            complex objects and do not need to check for null.



6)
        TempData is also a dictionary object as ViewData and stores value in key/value pair. It is derived from TempDataDictionary.
        It is mainly used to transfer the data from one request to another request or we can say subsequent request. 
        If the data for TempData has been read, then it will get cleaned. To persist the data, there are different ways. 
        It all depends on how you read the data.





 */