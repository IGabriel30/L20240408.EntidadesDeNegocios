using L20240408.AccesoADatos;
using L20240408.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20240408.LogicaDeNegocios
{
    public class PersonaLBL
    {
        readonly PersonaLDAL _personaDAL;

        public PersonaLBL(PersonaLDAL personaDAL)
        {
            _personaDAL = personaDAL;
        }
        public async Task<int> Crear(PersonaL personaL)
        {
            return await _personaDAL.Crear(personaL);
        }
        public async Task<int> Modificar(PersonaL personaL)
        {
            return await _personaDAL.Modificar(personaL);
        }
        public async Task<int> Eliminar(PersonaL personaL)
        {
            return await _personaDAL.Eliminar(personaL);
        }
        public async Task<PersonaL> ObtenerPoId(PersonaL personaL)
        {
            return await _personaDAL.ObtenerPoId(personaL);
        }
        public async Task<List<PersonaL>> ObtenerTodos()
        {
            return await _personaDAL.ObtenerTodos();
        }
        public async Task<List<PersonaL>> Buscar(PersonaL personaL)
        {
            return await _personaDAL.Buscar(personaL);
        }
    }
}
