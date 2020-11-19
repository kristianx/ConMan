using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class WhatsAppHelper
{
    public static void Send(string skladistarBroj, string text)
    {
        var accountSid = "ACb176c82339857bdfd1e5af6245152772";
        var authToken = "d7176fd33c51f4396afca0ebde9c240e";
        TwilioClient.Init(accountSid, authToken);

        var messageOptions = new CreateMessageOptions(
            new PhoneNumber("whatsapp:" + skladistarBroj));
        messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
        messageOptions.Body = text;
        var message = MessageResource.Create(messageOptions);
        Console.WriteLine(message.Body);
    }
    public void GetMessage()
    {

    }
}