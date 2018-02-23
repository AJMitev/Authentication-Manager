namespace AuthenticationManager.Common
{
    public static class StudentIdentityGenerator
    {
        private static ulong _currentStudentId = 100000;
        public  static ulong GenerateStudentNumber()
        {
            return ++_currentStudentId;
        }
    }
}
