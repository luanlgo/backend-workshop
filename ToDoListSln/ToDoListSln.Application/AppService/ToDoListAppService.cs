using System;
using AutoMapper;
using ToDoListSln.Domain.Contract;
using ToDoListSln.Domain.Entities;
using ToDoListSln.Domain.Interfaces;

namespace ToDoListSln.Application.AppService
{
    public class ToDoListAppService : IToDoListAppService
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IToDoListAppQuery _toDoListAppQuery;
        private readonly IMapper _mapper;

        public ToDoListAppService(IToDoListAppQuery toDoListAppQuery, IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _toDoListAppQuery = toDoListAppQuery;
            _mapper = mapper;
        }

        public void Add(ToDoListDto todoListDto)
        {
            if (_toDoListAppQuery.Exist(todoListDto))
                throw new ArgumentException("Conteudo Existente, Por favor Mude o mesmo. :E");

            _toDoListRepository.Add(_mapper.Map<ToDoList>(todoListDto));
        }

        public void Update(ToDoListDto todoListDto)
        {
            _toDoListRepository.Update(_mapper.Map<ToDoList>(todoListDto));
        }

        public void Delete(Guid id)
        {
            _toDoListRepository.Delete(id);
        }
    }
}
