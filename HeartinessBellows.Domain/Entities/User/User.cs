using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartinessBellows.Domain.Entities.User
{
    public sealed class User : BaseEntity
    {
        public User(Guid id) : base(id)
        {
        }
        public string Username { get; private set; }
        public bool Sex { get; private set; }
        public DateOnly Birtday { get; private set; }
    }
}
