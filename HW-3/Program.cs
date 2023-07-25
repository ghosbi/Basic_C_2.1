

namespace HW_3
{
    class Program 
    {
        static void Main(string[] args)
        {

        }
    }
    abstract class Delivery
    {
        public string Address;
    }

    class Buyer
    {
        private string Name;
        private string LastName;
        public string Home_Address;

        public enum DelivType
        { 
            Home = 0,
            Shop,
            PickPoint
        }

        private HomeDelivery homeDelivery;
        private PickPointDelivery pickPointDelivery;
        private ShopDelivery shopDelivery;
        public Buyer(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        Product[] product_list = new Product[10];
        public void AddToCart(Product product) // Добавить в корзину
        {
            for (int i = 0; i < product_list.Length; i++)
            {
                if (product_list[i] is null)
                {
                    product_list[i] = product;
                    return;
                }
            }
        }
        public void RemoveFromCart(Product product) // Удалить из корзины
        {
            for (int i = product_list.Length - 1; i >= 0; i--)
            {
                if (product_list[i] == product)
                {
                    product_list[i] = null;
                    return;
                }
            }
        }
        public void ShowOrder() //Показать список заказов
        {
            Console.WriteLine($"{Name} {LastName} заказл");
            for (int i = 0; i < product_list.Length; i++)
            {
                if (product_list[i] is not null)
                {
                    Console.WriteLine(product_list[i].ProductName);
                }
            }
        }

        public void CreateOrder<TDelivery>(string address, DelivType delivType) where TDelivery : Delivery
        {

        }

    }

    class Product
    {
        public string ProductName;
        string ProductID;
        public Product(string productname)
        {
            ProductName = productname;
        }
    }
    class Deliveryman
    {
        string Name;
        public Deliveryman(string name)
        {
            Name = name;
        }
    }

    class HomeDelivery : Delivery // Доставка домой
    {
        
    }

    class PickPointDelivery : Delivery // Доставка в пункт выдачи
    {
        /* ... */
    }

    class ShopDelivery : Delivery // Доставка в магазин
    {
        /* ... */
    }

    class Order<TDelivery,
    TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }
}
