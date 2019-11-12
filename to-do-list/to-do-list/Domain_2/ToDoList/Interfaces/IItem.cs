using System;

namespace to_do_list.Domain.ToDoList.Interfaces
{
    public interface IItem
    {
        Guid Id { get; }

        string Conteudo { get; }

        bool Check { get; }
    }
}
