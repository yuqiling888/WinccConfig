using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StudentManager.Common
{
    public class DataValidate
    {
        /// <summary>
        /// 验证身份证
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
         public static bool IsIdentityCard(string txt)
        {
            Regex ObjReg = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            return ObjReg.IsMatch(txt);

        }
        /// <summary>
        /// 不是整数
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsInteger(string txt)
        {
            // 定义整数的正则表达式：可选负号开头，后跟一个或多个数字
            Regex objReg = new Regex(@"^[1-9]\d*$");
            
            // 如果输入的字符串不匹配整数模式，则返回true（表示不是整数）
            return !objReg.IsMatch(txt);
        }

    }
}
