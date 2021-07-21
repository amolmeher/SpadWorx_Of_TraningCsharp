﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ActionFilterMVC.Controllers
{
    public class CustomExceptionFilter:IExceptionFilter
    {
        private readonly IModelMetadataProvider _modelMetadataProvider;
        public CustomExceptionFilter(IModelMetadataProvider modelMetadataProvider)
        {
            _modelMetadataProvider = modelMetadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomError" };
            result.ViewData = new ViewDataDictionary(_modelMetadataProvider,context.ModelState);
            context.ExceptionHandled = true;
            context.Result = result;
        }
    }
}
