using Acme.Bookstore.Authors;
using Xunit;

namespace Acme.Bookstore.EntityFrameworkCore.Applications.Authors;

[Collection(BookstoreTestConsts.CollectionDefinitionName)]
public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookstoreEntityFrameworkCoreTestModule>
{

}
