using System.Collections.Generic;
using ApiRPG.Models;

namespace ApiRPG.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();

         Character GetCharacterById(int id);

         List<Character> AddCharacter(Character newCharacter);
    }
}