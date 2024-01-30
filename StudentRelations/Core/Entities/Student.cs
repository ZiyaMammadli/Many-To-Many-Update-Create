using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRelations.Core.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public ICollection<GroupStudent> GroupStudents { get; set; } = null!;
}
