using System;
using System.Collections.Generic;
using AutoMapper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ToDoListSln.Application.AppQueries;
using ToDoListSln.Domain.Contract;
using ToDoListSln.Domain.Entities;
using ToDoListSln.Domain.Interfaces;

namespace ToDoListSln.UnitTestes.Application.AppQueries
{
    [TestClass]
    public class ToDoListAppQueryTest
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;
        private readonly IToDoListAppQuery _toDoListAppQuery;

        public ToDoListAppQueryTest()
        {
            _toDoListRepository = Substitute.For<IToDoListRepository>();
            _mapper = Substitute.For<IMapper>();

            _toDoListAppQuery = new ToDoListAppQuery(_toDoListRepository, _mapper);
        }

        [TestMethod]
        public void Expect_Get_Retorna_Lista_ToDoListDto()
        {
            // Arrange
            Guid idTest = Guid.NewGuid();
            var mock = GetMockRepository(idTest);
            _toDoListRepository.Get().Returns(mock);

            // Act
            _toDoListAppQuery.Get();

            // Assert
            _toDoListRepository.Received(1).Get();
            _mapper.Received(1).Map<ToDoListDto>(Arg.Any<ToDoList>());
        }

        private List<ToDoList> GetMockRepository (Guid idTest)
        {
            return new List<ToDoList>()
            {
                new ToDoList(idTest, "Conteudo", true)
            };
        }
    }
}
