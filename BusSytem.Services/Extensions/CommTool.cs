using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BusSystem.Services.Extensions
{
    public static class ExtentMethod
    {
        #region Anonymous Object Processing

        #region Will object[Primarily anonymous objects]Convert to dynamic
        /// <summary>
        /// Will object[Primarily anonymous objects]Convert to dynamic
        /// </summary>
        public static dynamic ToDynamic(this object value)
        {
            IDictionary<string, object> expando = new ExpandoObject();
            var type = value.GetType();
            var properties = TypeDescriptor.GetProperties(type);
            foreach (PropertyDescriptor property in properties)
            {
                var val = property.GetValue(value);
                if (property.PropertyType.FullName.StartsWith("<>f__AnonymousType"))
                {
                    dynamic dval = val.ToDynamic();
                    expando.Add(property.Name, dval);
                }
                else
                {
                    expando.Add(property.Name, val);
                }
            }
            return expando as ExpandoObject;
        }
        #endregion

        #region Will object[Primarily anonymous objects]Convert to List<dynamic>
        /// <summary>
        /// Will object[Primarily anonymous objects]Convert to List<dynamic>
        /// </summary>
        public static List<dynamic> ToDynamicList(this IEnumerable<dynamic> values)
        {
            var list = new List<dynamic>();
            if (values != null)
            {
                if (values.Any())
                {
                    list.AddRange(values.Select(v => ((object)v).ToDynamic()));
                }
            }

            return list;
        }
        #endregion

        

        

        #endregion
    }
}
