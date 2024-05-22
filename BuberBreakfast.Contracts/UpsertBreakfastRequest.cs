namespace BuberBreakfast.Contracts;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime startDateTime,
    DateTime endDateTime,
    List<string> Savory,
    List<string> Sweet
);