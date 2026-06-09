# 使用 C# 向指定邮箱地址发送邮件

> 已经测试的邮箱服务商
>
> - [x] QQ 邮箱
> - [x] 网易邮箱

## 第一步：配置邮箱参数

```c#
EmailConfig.GetInstance().IsSsL = true;
EmailConfig.GetInstance().FromEmail = "XXXXXXXXX@qq.com";
EmailConfig.GetInstance().Password = "XXXXXXXXXXXX";
EmailConfig.GetInstance().FromName = "XXXXXX";
EmailConfig.GetInstance().SmtpHost = "smtp.qq.com";
EmailConfig.GetInstance().SmtpPort = 587;
EmailConfig.GetInstance().Timeout = 3 * 1000;
```

## 第二步：发送邮件

```c#
try
{
    EmailUtil.SendEmail("mq62g2eg2fa5@animateany.com", "邮件主题", "邮件内容");
}
catch (Exception e)
{
    Console.WriteLine(e);
}
```
