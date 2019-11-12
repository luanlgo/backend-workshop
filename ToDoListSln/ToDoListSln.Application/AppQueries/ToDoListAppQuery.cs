using System.Collections.Generic;
using AutoMapper;
using ToDoListSln.Domain.Contract;
using ToDoListSln.Domain.Entities;
using ToDoListSln.Domain.Interfaces;

namespace ToDoListSln.Application.AppQueries
{
    public class ToDoListAppQuery : IToDoListAppQuery
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public ToDoListAppQuery(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public List<ToDoListDto> Get()
        {
            var listDomain = _toDoListRepository.Get();
            var retorno = new List<ToDoListDto>();
            listDomain.ForEach(td => {
                retorno.Add(_mapper.Map<ToDoListDto>(td));
            });
            return retorno;
        }

        public bool Exist(ToDoListDto todoList)
        {
            var domain = _mapper.Map<ToDoList>(todoList);
            return _toDoListRepository.Exist(domain);
        }
    }
}
