using Microsoft.AspNetCore.Builder;
using Acme.Bookstore;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Acme.Bookstore.Web.csproj"); 
await builder.RunAbpModuleAsync<BookstoreWebTestModule>(applicationName: "Acme.Bookstore.Web");

public partial class Program
{
}
