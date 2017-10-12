using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace CryptoCurrencyTrader
{
    public delegate void NotifyHttpStatusCodeResult(HttpStatusCode httpCode, string uri, string content, string response, bool isSuccess = true);
    public delegate void NotifyErrorResult(Exception e, string uri);

    public class RestClient
    {
        public event NotifyHttpStatusCodeResult HttpStatusCodeResult;
        public event NotifyErrorResult ErrorResult;

        private static RestClient _instance = null;

        public static RestClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    return new RestClient(Properties.Settings.Default.RemoteHost);
                }

                return _instance;
            }
        }

        private string _host = string.Empty;
        private Uri _baseAddress = null;
        private TimeSpan _timeout;

        private readonly JsonSerializerSettings _serializerSettings;
        private readonly JsonSerializerSettings _deserializerSettings;

        public RestClient(string host)
        {
            _host = host;
            _baseAddress = new Uri(_host);
            _timeout = TimeSpan.FromSeconds(10);

            _serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter> {new StringEnumConverter()},
                NullValueHandling = NullValueHandling.Ignore
            };

            _deserializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter> {new StringEnumConverter()}
            };

        }

        #region 마샬링/언마샬링
        private T DeserializeObject<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString, _deserializerSettings);
        }

        private string SerializeObject<T>(T obj)
        {
            if (obj == null)
                return string.Empty;

            var type = typeof(T);
            if (type == typeof(string))
                return obj as string;
            if (type == typeof(JObject))
                return (obj as JObject)?.ToString();

            return JsonConvert.SerializeObject(obj, typeof(T), _serializerSettings);
        }

        private T TypeConvert<T>(string jsonString)
        {
            var type = typeof(T);
            if (type == typeof(string))
                return (T)(object)jsonString;
            if (type == typeof(JObject))
                return (T)(object)JObject.Parse(jsonString);
            return DeserializeObject<T>(jsonString);
        }
        #endregion

        #region URL 파라미터 빌더
        private string AppendQueryParam(string url, Dictionary<string, string> queryParams)
        {
            var result = url;
            if (queryParams == null || queryParams.Count <= 0)
                return result;

            var sb = new StringBuilder("?");
            foreach (var pair in queryParams)
            {
                sb.Append(pair.Key);
                sb.Append("=");
                sb.Append(pair.Value);
                sb.Append("&");
            }
            sb.Remove(sb.Length - 1, 1);
            result = url + sb.ToString();
            return result;
        }
        #endregion

        #region GET 메소드
        public async Task<T> GetAsync<T>(string url, Dictionary<string, string> queryParams = null)
        {
            var http = new HttpClient();
            var uri = AppendQueryParam(url, queryParams);

            try
            {
                var response = await http.GetAsync(uri);

                string body = string.Empty;

                if (response.IsSuccessStatusCode)
                {
                    body = await response.Content.ReadAsStringAsync();
                    HttpStatusCodeResult?.Invoke(response.StatusCode, uri, null, body);
                    return TypeConvert<T>(body);
                }
                else
                {
                    HttpStatusCodeResult?.Invoke(response.StatusCode, uri, null, body, false);
                }
            }
            catch (Exception e)
            {
                ErrorResult?.Invoke(e.GetBaseException(), uri);
            }
            finally
            {
                http.Dispose();
            }

            return default(T);
        }
        #endregion

        #region POST 메소드
        public async Task<T> PostAsync<T>(string url, T value, Dictionary<string, string> queryParams = null)
        {
            return await PostAsync<T, T>(url, value, queryParams);
        }

        public async Task<OUT> PostAsync<IN, OUT>(string url, IN input, Dictionary<string, string> queryParams = null)
        {
            var http = new HttpClient();
            var uri = AppendQueryParam(url, queryParams);

            try
            {
                string body = string.Empty;

                var content = SerializeObject(input);
                var response = await http.PostAsync(uri, new StringContent(string.IsNullOrEmpty(content) ? "{}" : content, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    body = await response.Content.ReadAsStringAsync();
                    HttpStatusCodeResult?.Invoke(response.StatusCode, uri, content, body);
                    return TypeConvert<OUT>(body);
                }
                else
                {
                    HttpStatusCodeResult?.Invoke(response.StatusCode, uri, content, body, false);
                }
            }
            catch (Exception e)
            {
                ErrorResult?.Invoke(e.GetBaseException(), uri);
            }
            finally
            {
                http.Dispose();
            }

            return default(OUT);
        }
        #endregion
    }
}
