using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApp.Controllers
{
    [Route("/Todo")]
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            return View();
        }

        [Route("/add")]
        public IActionResult AddTodos()
        {
            TodoRepository.AddTodo();
            return RedirectToAction("list");
        }
    }
}
