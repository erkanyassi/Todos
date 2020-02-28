using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using todolist.Models;

namespace todolist.Repository
{
    public class todoClass : ItodoInterface
    {

        private todolistEntities todolistEntities;

        public todoClass(todolistEntities todolistEntities)
        {
            this.todolistEntities = todolistEntities;
        }

        public void deleteTodo(int todoId)
        {
            todo DeleteTodoItem = todolistEntities.todos.Find(todoId);
            todolistEntities.todos.Remove(DeleteTodoItem);
            todolistEntities.SaveChanges();
           // throw new NotImplementedException();
        }

        public todo getTodoById(int todoId)
        {
          var selectNote =  todolistEntities.todos.FirstOrDefault(b => b.id == todoId);
            return selectNote;

            //throw new NotImplementedException();
        }

        public IEnumerable<todo> getTodos()
        {
            var todoList = todolistEntities.todos.ToList();
           
            return todoList;

           // throw new NotImplementedException();
        }

        public void insertTodo(todo todo)
        {

            todolistEntities.todos.Add(todo);
            todolistEntities.SaveChanges();
            //throw new NotImplementedException();
        }

        public void updateTodo(todo todo)
        {
            todolistEntities.Entry(todo).State =  System.Data.Entity.EntityState.Modified;
            todolistEntities.SaveChanges();
           // var todoUpdate = new todo(); //back here
           // throw new NotImplementedException();
        }
    }
}