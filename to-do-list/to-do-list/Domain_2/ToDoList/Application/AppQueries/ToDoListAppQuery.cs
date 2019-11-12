using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using to_do_list.Domain.ToDoList.Contract;
using to_do_list.Domain.ToDoList.Interfaces.IAppQueries;

namespace to_do_list.Domain.ToDoList.Application.AppQueries
{
    public class ToDoListAppQuery : IToDoListAppQueries
    {

        public List<ToDoListDto> Get()
        {
            return null;
        }

    }
}