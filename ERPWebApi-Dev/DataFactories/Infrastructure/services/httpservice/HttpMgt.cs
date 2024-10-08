using DataUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.services.httpservice
{
    public class HttpMgt
    {
        public async Task<object> PostAsync(object data, string url, string token)
        {
            object result = null; object resdata = null; string message = string.Empty; bool resstate = false;
            using (var httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.ServerCertificateCustomValidationCallback = (messages, cert, chain, errors) => { return true; };
                using (var objClient = new HttpClient(httpClientHandler))
                {
                    var serializedPackage = JsonConvert.SerializeObject(data);
                    var content = new StringContent(serializedPackage, Encoding.UTF8, StaticInfos.contentTypeJson);
                    objClient.DefaultRequestHeaders.TryAddWithoutValidation(StaticInfos.authorization, token);
                    using (HttpResponseMessage resapidata = await objClient.PostAsync(url, content))
                    {
                        resdata = resapidata.Content.ReadAsStringAsync().Result;
                        if (resapidata.IsSuccessStatusCode)
                        {
                            message = MessageConstants.Saved;
                            resstate = MessageConstants.SuccessState;
                        }
                        else
                        {
                            message = MessageConstants.SavedWarning;
                            resstate = MessageConstants.ErrorState;
                        }
                    }
                }
            }

            result = new
            {
                resdata,
                message,
                resstate
            };

            return result;
        }

        public async Task<object> PutAsync(object data, string url, string token)
        {
            object result = null; object resdata = null; string message = string.Empty; bool resstate = false;
            using (var httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.ServerCertificateCustomValidationCallback = (messages, cert, chain, errors) => { return true; };
                using (var objClient = new HttpClient(httpClientHandler))
                {
                    var serializedPackage = JsonConvert.SerializeObject(data);
                    var content = new StringContent(serializedPackage, Encoding.UTF8, StaticInfos.contentTypeJson);
                    objClient.DefaultRequestHeaders.TryAddWithoutValidation(StaticInfos.authorization, token);
                    using (HttpResponseMessage resapidata = await objClient.PutAsync(url, content))
                    {
                        resdata = resapidata.Content.ReadAsStringAsync().Result;
                        if (resapidata.IsSuccessStatusCode)
                        {
                            message = MessageConstants.Saved;
                            resstate = MessageConstants.SuccessState;
                        }
                        else
                        {
                            message = MessageConstants.SavedWarning;
                            resstate = MessageConstants.ErrorState;
                        }
                    }
                }
            }

            result = new
            {
                resdata,
                message,
                resstate
            };

            return result;
        }


        public async Task<object> GetAsync(string url, string token)
        {
            object result = null; string resdata = null; string Message = string.Empty; bool resstate = false;

            string getUrl = url;

            using (var httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

                using (var objClient = new HttpClient(httpClientHandler))
                {
                    objClient.DefaultRequestHeaders.TryAddWithoutValidation(StaticInfos.authorization, token);
                    using (var resapidata = await objClient.GetAsync(getUrl))
                    {
                        if (resapidata.IsSuccessStatusCode)
                        {
                            var jsonString = resapidata.Content.ReadAsStringAsync().Result;
                            resdata = jsonString;
                            resstate = resapidata.IsSuccessStatusCode;
                        }
                        else
                        {
                            Message = resapidata.ToString();
                            resstate = MessageConstants.ErrorState;
                        }
                    }
                }
            }


            result = new
            {
                resdata,
                Message,
                resstate
            };

            return result;
        }

    }
}
