using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace LDLWCFService.Common
{
    public class EntityObjectHelper
    {
        public static void Copyto<T>(T newObj, ref T oldObj) where T : EntityObject
        {
            System.Reflection.PropertyInfo[] pNews = newObj.GetType().GetProperties();
            System.Reflection.PropertyInfo[] pOlds = oldObj.GetType().GetProperties();
            foreach (System.Reflection.PropertyInfo propertyNew in pNews)
            {
                System.Reflection.PropertyInfo propertyOld = pOlds.FirstOrDefault(obj => obj.Name == propertyNew.Name);
                if (propertyOld != null && propertyOld.CanWrite && propertyOld.Name != "EntityKey")
                {
                    var val = propertyNew.GetValue(newObj, null);
                    propertyOld.SetValue(oldObj, val, null);
                }
            }
        }
    }
}
