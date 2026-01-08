using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StudentGuanli.Common
{
    public class SerializeObjectToString
    {
        /// <summary>
        /// 将Object类型对象（注：必须是可序列化的对象）转换为二进制序字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string SerializeOboject(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            string result = string.Empty;
            using(MemoryStream stream=new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                byte[] byt = new byte[stream.Length];
                byt = stream.ToArray();
               // result = Encoding.UTF8.GetString(byt, 0, byt.Length);
                result = Convert.ToBase64String(byt);
                stream.Flush();
            }
            return result;
        }


        /// <summary>
        /// 将二进制序字符串对象转换为Object类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public object DeserializeToObject(string str)
        {
            IFormatter formatter = new BinaryFormatter();
            byte[] byt = Convert.FromBase64String(str);
            object obj = null;
            using (Stream stream = new MemoryStream(byt, 0, byt.Length))
            {
                obj = formatter.Deserialize(stream);
            }           
            return obj;
        }
    }

}
