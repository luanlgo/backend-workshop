using System;
using to_do_list.Domain.ToDoList.Interfaces;

namespace to_do_list.Domain.ToDoList.Repository
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

