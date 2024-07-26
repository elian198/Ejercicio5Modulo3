

using Ejercicio5Modulo3.Models.Entity;
using Ejercicio5Modulo3.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;
using System.Security;

public class UsuarioService : IUsuarioService
{

    private Ejercicio5Modulo3Context _context;

    public UsuarioService(Ejercicio5Modulo3Context context)
    {
        _context = context;
    }

    public async Task<List<Usuario>> findByFilter(Parameters parameters)
    {
       
        if (parameters.Id > 0 && parameters.Nombre != null)  
          return  await _context.Usuario.Where(usuario => usuario.Id == parameters.Id && usuario.Nombre.Contains(parameters.Nombre)).ToListAsync();
       
       return await _context.Usuario.ToListAsync();
        
      
    }

    public async Task<bool> CargarEnBaseDeDatos(List<Results> results)
    {
        if (_context.Usuario.Count() > 0) throw new ExistDataException("Ya existen datos en la base de datos!!!");
        var usuarios = CrearUsuarios(results);
        await _context.Usuario.AddRangeAsync(usuarios);
        _context.SaveChanges();
        return true;
    }

    private List<Usuario> CrearUsuarios(List<Results> results) 
    {
        List<Usuario> usuarios = new List<Usuario>();
        foreach (Results datos in results)
        {
            usuarios.Add(
                new Usuario(
                    datos.Name.First, datos.Name.Last, datos.Dob.Age,
                    datos.gender, datos.Email, datos.Login.UserName, datos.Login.Password,
                    datos.Location.City, datos.Location.State,datos.Location.Country)
                );
        }

        return usuarios;
    }

}