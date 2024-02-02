/*Ako je dana struktura klasa prema izlistanju koda, o 
kojem je obrascu rijec? U koju skupinu pripada? Pojasnite
dvije prednosti koje donosi u ovom konkretnom slucaju*/
// namespace OsmiZadatakIspit4
// {
//     public abstract class MailProcessor
//     {
//         protected MailProcessor next;
//         public void SetNext(MailProcessor mailProcessor)
//         {
//             this.next = mailProcessor;
//         }
//         public abstract void Process(Mail mail);
//     }

//     public class SpamProcessor : MailProcessor
//     {
//         private ISpamTermsProvider spamTermsProvider;
//         private ISenderLogger senderLogger;
//         public SpamProcessor(ISpamTermsProvider spamTermsProvider, ISenderLogger senderLogger)
//         {
//             this.spamTermsProvider = spamTermsProvider;
//             this.senderLogger = senderLogger;
//         }
//         public override void Process(Mail mail)
//         {
//             foreach (string term in spamTermsProvider.GetTerms())
//             {
//                 if (mail.Contents.Contains(term))
//                 {
//                     senderLogger.Log(mail.Sender);
//                     break;
//                 }
//             }
//             if (next != null)
//             {
//                 next.Process(mail);
//             }
//         }
//     }

//     public class ComplaintProcessor : MailProcessor
//     {
//         private IComplaintsService complaintsService;
//         public ComplaintProcessor(IComplaintsService complaintsService)
//         {
//             this.complaintsService = complaintsService;
//         }
//         public override void Process(Mail mail)
//         {
//             // Register a complaint using the complaints service
//         }
//     }
// }