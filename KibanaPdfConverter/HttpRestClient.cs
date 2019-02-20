using System.Configuration;
using System.IO;
using System.Net;

namespace KibanaPdfConverter
{
    public class HttpRestClient
    {
        public string POST(string jsonRequest, string Uri = "", bool authRequire = false)
        {
            /*
             * Configuring the HTTP Rest Client
             */
            string result = "";
            var httpWebRequest = Uri == "" ? (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["KibanaURI"] + "/api/kibana/dashboards/import") : (HttpWebRequest)WebRequest.Create(Uri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("kbn-xsrf", "true");
            if (authRequire)
            {
                httpWebRequest.Headers.Add("Authorization", "Basic " + System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("elastic:elastic")));
            }
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsonRequest);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
    }
}
