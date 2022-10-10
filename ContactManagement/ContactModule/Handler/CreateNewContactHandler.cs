

using ContactManagement.ContactModule.Command;
using ContactManagement.Persistence.Interfaces;
using MediatR;

namespace ContactManagement.ContactModule.Handler
{
    public class CreateNewContactHandler : IRequestHandler<CreateNewContactCommand, bool>
    {

        private readonly IContactRepository _contactRepository;
        public CreateNewContactHandler(IContactRepository contactRepo)
        {
            this._contactRepository = contactRepo;
        }

        public async Task<bool> Handle(CreateNewContactCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(async () =>
            {
                return await _contactRepository.CreateContact(request.Contact);
            });
        }
    }
}
