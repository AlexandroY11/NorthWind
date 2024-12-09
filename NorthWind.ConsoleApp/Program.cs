using NorthWind.Writers;

IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application Started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azúcar Refinada");  