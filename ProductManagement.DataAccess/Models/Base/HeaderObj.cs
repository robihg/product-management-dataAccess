
namespace ProductManagement.DataAccess.Models.Base
{
    public class HeaderObj
    {
        public string ResponseTime { get; set; }

        public string StatusCode { get; set; }

        public string Message { get; set; }

        public List<ValidationError> ErrorMessages { get; set; }

        public HeaderObj()
        {
            StatusCode = "200";
            Message = "Success";
            ErrorMessages = null;
        }
    }
}
