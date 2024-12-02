using users.Repositoreis;
using TasksApi.Services.Logger;

namespace ex2.Services.Logger
{
    public class DBLoggerService: ILoggerService
    {
        private readonly ITasksRepositoreis _TasksRepository;
        public DBLoggerService(ITasksRepositoreis tasksRepository)
        {
            _TasksRepository = tasksRepository;
        }

        public void Log(string message)
        {
            try
            {
                _TasksRepository.logIntoDB(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"failed to log message: {ex.Message}");
            }
        }
    }
}
