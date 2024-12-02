using TasksApi.Services.Logger;
using users.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace users.Repositoreis
{
    public class TasksRepositoreis : ITasksRepositoreis
    {
        private readonly UsersContext _context;
        private string _filePath = "tasks.json";
        private readonly TasksApi.Services.Logger.LoggerFactory _LoggerFactory;
        private ILoggerService _logger;

        public TasksRepositoreis(UsersContext context, TasksApi.Services.Logger.LoggerFactory loggerFactory)
        {
            _context = context;
            _LoggerFactory = loggerFactory;
        }

        public void Add(Models.Task task)
        {
            _context.Tasks.Add(task);
            _logger = _LoggerFactory.GetLogger(2);
            _logger.Log("new task created succesfuly");
            _context.SaveChanges();
        }

        public void logIntoDB(string message)
        {
            Change newMassage = new Change();
            newMassage.Discription = message;
            newMassage.Date = DateOnly.FromDateTime(DateTime.Now);
            _context.Changes.Add(newMassage);
            _context.SaveChanges();
        }
    }
}
