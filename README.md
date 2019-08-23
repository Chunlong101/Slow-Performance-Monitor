# How to use? 

1.	Pls navigate to https://github.com/Chunlong101/SlowPerformanceMonitor, download and unzip “SlowPerformanceMonitor.zip”. 

2.	Pls run “SlowPerformanceMonitor.exe” then change the settings properly to meet your requirement. 

3.	Pls click on “Play” button then you will see a browser will be opened up automatically, that browser will keep capturing logs, generating performance metrics and sending emails once there’s a slow performance detected. 

# Some explanations for the settings 

Sleep time – SPM (Slow Performance Monitor) will start capturing logs every 3 seconds by default. 

Page load threshold – If a page takes more than 10 seconds (by default) to be loaded then SPM considers it as slow page load. 

Slow performance reoccurrence threshold – If more than 3 (by default) slow page load were detected continuously, then SPM considers it as slow performance and starts to send email notifications.  

SMTP address – This depends on what email service provider you’d like to use and send the email notifications with, pls search online for the email service provider smtp address/port if you wanna use yours. By default, it’s my QQ email, which means people on the To line will be receiving slow performance alter from my QQ email address once there’s a slow performance detected. 

# Pls note

Running client probing, depending on the sampling rate, it’s prone to be added to firewall’s blacklist. It’s putting unnecessary pressure to the system. 

# Known issue for IE 

Error code "Unable to get IE"
Need to download the registry key from https://heliumhq.com/docs/internet_explorer.

Error code "Protected Mode settings"
Need to change IE security settings, pls select "Internet options" from the Tools menu (or the gear icon in the toolbar in later versions). Open the Security tab. At the bottom of the dialog for each of the zones ("Internet", "Local intranet", "Trusted sites" and "Restricted sites"), you should see a check box labeled "Enable Protected Mode". Set the value of the check box to the same value, either checked or unchecked (unchecked is better), for each zone. 

Error code "Browser zoom level"
Need to set IE Zoom to 100%, pls select "Internet options" from the Tools menu (or the gear icon in the toolbar in later versions). Set Zoom to 100%. 
