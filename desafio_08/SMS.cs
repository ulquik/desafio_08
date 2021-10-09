using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_08
{
    public class SMS : Notificacao
    {
        public override void EnviarNotificacao()
        {
            Console.WriteLine(" O SMS foi enviado com sucesso! ");
        }
    }
}
