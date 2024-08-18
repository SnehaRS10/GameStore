using System;
using GameStore.api.dtos;
using GameStore.api.Entities;

namespace GameStore.api.Mapping;

public static class GenreMapping
{
    public static GenreDTO ToDto(this Genre genre){
        return new GenreDTO(genre.Id, genre.Name);
    }
}
