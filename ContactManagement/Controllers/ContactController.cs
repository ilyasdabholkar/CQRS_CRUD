using ContactManagement.ContactModule.Command;
using ContactManagement.ContactModule.Query;
using ContactManagement.Persistence.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.Controllers
{
    public class ContactController : Controller
    {

        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Contact> contacts = await _mediator.Send(new GetAllContactsQuery());
            return View(contacts);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            await _mediator.Send(new CreateNewContactCommand(contact));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Contact contact = await _mediator.Send(new GetContactQuery(id));
            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Contact contact)
        {
            bool updated = await _mediator.Send(new UpdateContactCommand(contact));
            if (updated)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Contact contact = await _mediator.Send(new GetContactQuery(id));
            bool deleted = await _mediator.Send(new DeleteContactCommand(contact));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Contact contact = await _mediator.Send(new GetContactQuery(id));
            return View(contact);
        }


    }
}
