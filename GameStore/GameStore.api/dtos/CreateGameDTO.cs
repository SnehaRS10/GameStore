using System.ComponentModel.DataAnnotations;

namespace GameStore.api.dtos;

public record class CreateGameDTO(
    [Required] [StringLength(50)]string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);
