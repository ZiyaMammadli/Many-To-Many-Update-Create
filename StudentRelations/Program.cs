using Microsoft.EntityFrameworkCore;
using StudentRelations.Core.Entities;
using StudentRelations.DataAccess.Contexts;

SGRDbContext context = new SGRDbContext();

Console.WriteLine("Welcome our relations");

#region Create
List<GroupStudent> groupstudents = new List<GroupStudent>();
//Group group = new()
//{
//    Name = "p231",
//    GroupStudents = groupstudents
//};

//Student student = new()
//{
//    Name = "Vusal",
//    Age = 21,
//    GroupStudents = groupstudents
//};

//GroupStudent gs = new()
//{
//    GroupId =group.Id,
//    StudentId = student.Id,
//};

//groupstudents.Add(gs);
//await context.students.AddAsync(student);
//await context.groups.AddAsync(group);
//await context.SaveChangesAsync();
#endregion

#region Update

Student? student2 = await context.students.FindAsync(7);
if (student2 is not null)
{
    Group? group1 = await context.groups.FindAsync(1);
    if (group1 is not null)
    {

        GroupStudent gs1 = new ()
        {
            GroupId = group1.Id,
            StudentId=student2.Id
        };
        groupstudents.Add(gs1);
        await context.groupStudents.AddAsync(gs1);
        await context.SaveChangesAsync();
    }
    else
    {
        Console.WriteLine("Group Id is not found");
    }
}
else
{
    Console.WriteLine("Student Id is not found");
}

#endregion



