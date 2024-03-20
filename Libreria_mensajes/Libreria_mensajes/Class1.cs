using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Libreria_mensajes
{

    public class Class1
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        string accountSid = "AC6af16cc6efb2e3c471677097e2909475";
        string authToken = "f8907ff6e8e59454bf416c44e82efc75";

        public void SendMessage()
        {
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Texto enviado desde Twilio con C#",
                from: new Twilio.Types.PhoneNumber("+19163747856"),
                to: new Twilio.Types.PhoneNumber("+529531492722")
            );

            Console.WriteLine(message.Sid);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.SendMessage();
        }
    }
}
