using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEndDemo
{
    class GamerManager : IGamerService
    {
        private readonly IUserValidationService _service;

        public GamerManager(IUserValidationService service)
        {
            _service = service;
        }
        public void Add(Gamer gamer)
        {
            if (_service.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName  + " " + gamer.IdentityNumber + " gamer added");
            }
            else
            {
                throw new Exception("user error");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " gamer updated");

        }
    }
}
