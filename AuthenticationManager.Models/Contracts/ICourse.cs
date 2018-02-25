namespace AuthenticationManager.Models.Contracts
{
    using System.Collections.Generic;

    public interface ICourse
    {
        int Id { get;  }
        string Name { get;  }
        ICollection<IStudent> Students { get; }
    }
}