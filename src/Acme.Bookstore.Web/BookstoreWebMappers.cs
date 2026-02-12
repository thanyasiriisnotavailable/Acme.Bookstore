using Acme.Bookstore.Authors;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;
using static Acme.Bookstore.Web.Pages.Authors.EditModalModel;

namespace Acme.Bookstore.Web;

/*
 * You can add your own mappings here.
 * [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
 * public partial class BookstoreWebMappers : MapperBase<BookDto, CreateUpdateBookDto>
 * {
 *    public override partial CreateUpdateBookDto Map(BookDto source);
 * 
 *    public override partial void Map(BookDto source, CreateUpdateBookDto destination);
 * }
 */

[Mapper]
public partial class CreateAuthorViewModelToCreateAuthorDtoMapper : MapperBase<Pages.Authors.CreateModalModel.CreateAuthorViewModel, CreateAuthorDto>
{
    public override partial CreateAuthorDto Map(Pages.Authors.CreateModalModel.CreateAuthorViewModel source);
    public override partial void Map(Pages.Authors.CreateModalModel.CreateAuthorViewModel source, CreateAuthorDto destination);
}

[Mapper]
public partial class AuthorDtoToEditAuthorViewModelMapper : MapperBase<AuthorDto, EditAuthorViewModel>
{
    public override partial EditAuthorViewModel Map(AuthorDto source);

    public override partial void Map(AuthorDto source, EditAuthorViewModel destination);
}

[Mapper]
public partial class EditAuthorViewModelToUpdateAuthorDtoMapper : MapperBase<Pages.Authors.EditModalModel.EditAuthorViewModel, UpdateAuthorDto>
{
    public override partial UpdateAuthorDto Map(Pages.Authors.EditModalModel.EditAuthorViewModel source);
    public override partial void Map(Pages.Authors.EditModalModel.EditAuthorViewModel source, UpdateAuthorDto destination);
}
