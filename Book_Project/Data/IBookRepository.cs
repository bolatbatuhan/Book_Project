using Book_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project.Data;

public interface IBookRepository :IEntityRepository<Book,int>
{
   public Book GetByIsbn(string isbn);
}
