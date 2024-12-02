using users.Models;

namespace users.Repositoreis
{
    public interface ITasksRepositoreis
    {
        void Add(Models.Task task);

        void logIntoDB(string message);
    }
}
