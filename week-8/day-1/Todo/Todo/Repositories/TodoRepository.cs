using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Models;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void AddTodo()
        {
            var todo = new Todo()
            {
                Title = "Bake pizza",
                IsUrgent = false,
                IsDone = false
            };
            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();
        }
    }
}
