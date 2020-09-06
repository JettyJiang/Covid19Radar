﻿using System;
using System.Collections.Generic;
using Covid19Radar.Resources;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class InqueryPageViewModel : ViewModelBase
    {

        public InqueryPageViewModel() : base()
        {
        }

        public Command OnClickSite1 => new Command(async () =>
        {
            var uri = "https://github.com/Covid-19Radar/Covid19Radar";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        });

        public Command OnClickSite2 => new Command(async () =>
        {
            var uri = "https://github.com/Covid-19Radar/Covid19Radar";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        });

        public Command OnClickSite3 => new Command(async () =>
        {
            var uri = "https://github.com/Covid-19Radar/Covid19Radar";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        });

        public Command OnClickEmail => new Command(async () =>
        {

            try
            {
                List<string> recipients = new List<string>();
                recipients.Add(AppSettings.Instance.SupportEmail);
                var message = new EmailMessage
                {
                    Subject = AppResources.InqueryMailSubject,
                    Body = AppResources.InqueryMailBody.Replace("\\r\\n", "\r\n"),
                    To = recipients
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device
            }
            catch (Exception ex)
            {
                // Some other exception occurred
            }
        });


    }
}
