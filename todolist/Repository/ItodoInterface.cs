using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todolist.Models;

namespace todolist.Repository
{
    interface ItodoInterface
    {
        todo getTodoById(int todoId);
        void insertTodo(todo todo);
        void updateTodo(todo todo);
        void deleteTodo(int todoId);

        IEnumerable<todo> getTodos();
    }
}
