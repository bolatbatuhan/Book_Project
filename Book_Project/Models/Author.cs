using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project.Models;

public class Author : EntityBase<int>
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Yazar ID : {Id}, Yazar adi : {Name}";
    }
}
