using ContactManagement.ContactModule.Command;
using ContactManagement.ContactModule.Query;
using ContactManagement.Persistence.Interfaces;
using ContactManagement.Persistence.Models;
using MediatR;

namespace ContactManagement.ContactModule.Handler
{
    public class UpdateContactHandler : IRequestHandler<UpdateContactCommand, bool>
    {
        private readonly IContactRepository _contactRepository;
        public UpdateContactHandler(IContactRepository contactRepo)
        {
            this._contactRepository = contactRepo;
        }

        public async Task<bool> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(async () =>
            {
                return await _contactRepository.UpdateContact(request.Contact);
            });
        }
    }
}
