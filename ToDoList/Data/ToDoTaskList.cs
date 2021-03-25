using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data
{
    public class ToDoTaskList
    {
        private string title;
        public string Id { get; set; }
        public string Title {
            get{
                return title;
            }
            set{
                title = value;
                ToDoTaskService.UpdateToDoTaskList(toGoogleTaskList());
            }
        }

        public ToDoTaskList(){

        }
        public ToDoTaskList(string id, string title){
            Id = id;
            this.title = title;
        }
        private Google.Apis.Tasks.v1.Data.TaskList toGoogleTaskList()
        {
            Google.Apis.Tasks.v1.Data.TaskList updatedList = new Google.Apis.Tasks.v1.Data.TaskList();
            updatedList.Title = Title;
            updatedList.Id = Id;

            return updatedList;
        }
    }
}
