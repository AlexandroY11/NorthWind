IUserActionWriter Writer = default;

AppLogger Logger = new AppLogger(Writer);

Logger.WriteLog("Application Started.");