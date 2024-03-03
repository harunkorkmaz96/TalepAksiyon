using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Application.Services.EmailService;
using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Persistance.TalepAksiyonContextes;
using TalepAksiyon.Application.Services.SecurityService;

namespace TalepAksiyon.Infasctructure.Repositories
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly TalepAksiyonContext context;
    private readonly IEmailService emailService;

    public UnitOfWork(TalepAksiyonContext _context, IEmailService _emailService)
    {
      context = _context;
      emailService = _emailService;
    }
    private IRepository _repository;
    public IRepository Repository => _repository ?? (_repository = new Repository(context));

    //private ICustomerRepository _customerRepository;
    //public ICustomerRepository CustomerRepository =>_customerRepository ?? (_customerRepository = new CustomerRepository(context, session, this));

    //private IUserRepository _userRepository;
    //public IUserRepository UserRepository => _userRepository ?? (_userRepository = new UserRepository(context, session, this));

    //private IProjectRepository _projectRepository;
    //public IProjectRepository ProjectRepository => _projectRepository ?? (_projectRepository = new ProjectRepository(context, session, this));

    //private IProjectNoteRepository _projectNoteRepository;
    //public IProjectNoteRepository ProjectNoteRepository => _projectNoteRepository ?? (_projectNoteRepository = new ProjectNoteRepository(context, session, this));

    private IRequestRepository _requestRepository;
    public IRequestRepository RequestRepository => _requestRepository ?? (_requestRepository = new RequestRepository(context));

    //private ITaskRepository _taskRepository;
    //public ITaskRepository TaskRepository => _taskRepository ?? (_taskRepository = new TaskRepository(context, session, this, emailService));

    //private IActionRepository _actionRepository;
    //public IActionRepository ActionRepository => _actionRepository ?? (_actionRepository = new ActionRepository(context, session, this));

    //private IHomeRepository _homeRepository;
    //public IHomeRepository HomeRepository => _homeRepository ?? (_homeRepository = new HomeRepository(context, session, this));

    //private IModuleRepository _moduleRepository;
    //public IModuleRepository ModuleRepository => _moduleRepository ?? (_moduleRepository = new ModuleRepository(context, session, this));

    //private IVersionRepository _versionRepository;
    //public IVersionRepository VersionRepository => _versionRepository ?? (_versionRepository = new VersionRepository(context, session, this));
  }
}
