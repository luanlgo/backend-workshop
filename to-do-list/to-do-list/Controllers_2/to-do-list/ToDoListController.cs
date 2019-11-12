using System;
using System.Web.Http;
using to_do_list.Domain.ToDoList.Application.AppQueries;
using to_do_list.Domain.ToDoList.Application.AppService;
using to_do_list.Domain.ToDoList.Contract;
using to_do_list.Domain.ToDoList.Interfaces.IAppQueries;
using to_do_list.Domain.ToDoList.Interfaces.IAppService;

namespace to_do_list.to_do_list
{
    public class ToDoListController : ApiController
    {
        private IToDoListAppQueries _toDoListAppQueries;
        private IToDoListAppService _toDoListAppService;

        public ToDoListController()
        {
            _toDoListAppQueries = new ToDoListAppQuery();
            _toDoListAppService = new ToDoListAppService();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_toDoListAppQueries.Get());
        }

        [HttpPost]
        public IHttpActionResult Post(ToDoListDto toDoListDto)
        {
            _toDoListAppService.Add(toDoListDto);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delele(Guid id)
        {
            _toDoListAppService.Delete(id);
            return Ok();
        }

    }
}
