namespace MovieStore.API.Dtos.Request.CustomerRequest
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}