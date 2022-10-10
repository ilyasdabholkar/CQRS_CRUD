using ContactManagement.Persistence.Models;
using MediatR;

namespace ContactManagement.ContactModule.Command
{
    public class DeleteContactCommand : IRequest<bool>
    {
        public DeleteContactCommand(Contact contact)
        {
            Contact = contact;
        }

        public Contact Contact { get; set; }
    }
}
