namespace BuberBreakfast.Contracts;

public record GetBreakfastReesponse(
    Guid id,
    string Name,
    string Description,
    DateTime startDateTime,
    DateTime endDateTime,
    DateTime lastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
);