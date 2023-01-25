#region Strategy Pattern

//using DesignPatterns.StrategyPattern;
//using DesignPatterns.StrategyPattern.Implementations;

//Duck decoyDuck = new DecoyDuck();
//Duck rubberDuck = new RubberDuck();

////decoyDuck.PerformQuack();
//rubberDuck.PerformQuack();

//rubberDuck.quackBehavior = new QuackBehavior();

//rubberDuck.PerformQuack();

#endregion

#region Observer Pattern

//using DesignPatterns.ObserverPattern;
//using DesignPatterns.ObserverPattern.Displays;

//var weatherData = new WeatherData();

//var current = new CurrentConditions(weatherData);
//var forecast = new Forecast(weatherData);

//weatherData.ChangeWeatherData(new(25 , 60 , 8));

//Console.WriteLine("-----------------------------------");

//current.RemoveMe(weatherData);
//weatherData.ChangeWeatherData(new(19 , 18 , 20));


#endregion

#region Decorator Pattern

//using DesignPatterns.DecoratorPattern;
//using DesignPatterns.DecoratorPattern.Beverages;
//using DesignPatterns.DecoratorPattern.Condiments;

//Beverage b1 = new Espresso();
//b1 = new Mocha(b1);

//Console.WriteLine(b1.GetDescribtion() + " = " + b1.GetCost() + "$");

//Beverage b2 = new Latte();
////callback hell
//b2 = new Whip(b2);
//b2 = new Mocha(b2);
//b2 = new Mocha(b2);
//b2 = new Mocha(b2);
//b2 = new Mocha(b2);
//b2 = new Mocha(b2);


//Console.WriteLine(b2.GetDescribtion() + " = " + b2.GetCost() + "$");

#endregion

#region Factory Pattern

//using DesignPatterns.FactoryPattern;
//using DesignPatterns.FactoryPattern.Stores;

//PizzaStore nyPizzaStore = new NYPizzaStore();
//nyPizzaStore.OrderPizza("cheese");

//Console.WriteLine("--------------------------");

//PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
//chicagoPizzaStore.OrderPizza("cheese");

#endregion

#region Singleton Pattern

//using DesignPatterns.SingletonPattern;

//ChocolateBoiler boiler = ChocolateBoiler.getInstance();

#endregion

#region Command Pattern

//using DesignPatterns.CommandPattern;
//using DesignPatterns.CommandPattern.Devices;
//using DesignPatterns.CommandPattern.Commands;
//using DesignPatterns;

//var remote = new RemoteControl();
//var light = new Light();
//var garageDoor = new GarageDoor();

//remote.SetCommand(0 , new LightOnCommand(light) , new LightOffCommand(light));
//remote.SetCommand(3 , new RaiseGarageDoorCommand(garageDoor) , new LowerGarageDoorCommand(garageDoor));

//remote.PressOnButton(0);
//remote.PressOffButton(3);
//remote.Undo();

//Console.WriteLine(remote);

#endregion

#region Adapter Pattern

//using DesignPatterns.AdapterPattern.Interfaces;
//using DesignPatterns.AdapterPattern.Birds;
//using DesignPatterns.AdapterPattern.Adapters;

//var duck = new MallardDuck();
//var turkery = new WildTurkery();
//var adapter = new TurkeryAdapter(turkery);

//duck.Fly();
//duck.Quack();
//Console.WriteLine("--------------");

//turkery.Fly();
//turkery.Gobble();
//Console.WriteLine("--------------");

//test(adapter);

//void test(IDuck duck)
//{
//    duck.Fly();
//    duck.Quack();
//};

#endregion

#region Facade Pattern

//using DesignPatterns.FacadePattern;
//using DesignPatterns.FacadePattern.SubSystem;

//var facadeTheater = new FacadeTheater(new PopToaster() , new DVD() , new CDPlayer());
//facadeTheater.PlayMovie("Lord of the rings");

#endregion

#region Template Pattern

//using DesignPatterns.TemplatePattern.Drinks;
//var tea = new Tea();
//tea.PrepareRecipe();

//Console.WriteLine("-----------------------------");

//var coffee= new Coffee();
//coffee.PrepareRecipe();


#endregion

#region Iterator Pattern

//using DesignPatterns.IteratorPattern;
//using DesignPatterns.IteratorPattern.Menus.Cafe;
//using DesignPatterns.IteratorPattern.Menus.Diner;
//using DesignPatterns.IteratorPattern.Menus.PancakeHouse;

//var waitress = new Waitress(new PancakeHouseMenu() , new DinerMenu() , new CafeMenu());
//waitress.printMenu();

#endregion

#region Composite Pattern

//using DesignPatterns.CompositePattern;

//MenuComponent allMenus = new Menu("ALL MENUS" , "All menus combined");

//MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU" , "Breakfast");

//MenuComponent dinerMenu = new Menu("DINER MENU" , "Lunch");
//MenuComponent dessertMenu = new Menu("DESSERT MENU" , "Dessert of course!");

//MenuComponent cafeMenu = new Menu("CAFE MENU" , "Dinner");

//// add more menu items here
//dinerMenu.add(new MenuItem("Pasta" ,"Spaghetti with Marinara Sauce , and a slice of sourdough bread" ,true ,3.89));
//dessertMenu.add(new MenuItem("Apple Pie" ,"Apple pie with a flakey crust , topped with vanilla icecream" ,true ,1.59));
//dinerMenu.add(dessertMenu);

//// add menu items here
//allMenus.add(pancakeHouseMenu);
//allMenus.add(dinerMenu);
//allMenus.add(cafeMenu);

//Waitress waitress = new Waitress(allMenus);
//waitress.printMenu();


#endregion

#region Gankro

//using DesignPatterns.Gankro;
//using DesignPatterns.Gankro.Monsters;
//using DesignPatterns.Gankro.Spells;

//var spell1 = new Spell(new DollA());
//var spell2 = new Spell(new DollB());
//var spell3 = new Spell(new DollC());

//GankroBag gan = new GankroBag(spell1 , spell2 , spell3);

///*In Fight*/
//foreach (var spell in gan.spells)
//{
//    spell.UseSpell();
//}

#endregion

#region State Pattern

//using DesignPatterns.StatePattern;

//GumballMachine machine = new(5);

//Console.WriteLine(machine);
//Console.WriteLine("-----------------------------");

//machine.insertQuarter();
//machine.turnCrank();

//Console.WriteLine(machine);
//Console.WriteLine("-----------------------------");

//machine.insertQuarter();
//machine.ejectQuarter();
//machine.turnCrank();

//Console.WriteLine(machine);
//Console.WriteLine("-----------------------------");

//machine.insertQuarter();
//machine.turnCrank();
//machine.insertQuarter();
//machine.turnCrank();
//machine.ejectQuarter();

//Console.WriteLine(machine);
//Console.WriteLine("-----------------------------");

//machine.insertQuarter();
//machine.insertQuarter();
//machine.turnCrank();
//machine.insertQuarter();
//machine.turnCrank();
//machine.insertQuarter();
//machine.turnCrank();

//Console.WriteLine(machine);
//Console.WriteLine("-----------------------------");

#endregion

#region Proxy Pattern

#endregion

Console.ReadKey();
