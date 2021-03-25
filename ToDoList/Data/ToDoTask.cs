using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data;

namespace TodoList.Data
{
    public class ToDoTask
    {
        private string title;
        
        public string Id { get; set; }
        
        public string IdList { get; set; }
        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                ToDoTaskService.UpdateToDoTaskInList(toGoogleTask(), IdList);
            }
        }
        public string Status { get; set; }

        public ToDoTask()
        {

        }
        public ToDoTask(string Id, string IdList, string Title, string Status)
        {
            this.Id = Id;
            this.IdList = IdList;
            this.title = Title;
            this.Status = Status;
        }

        public Google.Apis.Tasks.v1.Data.Task toGoogleTask()
        {
            Google.Apis.Tasks.v1.Data.Task updatedTask = new Google.Apis.Tasks.v1.Data.Task();
            updatedTask.Title = Title;
            updatedTask.Id = Id;

            return updatedTask;
        }


    }
}
