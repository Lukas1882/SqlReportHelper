using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SqlReportHelper.Models
{
    public class Reflection
    {
        public void FillObjectWithProperty(ref object objectTo, string propertyName, object propertyValue)
        {
            Type tOb2 = objectTo.GetType();
            tOb2.GetProperty(propertyName).SetValue(objectTo, propertyValue);
        }
    }
}
