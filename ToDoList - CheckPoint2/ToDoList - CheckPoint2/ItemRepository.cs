using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace ToDoList___CheckPoint2
{
    public class ItemRepository
    {
        ItemContext context;
        public ItemRepository();
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }
    }
   public List<ToDoItem> GetToDoItems()
    {
        IEnumerable<ToDoItem> list = context.ToDoItems;
    return list.ToList();
    }
public void AddItem(string description, string status, DateTime dueDate)
    {
    ToDoItem item = new ToDoItem(description, status, dueDate);
    context.ToDoItems.Add(item);
    context.SaveChanges();
    }
public void UpdateItem(int id, string newDescription, string newStatus, DateTime newDueDate)
{
    TodoItem oldItem = context.ToDoItems.Where(item => item Id == id).FirstOrDefault();

    oldItem.Description = newDescription;
    oldItem.Status = newStatus;
    oldItem.DueDate = newDueDate;
    context.Update(oldItem);
    context.SaveChanges();
}

public void DeleteItem(int id)
{
    TodoItem oldItem = context.ToDoItems.Where(item => item Id == id).FirstOrDefault();
    context.ToDoItems.Remove(oldItem);
    context.SaveChanges();
}
}
