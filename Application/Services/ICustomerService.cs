namespace ELDOKKAN.Application.Services;
public interface ICustomerService
{
    GetAllCustomerDTO GetCustomerById(int customerId);
    IEnumerable<GetAllCustomerDTO> GetAllCustomers();
    GetAllCustomerDTO AddCustomer(CreateCustomerDTO createCustomerDto);
    bool UpdateCustomer(int customerId, UpdateCustomerDTO updateCustomerDto);
    bool DeleteCustomer(int customerId);
} 