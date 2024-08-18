namespace GameStore.api.dtos;

public record class UpdateGameDTO(
    string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);
