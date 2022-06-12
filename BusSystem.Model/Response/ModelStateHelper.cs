using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusSystem.Model.Response
{
    public static class ModelStateHelper
    {
        public static IEnumerable<Error> Errors(this ModelStateDictionary modelState)
        {
            var result = from ms in modelState
                         where ms.Value.Errors.Any()
                         let fieldKey = ms.Key
                         let errors = ms.Value.Errors
                         from error in errors
                         select new Error(fieldKey, error.ErrorMessage);

            return result;
        }
    }
    public class Error
    {
        public Error(string key, string message)
        {
            Key = key;
            Message = message;
        }

        public string Key { get; set; }
        public string Message { get; set; }
    }
}
