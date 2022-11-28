using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class User:IEntities

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
