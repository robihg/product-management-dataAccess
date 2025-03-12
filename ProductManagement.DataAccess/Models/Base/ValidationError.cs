namespace ProductManagement.DataAccess.Models.Base
{
    public class ValidationError
    {
        public string Field { get; set; } 
        public string Message { get; set; }  

        public ValidationError(string message, string field = null)
        {
            Message = message;
            Field = field;
        }
    }
}
