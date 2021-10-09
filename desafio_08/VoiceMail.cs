using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_08
{
    public class VoiceMail : Notificacao
    {
        public override void EnviarNotificacao()
        {
            Console.WriteLine(" O VoiceMail foi enviado com sucesso! ");
        }
    }
}
