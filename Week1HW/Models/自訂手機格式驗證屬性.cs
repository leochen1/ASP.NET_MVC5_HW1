using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Week1HW.Models
{
    public class 自訂手機格式驗證屬性 : DataTypeAttribute
    {
        public 自訂手機格式驗證屬性()
            : base(DataType.Text)
        {
            this.ErrorMessage = "手機電話格式須符合 XXXX-XXXXXX";
        }

        public override bool IsValid(object value)
        {
            //not input
            if (value == null)
            {
                return true;
            }
                
            //has input
            if (value is String)
            {
                //IsMatch本身就是bool的回傳值，所以利用直接回傳這個值，可以表示是否已經通過驗證
                return Regex.IsMatch(value.ToString(), "[0-9]{4}-[0-9]{6}");
            }
            else
            {
                return true;
            }
                
        }
    }
}