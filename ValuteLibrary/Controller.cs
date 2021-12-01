using Newtonsoft.Json;
using System.Net;

namespace ValuteLibrary
{
    public class Controller
    {
        public static ValuteCurrent GetValuteInfoFromUrl(string valuteUrl)
        {
            valuteUrl = $"https://www.cbr-xml-daily.ru/daily_json.js";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(valuteUrl);
            HttpWebResponse response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return new ValuteCurrent();
                throw;
            }

            string responseString;

            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                responseString = stream.ReadToEnd();
            }

            ValuteCurrent valuteCurrent = JsonConvert.DeserializeObject<ValuteCurrent>(responseString);

            return valuteCurrent;
        }

        public static Dictionary<string, string> GetValuteInfo(string charCode, Dictionary<string, ValueInfo> keyValuePairs)
        {
            var current = from value in keyValuePairs where value.Key == charCode select value;
            var dic = new Dictionary<string, string>();

            foreach (var item in current)
            {
                dic.Add("Название валюты:", item.Value.Name);
                dic.Add("Значение валюты:", Math.Round(item.Value.Value, 2).ToString());
                dic.Add("Изменение валюты:", item.Value.Difference());
            }

            return dic;
        }
    }
}
