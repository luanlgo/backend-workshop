using System;

namespace ToDoListSln.Domain.Entities
{
    public class ToDoList
    {
        public ToDoList(Guid id, string conteudo, bool checado)
        {
            Id = id;
            Conteudo = conteudo;
            Checado = checado;
        }

        public Guid Id { get; set; }

        public string Conteudo { get; set; }

        public bool Checado { get; set;  }
    }
}
