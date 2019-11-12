using System;

namespace Domain.ToDoList.Interfaces
{
    public interface IItem
    {
        Guid Id { get; }

        string Conteudo { get; }

        bool Check { get; }
    }
}
