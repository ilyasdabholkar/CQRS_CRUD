using MediatR;
using ContactManagement.Persistence.Models;

namespace ContactManagement.ContactModule.Query
{
    public class GetAllContactsQuery : IRequest<List<Contact>>
    {
    }
}
