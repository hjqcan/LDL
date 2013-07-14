using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LDL.Client.Common
{
    /// <summary>
    /// 扩展系统类方法
    /// </summary>
    public static class LibExtendHelper
    {
        /// <summary>
        /// 泛型对象深复制
        /// </summary>
        public static List<T> Clone<T>(this List<T> lstObj)
        {
            if (lstObj == null)
                return null;

            using (Stream objectStream = new MemoryStream())
            {
                //利用 System.Runtime.Serialization序列化与反序列化完成引用对象的复制  
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, lstObj);
                objectStream.Seek(0, SeekOrigin.Begin);
                return (List<T>)formatter.Deserialize(objectStream);
            } 
        }

    }
}
