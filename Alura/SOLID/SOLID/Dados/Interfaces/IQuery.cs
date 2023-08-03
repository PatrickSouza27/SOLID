namespace SOLID.Dados.Interfaces
{
    public interface IQuery<T>
    {
        List<T> BuscarTodos();
        T BuscarPorId(int Id);
    }
}
