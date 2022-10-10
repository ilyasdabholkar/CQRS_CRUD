using ContactManagement.Persistence.Models;
using MediatR;

namespace ContactManagement.ContactModule.Command
{
    public class CreateNewContactCommand : IRequest<bool>
    {
        public CreateNewContactCommand(Contact contact)
        {
            Contact = contact;
        }

        public Contact Contact { get; set; }
    }
}
