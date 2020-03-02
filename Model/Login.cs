using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Model
{
    /// <summary>
    /// 登录的模型
    /// </summary>
    public class Login
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string DomainUrl { get; set; }
    }
}