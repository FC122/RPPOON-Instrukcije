/*Ako je dana struktura klasa prema izlistanju koda, o 
kojem je obrascu rijec? U koju skupinu pripada? Pojasnite
dvije prednosti koje donosi u ovom konkretnom slucaju*/
namespace OsmiZadatakRjesenjeIspit4
{
    public class Mail
    {
        public string Contents { get; private set; }
        public string Sender { get; private set; }
    }
    public interface ISenderLogger
    {
        public void Log(string log);
    }
    public interface ISpamTermsProvider
    {
        public List<string> GetTerms();
    }
    public interface IComplaintsService { }
    public abstract class MailProcessor
    {
        protected MailProcessor next;
        public void SetNext(MailProcessor mailProcessor)
        {
            this.next = mailProcessor;
        }
        public abstract void Process(Mail mail);
    }

    public class SpamProcessor : MailProcessor
    {
        private ISpamTermsProvider spamTermsProvider;
        private ISenderLogger senderLogger;
        public SpamProcessor(ISpamTermsProvider spamTermsProvider, ISenderLogger senderLogger)
        {
            this.spamTermsProvider = spamTermsProvider;
            this.senderLogger = senderLogger;
        }
        public override void Process(Mail mail)
        {
            foreach (string term in spamTermsProvider.GetTerms())
            {
                if (mail.Contents.Contains(term))
                {
                    senderLogger.Log(mail.Sender);
                    break;
                }
            }
            if (next != null)
            {
                next.Process(mail);
            }
        }
    }

    public class ComplaintProcessor : MailProcessor
    {
        private IComplaintsService complaintsService;
        public ComplaintProcessor(IComplaintsService complaintsService)
        {
            this.complaintsService = complaintsService;
        }
        public override void Process(Mail mail)
        {
            // Register a complaint using the complaints service
        }
    }
    /*
      Fleksibilnost: Omogućava dinamičko dodavanje i konfiguriranje različitih procesora pošte bez potrebe za izmjena već postojećeg koda. Na primjer, možemo lako dodati ili zamijeniti procesore za obradu spam pošte ili pritužbi bez utjecaja na ostatak sustava.
      Održivost: Ovaj obrazac omogućava odvajanje odgovornosti za obradu različitih vrsta pošte u odvojene klase, što olakšava održavanje i nadogradnju sustava. Svaka klasa je odgovorna samo za jednu specifičnu vrstu obrade pošte, što olakšava razumijevanje i testiranje koda.
    */
}