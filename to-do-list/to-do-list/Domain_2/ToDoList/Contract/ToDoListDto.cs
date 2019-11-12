using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace to_do_list.Domain.ToDoList.Contract
{
    public class ToDoListDto
    {
        public Guid Id { get; set; }

        public string Conteudo { get; set; }

        public bool Check { get; set; }
    }
}