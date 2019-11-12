using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Domain.ToDoList.Contract;

namespace to_do_list.Domain.ToDoList.Interfaces.IAppQueries
{
    public interface IToDoListAppQueries
    {
        List<ToDoListDto> Get();
    }
}
