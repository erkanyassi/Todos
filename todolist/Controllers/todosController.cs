using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todolist.Models;
using todolist.Repository;
using todolist.Helpers;
namespace todolist.Controllers
{
    public class todosController : Controller
    {
        private ItodoInterface ItodoInterface;

        public todosController()
        {
            this.ItodoInterface = new todoClass(new todolistEntities());
        }
        // GET: todos
        public ActionResult Index()
        {
            var todolist = ItodoInterface.getTodos().ToList();
            var todosDetail = new todo();

            return View(todolist);
        }

        // GET: todos/Details/5
        public ActionResult Details(int id)
        {
           var getDetail=  ItodoInterface. getTodoById(id);
            var todosDetail = new todo();
            todosDetail.id = id;
            todosDetail.todo_title = getDetail.todo_title;
            todosDetail.todo_content = getDetail.todo_content;
          
            return View(todosDetail);
        }

        // GET: todos/Create
        [HttpGet]
        public ActionResult Create()
        {

            return View(new todo());
        }

        // POST: todos/Create
        [HttpPost]
        public ActionResult Create(todo todoInsert)
        {
            try
            {
                // TODO: Add insert logic here
                var Newtodos = new todo();
                Newtodos.todo_title = todoInsert.todo_title;
                Newtodos.todo_content = todoInsert.todo_content;
                Newtodos.date = todoInsert.date;
                AlertTimeClass clock = new AlertTimeClass(Newtodos.date);

                ItodoInterface.insertTodo(Newtodos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: todos/Edit/5
        public ActionResult Edit(int id)
        {
            var getDetail = ItodoInterface.getTodoById(id);
            var todosDetail = new todo();
            todosDetail.id = id;
            todosDetail.todo_title = getDetail.todo_title;
            todosDetail.todo_content = getDetail.todo_content;

            return View(todosDetail);
        }

        // POST: todos/Edit/5
        [HttpPost]
        public ActionResult Edit(todo todo, int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ItodoInterface.updateTodo(todo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: todos/Delete/5
        [HttpGet]

        public ActionResult Delete(int id)
        {
            var todoItem = ItodoInterface.getTodoById(id);


            return View(todoItem);
        }

        // POST: todos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ItodoInterface.deleteTodo(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
