namespace AuthenticationManager.Models.Contracts
{
    using System.Collections.Generic;

    public interface ICourse
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}