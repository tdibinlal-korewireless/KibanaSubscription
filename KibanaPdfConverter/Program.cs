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

            jobject.trigger.schedule.daily.at = "12:00";

            // Email id to which the Pdf to be sent
            jobject.actions.send_email.email.to = "dibinsgames@gmail.com";
            jobject.actions.send_email.email.subject = "Kibana report from C#";

        /* 
         * Url for triggering the Pdf exporting in Kibana
         * 
         * See https://www.elastic.co/guide/en/kibana/current/automating-report-generation.html
         */
        //jobject.actions.send_email.email.attachments.dashboard.reporting.url = "http://localhost:5601/api/reporting/generate/dashboard/722b74f0-b882-11e8-a6d9-e546fe2bba5f?_g=(refreshInterval:(pause:!t,value:0),time:(from:now-7d,mode:quick,to:now))";

        jobject.actions.send_email.email.attachments.dashboard.reporting.url = "http://localhost:5602/api/reporting/generate/printablePdf?jobParams=(browserTimezone:Asia%2FCalcutta,layout:(dimensions:(height:2024,width:1169),id:preserve_layout),objectType:dashboard,relativeUrls:!(%27%2Fapp%2Fkibana%23%2Fdashboard%2F722b74f0-b882-11e8-a6d9-e546fe2bba5f%3F_g%3D(refreshInterval:(pause:!!f,value:900000),time:(from:now%252Fw,mode:quick,to:now%252Fw))%26_a%3D(description:!%27Analyze%2Bmock%2BeCommerce%2Borders%2Band%2Brevenue!%27,filters:!!(),fullScreenMode:!!f,options:(darkTheme:!!f,hidePanelTitles:!!f,useMargins:!!t),panels:!!((embeddableConfig:(vis:(colors:(!%27Men!!!%27s%2BAccessories!%27:%252382B5D8,!%27Men!!!%27s%2BClothing!%27:%2523F9BA8F,!%27Men!!!%27s%2BShoes!%27:%2523F29191,!%27Women!!!%27s%2BAccessories!%27:%2523F4D598,!%27Women!!!%27s%2BClothing!%27:%252370DBED,!%27Women!!!%27s%2BShoes!%27:%2523B7DBAB))),gridData:(h:10,i:!%271!%27,w:36,x:12,y:18),id:!%2737cc8650-b882-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%271!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(vis:(colors:(FEMALE:%25236ED0E0,MALE:%2523447EBC),legendOpen:!!f)),gridData:(h:11,i:!%272!%27,w:12,x:12,y:7),id:ed8436b0-b88b-11e8-a6d9-e546fe2bba5f,panelIndex:!%272!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(),gridData:(h:7,i:!%273!%27,w:18,x:0,y:0),id:!%2709ffee60-b88c-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%273!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(),gridData:(h:7,i:!%274!%27,w:30,x:18,y:0),id:!%271c389590-b88d-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%274!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(),gridData:(h:11,i:!%275!%27,w:48,x:0,y:28),id:!%2745e07720-b890-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%275!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(),gridData:(h:10,i:!%276!%27,w:12,x:0,y:18),id:!%2710f1a240-b891-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%276!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(),gridData:(h:11,i:!%277!%27,w:12,x:0,y:7),id:b80e6540-b891-11e8-a6d9-e546fe2bba5f,panelIndex:!%277!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(vis:(colors:(!%270%2B-%2B50!%27:%2523E24D42,!%2750%2B-%2B75!%27:%2523EAB839,!%2775%2B-%2B100!%27:%25237EB26D),defaultColors:(!%270%2B-%2B50!%27:!%27rgb(165,0,38)!%27,!%2750%2B-%2B75!%27:!%27rgb(255,255,190)!%27,!%2775%2B-%2B100!%27:!%27rgb(0,104,55)!%27),legendOpen:!!f)),gridData:(h:11,i:!%278!%27,w:12,x:24,y:7),id:!%274b3ec120-b892-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%278!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(vis:(colors:(!%270%2B-%2B2!%27:%2523E24D42,!%272%2B-%2B3!%27:%2523F2C96D,!%273%2B-%2B4!%27:%25239AC48A),defaultColors:(!%270%2B-%2B2!%27:!%27rgb(165,0,38)!%27,!%272%2B-%2B3!%27:!%27rgb(255,255,190)!%27,!%273%2B-%2B4!%27:!%27rgb(0,104,55)!%27),legendOpen:!!f)),gridData:(h:11,i:!%279!%27,w:12,x:36,y:7),id:!%279ca7aa90-b892-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%279!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(),gridData:(h:18,i:!%2710!%27,w:48,x:0,y:54),id:!%273ba638e0-b894-11e8-a6d9-e546fe2bba5f!%27,panelIndex:!%2710!%27,type:search,version:!%277.0.0-alpha1!%27),(embeddableConfig:(mapCenter:!!(28.304380682962783,-22.148437500000004),mapZoom:2),gridData:(h:15,i:!%2711!%27,w:24,x:0,y:39),id:!%279c6f83f0-bb4d-11e8-9c84-77068524bcab!%27,panelIndex:!%2711!%27,type:visualization,version:!%277.0.0-alpha1!%27),(embeddableConfig:(),gridData:(h:15,i:!%2712!%27,w:24,x:24,y:39),id:b72dd430-bb4d-11e8-9c84-77068524bcab,panelIndex:!%2712!%27,type:visualization,version:!%277.0.0-alpha1!%27)),query:(language:lucene,query:!%27!%27),timeRestore:!!t,title:!%27%255BeCommerce%255D%2BRevenue%2BDashboard!%27,viewMode:view)%27),title:%27%5BeCommerce%5D%20Revenue%20Dashboard%27)";
        


            //jobject.actions.send_email.email.attachments.dashboard.reporting.retries = ;
            jobject.actions.send_email.email.attachments.dashboard.reporting.interval = "1s";

            // Elasticsearch username and password
            jobject.actions.send_email.email.attachments.dashboard.reporting.auth.basic.username = "elastic";
            jobject.actions.send_email.email.attachments.dashboard.reporting.auth.basic.password = "elastic";

            /*
             * Triggering the POST message
             */
            //HttpRestClient restClient = new HttpRestClient();
            //restClient.POST(JsonConvert.SerializeObject(jobject), ConfigurationManager.AppSettings["KibanaURI"] + "/api/console/proxy?path=_xpack%2Fwatcher%2Fwatch%2Freport&method=PUT", true);

            Console.WriteLine(JsonConvert.SerializeObject(jobject));
                Console.ReadLine();

        }
    }
}
