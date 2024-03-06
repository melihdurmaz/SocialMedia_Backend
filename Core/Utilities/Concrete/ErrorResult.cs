namespace Core.Utilities.Concrete
{
    public class ErrorResult:Result 
    {
        public ErrorResult():base(false) 
        {
        }
        public ErrorResult(String message):base (false,message)
        {
            
        }
    }
}
