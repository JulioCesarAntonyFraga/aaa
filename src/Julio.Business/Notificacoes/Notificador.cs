using Julio.Business.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Julio.Business.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacacoes;

        public Notificador()
        {
            _notificacacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacacoes.Any();
        }
    }
}
