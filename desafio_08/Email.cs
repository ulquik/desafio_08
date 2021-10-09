using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_08
{
    public class Email : Notificacao
    {
        public override void EnviarNotificacao()
        {
            Console.WriteLine(" O email foi enviado com sucesso! ");
        }
    }

}
