using L20240408.EntidadesDeNegocios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20240408.AccesoADatos
{
    public class PersonaLDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaLDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaL personaL)
        {
            _appDbContext.Add(personaL);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaL personaL)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaL.Id);
            if (PersonaData != null)
            {
                PersonaData.NombreL = personaL.NombreL;
                PersonaData.ApellidoL = personaL.ApellidoL;
                PersonaData.FechaNacimientoL = personaL.FechaNacimientoL;
                PersonaData.NombreL = personaL.NombreL;
                PersonaData.StatusL = personaL.StatusL;
                _appDbContext.Update(PersonaData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaL personaL)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaL.Id);
            if (PersonaData != null)
                _appDbContext.Remove(PersonaData);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaL> ObtenerPoId(PersonaL personaL)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaL.Id);
            if (PersonaData != null)
                return PersonaData;
            else
                return new PersonaL();
        }
        public async Task<List<PersonaL>> ObtenerTodos()
        {
            return await _appDbContext.Persona.ToListAsync();
        }
        public async Task<List<PersonaL>> Buscar(PersonaL personaL)
        {
            var query = _appDbContext.Persona.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaL.NombreL))
            {
                query = query.Where(s => s.NombreL.Contains(personaL.NombreL));
            }
            if (!string.IsNullOrWhiteSpace(personaL.ApellidoL))
            {
                query = query.Where(s => s.NombreL.Contains(personaL.ApellidoL));
            }
            return await query.ToListAsync();
        }
    }
}
