using MyErp.Business.Repositories;
using MyErp.DAL;
using MyErp.PrintServices.Services;

namespace MyErp.Application;

static class Program
{
    static void Main(string[] args)
    {
        CustomerRepository customerRepository = new CustomerRepository();
        OrderRepository orderRepository = new OrderRepository();
        PrintService printService = new PrintService();

        Customer customer1 = new Customer
        {
            Name = "Vangelis",
            Surname = "Tsiatouras",
            PhoneNumber = "6981111111",
            Address = "Kifisias 1"
        };

        Order order1 = new Order
        {
            Id = "12415414-313123131",
            Customer = customer1
        };
        
        Customer customer2 = new Customer
        {
            Name = "Alice",
            Surname = "Dummy",
            PhoneNumber = "6982222222",
            Address = "Kifisias 2"
        };

        Order order2 = new Order
        {
            Id = "12415414-590940923490",
            Customer = customer2
        };
        
        Customer customer3 = new Customer
        {
            Name = "Bob",
            Surname = "Dummy",
            PhoneNumber = "6983333333",
            Address = "Kifisias 3"
        };

        Order order3 = new Order
        {
            Id = "12415414-5435543",
            Customer = customer3
        };
        
        Customer customer4 = new Customer
        {
            Name = "Charlie",
            Surname = "Dummy",
            PhoneNumber = "6984444444",
            Address = "Kifisias 4"
        };

        Order order4 = new Order
        {
            Id = "12415414-675464654654",
            Customer = customer4
        };
        
        Customer customer5 = new Customer
        {
            Name = "Dennis",
            Surname = "Dummy",
            PhoneNumber = "6985555555",
            Address = "Kifisias 5"
        };

        Order order5 = new Order
        {
            Id = "12415414-54546436436436",
            Customer = customer5
        };

        customerRepository.Create(customer1);
        customerRepository.Create(customer2);
        customerRepository.Create(customer3);
        customerRepository.Create(customer4);
        customerRepository.Create(customer5);
        
        orderRepository.Create(order1);
        orderRepository.Create(order2);
        orderRepository.Create(order3);
        orderRepository.Create(order4);
        orderRepository.Create(order5);

        List<Customer> customers = customerRepository.GetAll();
        List<Order> orders = orderRepository.GetAll();

        printService.Print(customers[0]);
        printService.Print(orders[0]);
    }
}
