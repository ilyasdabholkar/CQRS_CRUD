using ContactManagement.ContactModule.Query;
using ContactManagement.Persistence.Interfaces;
using ContactManagement.Persistence.Models;
using MediatR;
using System.Runtime.ConstrainedExecution;

namespace ContactManagement.ContactModule.Handler
{
    public class GetContactHandler : IRequestHandler<GetContactQuery, Contact>
    {
        private readonly IContactRepository _contactRepository;
        public GetContactHandler(IContactRepository contactRepo)
        {
            this._contactRepository = contactRepo;
        }

        public async Task<Contact> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                return _contactRepository.GetContactById(request.Id);
            });
        }
    }
}
