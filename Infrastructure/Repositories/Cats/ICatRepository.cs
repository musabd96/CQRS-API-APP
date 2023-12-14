﻿using Domain.Models;

namespace Infrastructure.Repositories.Cats
{
    public interface ICatRepository
    {
        Task<List<Cat>> GetAllCats(CancellationToken cancellationToken);
        Task<Cat> GetCatById(Guid id, CancellationToken cancellationToken);
        Task<Cat> AddCat(Cat newcat, CancellationToken cancellationToken);
        Task<Cat> UpdateCat(Guid id, string newName, bool likesToPlay, CancellationToken cancellationToken);
        Task<Cat> DeleteCat(Guid id, CancellationToken cancellationToken);
    }
}