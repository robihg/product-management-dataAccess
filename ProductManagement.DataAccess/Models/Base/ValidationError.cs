namespace ProductManagement.DataAccess.Models.Base
{
    public class ValidationError
    {
        public string Field { get; }
        public string Message { get; }

        public ValidationError(string message, string field = null)
        {
            Message = message;
            Field = field;
        }
    }
}
