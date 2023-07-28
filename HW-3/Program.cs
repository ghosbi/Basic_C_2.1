

namespace HW_3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Buyer Pavel = new Buyer("Pavel", "Konstantinov");
            Pavel.Home_Address = "Ekaterinburg";
            Pavel.AddToCart(new Product("Молоко"));
            Pavel.AddToCart(new Product("Кефир"));
            Pavel.AddToCart(new Product("Хлеб"));
            Pavel.AddToCart(new Product("Соль"));
            Pavel.CreateOrder<HomeDelivery>(Pavel.Home_Address, Buyer.DelivType.Shop);

            Buyer Katya = new Buyer("Ekaterina", "Zorina");
            Katya.Home_Address = "Ekaterinburg";
            Katya.AddToCart(new Product("Снежок"));
            Katya.AddToCart(new Product("Кефир"));
            Katya.AddToCart(new Product("Йогурт"));
            Katya.AddToCart(new Product("Сахар"));
            Katya.CreateOrder<HomeDelivery>(Pavel.Home_Address, Buyer.DelivType.Home);

            Buyer Sasha = new Buyer("Alexander", "Sushkin");
            Sasha.Home_Address = "Ekaterinburg";
            Sasha.AddToCart(new Product("Молоко"));
            Sasha.AddToCart(new Product("Кефир"));
            Sasha.AddToCart(new Product("Хлеб"));
            Sasha.CreateOrder<HomeDelivery>(Sasha.Home_Address, Buyer.DelivType.PickPoint);

            Employee German = new Employee("German", "Radikov");


        }
    }

    class Employee
    {
        public string Name;
        public string LastName;
        public Employee(string name) { Name = name; }
        public Employee(string name, string lastname) : this(name) { LastName = lastname; }
    }

    abstract class Delivery // Доставка
    {
        public string Address
        {
            get { return Address == null ? "Address is empty" : Address; }

            set
            {
                if (Address == null)
                {
                    Console.WriteLine("Адрес не указан!");

                }
                else Address = value;
            }
        }
    }

    class Buyer // Покупатель
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

        Product[] product_list = new Product[5];
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
            Console.WriteLine($"{Name} {LastName} заказл:");
            for (int i = 0; i < product_list.Length; i++)
            {
                if (product_list[i] is not null)
                {
                    Console.WriteLine(product_list[i].ProductName);
                }
            }
        }

        public void CreateOrder<TDelivery>(string address, DelivType delivType) where TDelivery : Delivery //Создание заказа
        {
            Order<TDelivery> order;
            ShowOrder();

            switch (delivType)
            {
                case DelivType.Home:
                    order = new Order<TDelivery>(new HomeDelivery() as TDelivery);
                    Console.WriteLine("Выбран пункт доставки ДОМОЙ");
                    break;
                case DelivType.PickPoint:
                    order = new Order<TDelivery>(new PickPointDelivery() as TDelivery);
                    Console.WriteLine("Выбран пункт доставки ПОСТАМАТ");
                    break;
                case DelivType.Shop:
                    order = new Order<TDelivery>(new ShopDelivery() as TDelivery);
                    Console.WriteLine("Выбран пункт доставки МАГАЗИН");
                    break;
                default:
                    Console.WriteLine("Не выбрана нужная доставка");
                    return;
                    
            }
            order.products = this.product_list;
            Console.WriteLine("Спасибо за заказ, ожидайте доставку \n");

        }

    }

    class Product
    {
        public string ProductName;
        string Product_description;
        public Product(string productname)
        {
            ProductName = productname;
        }
    } //Товар
    class Deliveryman :Employee// Курьер
    {
       public Deliveryman(string name): base(name) { } 
       public Deliveryman(string name, string lastname): base(name, lastname) { }
        
    } 

    class HomeDelivery : Delivery // Доставка домой
    {
        
    }

    class PickPointDelivery : Delivery // Доставка в пункт выдачи
    {
        
    }

    class ShopDelivery : Delivery // Доставка в магазин
    {
       
    }

    class Order<TDelivery> where TDelivery : Delivery //Заказ
    {
        public Order(TDelivery delivery)
        {
            Delivery = delivery;
        }
        private TDelivery Delivery;

        public int Number;

        public string Description;

        public Product[] products;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        
    }
}
