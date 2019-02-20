using Newtonsoft.Json;
using System;
using System.Configuration;

namespace KibanaPdfConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Setting up the json string for POST message
             */
            JsonObjectConverter jobject = new JsonObjectConverter();

            jobject.trigger.schedule.interval = "20s";

            // Email id to which the Pdf to be sent
            jobject.actions.send_email.email.to = "test_email@gmail.com";
            jobject.actions.send_email.email.subject = "Kibana report from C#";

            /* 
             * Url for triggering the Pdf exporting in Kibana
             * 
             * See https://www.elastic.co/guide/en/kibana/current/automating-report-generation.html
             */
            jobject.actions.send_email.email.attachments.dashboard.reporting.url = "http://localhost:5601/api/reporting/generate/dashboard/7adfa750-4c81-11e8-b3d7-01146121b73d?_g=(time:(from:now-1d%2Fd,mode:quick,to:now-1d%2Fd))";

            jobject.actions.send_email.email.attachments.dashboard.reporting.retries = 100;
            jobject.actions.send_email.email.attachments.dashboard.reporting.interval = "1s";

            // Elasticsearch username and password
            jobject.actions.send_email.email.attachments.dashboard.reporting.auth.basic.username = "elastic";
            jobject.actions.send_email.email.attachments.dashboard.reporting.auth.basic.password = "elastic";

            /*
             * Triggering the POST message
             */
            HttpRestClient restClient = new HttpRestClient();
            restClient.POST(JsonConvert.SerializeObject(jobject), ConfigurationManager.AppSettings["KibanaURI"] + "/api/console/proxy?path=_xpack%2Fwatcher%2Fwatch%2Ferror_report&method=PUT", true);

            
        }
    }
}
