﻿using System;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.Interfaces.Repositories {
    public interface IEditorRepository {
        Task<bool> UpdateJsonBeatsAsync(string jsonBeats, Guid id, Guid userId);
        Task<Dmo> LoadShortDmoAsync(Guid id, Guid userId);
        Task<Dmo> LoadDmoAsync(Guid id, Guid userId);
        Task<bool> CreateDmoAsync(Dmo dmo);
        Task<bool> UpdateShortDmoAsync(Dmo dmo);
    }
}
