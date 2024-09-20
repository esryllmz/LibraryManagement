namespace LibraryManagement.ConsoleUI.Models;

public record Book(

    int Id,
    int CategoryId,
    int AuthorId,
    string Title,
    string Description,
    int PageSize,
    string PublishDate,
    string ISBN)
{ }


