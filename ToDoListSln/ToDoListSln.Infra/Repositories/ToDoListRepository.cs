using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoListSln.Domain.Entities;
using ToDoListSln.Domain.Interfaces;
using ToDoListSln.Infra.Contexts;

namespace ToDoListSln.Infra.Repositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        protected readonly ToDoListContext _context;
        protected readonly DbSet<ToDoList> _dbSet;

        public ToDoListRepository(ToDoListContext context)
        {
            _context = context;
            _dbSet = _context.Set<ToDoList>();
        }

        public void Add(ToDoList todoList)
        {
            _dbSet.Add(todoList);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            _context.SaveChanges();
        }

        public bool Exist(ToDoList todoList)
        {
            return _dbSet.Any(x => x.Conteudo.Equals(todoList.Conteudo) && x.Checado == todoList.Checado);
        }

        public void Update(ToDoList todoList)
        {
            var data = _dbSet.Find(todoList.Id);
            data.Conteudo = todoList.Conteudo;
            data.Checado = todoList.Checado;
            _context.Update(data);
        }

        public List<ToDoList> Get()
        {
            return _dbSet.ToList();
        }
    }
}
