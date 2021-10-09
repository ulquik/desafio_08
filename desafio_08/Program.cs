using System;

namespace desafio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificacao EnviarVoiceMail = new VoiceMail();
            EnviarVoiceMail.EnviarNotificacao();
            Console.WriteLine();

            Notificacao EnviarEmail = new Email();
            EnviarEmail.EnviarNotificacao();
            Console.WriteLine();

            Notificacao EnviarSMS = new SMS();
            EnviarSMS.EnviarNotificacao();
        }
    }
}
