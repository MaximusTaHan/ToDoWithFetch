namespace ToDoWithFetch
{
    public class DuplicateUserInputException : Exception
    {
        public DuplicateUserInputException()
        {
        }

        public DuplicateUserInputException(string message)
            : base(message)
        {
        }

        public DuplicateUserInputException(string message, Exception input)
            : base(message, input)
        {
        }
    }
}
