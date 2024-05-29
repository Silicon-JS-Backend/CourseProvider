using CourseProvider.Infrastructure.Data.Entities;
using CourseProvider.Infrastructure.Models;

namespace CourseProvider.Infrastructure.Factories;

public static class CourseFactory
{
    public static Course Create(CourseEntity entity)
    {
        return new Course
        {
            Id = entity.Id
        };
    }
}
