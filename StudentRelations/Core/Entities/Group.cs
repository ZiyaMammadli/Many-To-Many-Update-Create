using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRelations.Core.Entities;

public class Group
{
    public int Id { get; set; }
    
    public string Name { get; set; } = null!;
    public ICollection<GroupStudent> GroupStudents { get; set; } = null!;
}
