using users.Models;

namespace users.Repositoreis
{
    public class TasksRepositoreis : ITasksRepositoreis
    {
        private readonly UsersContext _context;

        public TasksRepositoreis(UsersContext context)
        {
            _context = context;
        }

        public void Add(Models.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
    }
}
