using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGuidelines
{
    public class Notification
    {
        HttpClient _httpClient;

        public async Task SendNotification(string endpointUrl)
        {
            try
            {
                _httpClient = new HttpClient();
                var content = new FormUrlEncodedContent(new[]
                       {
                             new KeyValuePair<string, string>("", "")
                        });
                HttpResponseMessage message = await _httpClient.PostAsync(endpointUrl, content);
                string response = await message.Content.ReadAsStringAsync();
                /* Do something with the response  */
            }
            catch (Exception ex)
            {

                throw new UnableToConnectToServerException(ex);
                throw new WebServiceException(ex);
            }
        }
    }

    public class UserService
    {
        public async Task CreateUser(string userName)
        {
            try
            {
                /* create user  */

                Notification notification = new Notification();
                await notification.SendNotification("url");
            }
            catch (UnableToConnectToServerException ex)
            {

                /* rollback  */
            }
            catch (WebServiceException ex)
            {

                /* rollback  */
            }
        }
    }

    public class UnableToConnectToServerException : Exception
    {
        public UnableToConnectToServerException(Exception innerException)
            : base(innerException.Message, innerException)
        {

        }
    }
    public class WebServiceException : Exception
    {

        public WebServiceException(Exception innerException)
              : base(innerException.Message, innerException)
        {

        }
    }
}
