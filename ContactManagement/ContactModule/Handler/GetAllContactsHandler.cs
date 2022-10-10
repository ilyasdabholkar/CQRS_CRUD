using ContactManagement.ContactModule.Query;
using ContactManagement.Persistence.Interfaces;
using ContactManagement.Persistence.Models;
using MediatR;

namespace ContactManagement.ContactModule.Handler
{
    public class GetAllContactsHandler : IRequestHandler<GetAllContactsQuery, List<Contact>>
    {

        private readonly IContactRepository _contactRepository;
        public GetAllContactsHandler(IContactRepository contactRepo)
        {
            this._contactRepository = contactRepo;
        }

        public async Task<List<Contact>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                return _contactRepository.GetAllContacts();
            });
        }
    }
}
