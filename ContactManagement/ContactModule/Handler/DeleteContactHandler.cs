using ContactManagement.ContactModule.Command;
using ContactManagement.Persistence.Interfaces;
using MediatR;

namespace ContactManagement.ContactModule.Handler
{
    public class DeleteContactHandler : IRequestHandler<DeleteContactCommand, bool>
    {
        private readonly IContactRepository _contactRepository;
        public DeleteContactHandler(IContactRepository contactRepo)
        {
            this._contactRepository = contactRepo;
        }

        public async Task<bool> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(async () =>
            {
                return await _contactRepository.DeleteContact(request.Contact);
            });
        }
    }
}
