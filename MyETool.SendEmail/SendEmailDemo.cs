using System;

namespace MyETool.SendEmail
{
    public class SendEmailDemo
    {
        public static void Main()
        {
            // 1. 修改邮箱配置类参数
            EmailConfig.GetInstance().IsSsL = true;
            EmailConfig.GetInstance().FromEmail = "XXXXXXXXX@qq.com";
            EmailConfig.GetInstance().Password = "XXXXXXXXXXXX";
            EmailConfig.GetInstance().FromName = "XXXXXX";
            EmailConfig.GetInstance().SmtpHost = "smtp.qq.com";
            EmailConfig.GetInstance().SmtpPort = 587;
            EmailConfig.GetInstance().Timeout = 3 * 1000;

            // 2. 发送邮件
            try
            {
                EmailUtil.SendEmail("mq62g2eg2fa5@animateany.com", "邮件主题", "邮件内容");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
