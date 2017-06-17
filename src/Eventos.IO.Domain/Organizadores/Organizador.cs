using System;
using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.Organizadores
{
    public class Organizador : Entity<Organizador>
    {
        public Organizador(Guid id)
        {
            Id = id;
        }

        public override bool EhValido()
        {
            throw new System.NotImplementedException();
        }
    }
}