using Book_Project.Consts;

namespace Book_Project.Exceptions;
public class AuthorNameException : Exception
{
    public AuthorNameException(string authorName) : base(Messages.AuthorNameException(authorName)) 
    { 
    
    }

}
