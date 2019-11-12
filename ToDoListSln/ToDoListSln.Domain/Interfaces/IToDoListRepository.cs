using System;
using System.Collections.Generic;
using ToDoListSln.Domain.Entities;

namespace ToDoListSln.Domain.Interfaces
{
    public interface IToDoListRepository
    {
        List<ToDoList> Get();

        void Add(ToDoList todoList);

        void Delete(Guid id);

        void Update(ToDoList todoList);

        bool Exist(ToDoList todoList);

    }
}
