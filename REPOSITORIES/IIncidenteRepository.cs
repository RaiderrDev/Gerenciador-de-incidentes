public interface IRepositoryPersistencia<T>
{
    Task<List<T>> ListarTudo();
    Task<T> Buscar(int id);
    Task Atualizar(T objeto, Status status);
    Task Salvar(T objeto);
    Task Deletar(T objeto);
}