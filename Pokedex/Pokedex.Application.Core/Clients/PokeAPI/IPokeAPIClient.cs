﻿using Pokedex.Application.Core.Clients.PokeAPI.Models;
using Refit;
using System.Threading.Tasks;

namespace Pokedex.Application.Core.Clients.PokeAPI
{
    public interface IPokeAPIClient
    {
        [Get("/pokemon-species/{name}")]
        public Task<ApiResponse<Pokemon>> GetSpeciesAsync(string name);
    }
}
