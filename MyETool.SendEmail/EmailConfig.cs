namespace MyETool.SendEmail
{
    /// <summary>
    /// 邮箱配置类
    /// </summary>
    public class EmailConfig
    {
        private static readonly EmailConfig Instance = new EmailConfig();

        private EmailConfig()
        {
        }

        public static EmailConfig GetInstance()
        {
            return Instance;
        }

        /// <summary>
        /// 是否启用SSL
        /// </summary>
        public bool IsSsL { get; set; } = true;

        /// <summary>
        /// 发件人邮箱（需与授权码所属邮箱一致）
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// 显示的发件人名称
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// SMTP服务器地址
        /// </summary>
        public string SmtpHost { get; set; }

        /// <summary>
        /// SMTP端口
        /// </summary>
        public int SmtpPort { get; set; }

        /// <summary>
        /// 发件人邮箱授权码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 超时时间（ms）
        /// </summary>
        public int Timeout { get; set; } = 5 * 1000;
    }
}
