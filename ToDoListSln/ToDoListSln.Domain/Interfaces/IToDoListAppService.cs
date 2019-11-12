using System;
using ToDoListSln.Domain.Contract;

namespace ToDoListSln.Domain.Interfaces
{
    public interface IToDoListAppService
    {
        void Add(ToDoListDto todoListDto);

        void Delete(Guid id);
    }
}
