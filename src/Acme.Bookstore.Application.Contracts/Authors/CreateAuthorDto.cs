using System;
using System.ComponentModel.DataAnnotations;
using Acme.BookStore.Authors;

namespace Acme.Bookstore.Authors;

public class CreateAuthorDto
{
    [Required]
    [StringLength(AuthorConsts.MaxNameLength)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public DateTime BirthDate { get; set; }

    public string? ShortBio { get; set; }
}
