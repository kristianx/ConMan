using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConManApp.DB;
using ConManApp.EnModels;
using Microsoft.AspNetCore.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using Twilio.TwiML;

namespace ConManApp.Controllers
{
    
    public class WhatsAppController : TwilioController
    {

        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            MojDBCOntext db = new MojDBCOntext();

            Regex broj = new Regex("[Ww]hatsapp[: ]?([+]\\d+)");
            string brojSkladistara = broj.Match(incomingMessage.From).Groups[1].ToString();


            Skladistar s = db.Skladistar.FirstOrDefault(s => s.KontaktBroj == brojSkladistara);

            Regex regex = new Regex("Dodaj (\\w*)?( ,)?(.*)");
            var v = regex.Match(incomingMessage.Body);
            string naziv = v.Groups[1].ToString();
            bool upotrebljivo = v.Groups[3].ToString() == "1" ? true : false;

            var messagingResponse = new MessagingResponse();

            try
            {
                db.Oprema.Add(new Oprema
                {
                    Naziv = naziv,
                    SkladisteId = s.SkladisteId,
                    usable = upotrebljivo,
                    JeIznajmljeno = false
                });
                db.SaveChanges();
                messagingResponse.Message("Uspjesno ste dodali " + naziv + " na skladiste " + db.Skladiste.FirstOrDefault(sk => sk.SkladisteId == s.SkladisteId).Naziv);
            }
            catch
            {
                messagingResponse.Message("Doslo je do greske prilikom dodavanja!");
            }
       

           
            

            return TwiML(messagingResponse);
        }
    }
    
}
