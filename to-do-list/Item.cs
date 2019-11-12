using System;
using Domain.ToDoList.Interfaces;

namespace Domain.ToDoList.Entity
{
    public class Item : IItem
    {
	    public Item(Guid id, string conteudo, bool check)
        {
            Id = id;
            Conteudo = conteudo;
            Check = check;
        }

        public Guid Id { get; }

        public string Conteudo { get; }

        public bool Check { get; }
    }
}

