using ContactManagement.Persistence.Models;
using MediatR;

namespace ContactManagement.ContactModule.Command
{
    public class UpdateContactCommand : IRequest<bool>
    {
        public UpdateContactCommand(Contact contact)
        {
            Contact = contact;
        }

        public Contact Contact { get; set; }
    }
}
