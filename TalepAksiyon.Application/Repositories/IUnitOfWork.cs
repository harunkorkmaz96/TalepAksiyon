using TalepAksiyon.Domain.DTOModels.SecurityModels;

namespace TalepAksiyon.Application.Repositories;

public interface IUnitOfWork
{
  //IRepository Repository { get; }
  //ICustomerRepository CustomerRepository { get; }
  //IUserRepository UserRepository { get; }
  IProjectRepository ProjectRepository { get; }
  //IProjectNoteRepository ProjectNoteRepository { get; }
  IRequestRepository RequestRepository { get; }
  //ITaskRepository TaskRepository { get; }
  //IActionRepository ActionRepository { get; }
  //IHomeRepository HomeRepository { get; }
  //IModuleRepository ModuleRepository { get; }
  //IVersionRepository VersionRepository { get; }
  
  //Task<int> SaveChanges();
  //SessionModel GetSession();
}
