using System;

namespace Mentorship.Grid.DataAccess.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
}
}
