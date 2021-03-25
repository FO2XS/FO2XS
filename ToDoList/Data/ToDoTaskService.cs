using System;
using System.Linq;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Tasks.v1;
using Google.Apis.Tasks.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace TodoList.Data
{
    public class ToDoTaskService
    {
        static string[] Scopes = { TasksService.Scope.Tasks };
        static string ApplicationName = "Google Tasks API .NET Quickstart";
        static TasksService service;
        ///<summary>
        ///Получает List со всеми списками задач
        ///</summary>
        public List<ToDoTaskList> GetToDoTaskLists()
        {
            //UserCredential - исп. для интегрированный аутентификации на уд. машинах
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
            
            // Create Google Tasks API service.
            service = new TasksService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            TasklistsResource.ListRequest listRequest = service.Tasklists.List();
            listRequest.MaxResults = 20;

            // List task lists.
            List<TaskList> taskLists = listRequest.Execute().Items.ToList();
            //Здесь нужно сделать преобразование к нашему формату файлов

            //Task<ToDoTask>[] Tasks = new Task<ToDoTask>();
            if (taskLists != null && taskLists.Count > 0)
            {
                List<ToDoTaskList> toDoTaskLists = new List<ToDoTaskList>();
                foreach(var temp in taskLists)
                {
                    toDoTaskLists.Add(new ToDoTaskList(temp.Id, temp.Title));
                }
                return toDoTaskLists;
            }
            else
            {
                //По хорошему бы добавить что-то получше чем null
                return null;
            }
        }
        ///<summary>
        ///Получает List со всеми задачами из указанного списка
        ///</summary>
        public List<ToDoTask> GetToDoTasksInListAsync(string idList)
        {
            List<ToDoTask> toDoTasks = new List<ToDoTask>();
            IList<Google.Apis.Tasks.v1.Data.Task> taskList = service.Tasks.List(idList).Execute().Items;

            if (taskList != null)
            {
                foreach (Google.Apis.Tasks.v1.Data.Task temp in taskList)
                {
                    toDoTasks.Add(new ToDoTask(temp.Id, idList, temp.Title, temp.Status));
                }
                return toDoTasks;
            }
            else return null;
        }

        ///<summary>
        ///Обновляет измененный таск в указанном списке
        ///</summary>
        public static void UpdateToDoTaskInList(Google.Apis.Tasks.v1.Data.Task updatedTask, string idList)
        {
            try
            {
                service.Tasks.Update(updatedTask,
                    idList,
                    updatedTask.Id).Execute();
            }
            catch
            {

            }
        }

        public static void UpdateToDoTaskList(Google.Apis.Tasks.v1.Data.TaskList updatedList){
            try{
                service.Tasklists.Update(updatedList, updatedList.Id).Execute();
            }
            catch{

            }
        }

        public void DeleteTaskFromList(string idlist, string idtask)
        {
            service.Tasks.Delete(idlist, idtask).Execute();
        }

        public void DeleteTaskList(string idlist){
            service.Tasklists.Delete(idlist).Execute();
        }

        public void AddNewTaskInList(ToDoTaskList list, string title){
            Google.Apis.Tasks.v1.Data.Task newTask = new Google.Apis.Tasks.v1.Data.Task(){
                Title = title
            };
            service.Tasks.Insert(newTask, list.Id).Execute();
        }

        public void AddNewListTask(string title){
            Google.Apis.Tasks.v1.Data.TaskList newList= new Google.Apis.Tasks.v1.Data.TaskList(){
                Title = title
            };
            service.Tasklists.Insert(newList).Execute();
        }
    }
}