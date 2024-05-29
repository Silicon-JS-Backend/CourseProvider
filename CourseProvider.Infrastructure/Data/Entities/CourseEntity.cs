using System.ComponentModel.DataAnnotations;

namespace CourseProvider.Infrastructure.Data.Entities;

public class CourseEntity
{
    [Key]

    public string Id { get; set; } = Guid.NewGuid().ToString();
}
