using Julio.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Julio.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();

        void Handle(Notificacao notificacao);
    }
}
