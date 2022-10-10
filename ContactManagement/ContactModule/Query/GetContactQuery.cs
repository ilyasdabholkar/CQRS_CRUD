using ContactManagement.Persistence.Models;
using MediatR;

namespace ContactManagement.ContactModule.Query
{
    public class GetContactQuery : IRequest<Contact>
    {
        public GetContactQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
