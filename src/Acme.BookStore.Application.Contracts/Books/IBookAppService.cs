

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books;

public interface IBookAppService:ICrudAppService<BookDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBookDto>
{
    
}