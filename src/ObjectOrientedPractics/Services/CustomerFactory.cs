using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс создает шаблон для заполнения информации о покупателе.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о покупателе.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о покупателе.</returns>
        public static Customer DefaultCustomer()
        {
            Customer customer = new Customer();
            customer.FullName = "Full name";
            Address address = new Address();
            address.Street = "Street";
            address.City = "City";
            address.Country = "Country";
            address.Apartment = "Apartment";
            address.Building = "Building";
            address.Index = 100000;
            customer.Address = address;

            return customer;
        }
    }
}