

using Ejercicio5Modulo3.Models.Entity;

public interface IUsuarioService
{
    public Task<List<Usuario>> findByFilter(Parameters parameters );
    public Task<bool> CargarEnBaseDeDatos(List<Results> results);
}