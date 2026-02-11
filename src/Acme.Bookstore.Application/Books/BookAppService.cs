using Acme.Bookstore.Books;
using Acme.Bookstore.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = BookstorePermissions.Books.Default;
        GetListPolicyName = BookstorePermissions.Books.Default;
        CreatePolicyName = BookstorePermissions.Books.Create;
        UpdatePolicyName = BookstorePermissions.Books.Edit;
        DeletePolicyName = BookstorePermissions.Books.Delete;
    }
}
