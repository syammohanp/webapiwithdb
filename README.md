Install Globally:
dotnet tool install -g dotnet-ef 
dotnet tool uninstall -g  dotnet-ef
dotnet tool uninstall -global  dotnet-ef --version <version no>
dotnet tool uninstall -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
Install in the Project:
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet aspnet-codegenerator controller -name ValuesController -async -api --readWriteActions -outDir Controllers
Dotnet:
dotnet new webapi -n sampleproj
dotnet build
dotnet run
dotnet watch run
Git Init
git init
git add .
git commit -m "initial commit"
git remote add origin <repo url>
git remote -v
git push -f origin master

Employee emp = listEmployees.Find(delegate(Employee emp) {return emp.id == 102; });
Employee emp = listEmployees.Find(x => x.id == 102);
Employee emp = listEmployees.Find((Employee emp) => emp.id == 102);
Button1.click += delegate { MessageBox.show("Button Clicked");};
Button1.click += (eventSender, eventArgs) => {
    MessageBox("button clicked)
};