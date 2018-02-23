namespace AuthenticationManager.Models.Contracts
{
    public interface ITeacher : IUser
    {
        string Faculty { get; set; }
         ICourse Course { get; set; }
    }
}