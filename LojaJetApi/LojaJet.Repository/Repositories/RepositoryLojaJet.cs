using LojaJet.Models.Contexts;
using SquadHealthCheck.Repository.Infra.Repositories.Interfaces;

namespace RepositoryLojaJet.Repository.Repositories
{
    /// <summary>
    /// Metodo usado para herança somente de entidades no banco e não para entidades compostas
    /// </summary>
    /// <typeparam name="TEntity">Entidade generica representando uma tabela no banco</typeparam>
    public class RepositoryLojaJet<TEntity> : IRepositoryLojaJet<TEntity> where TEntity : class
    {
        protected readonly LojaJetContext _ctx;
        /// <summary>
        /// Utilizado somente para Injeção de Dependência.
        /// </summary>
        /// <param name="ctx">Contexto de conexão do banco gerenciado somente pela Injeção de Dependência.</param>
        public RepositoryLojaJet(LojaJetContext ctx)
        {
            _ctx = ctx;
        }

        #region Metodos genericos para PortalDb

        /// <summary>
        /// Adiciona a entidade.
        /// </summary>
        /// <param name="entidade">Entidade relacionada a tabela.</param>
        /// <returns>Numero de linhas afetadas</returns>
        public async Task<int> Create(TEntity entidade)
        {
            _ctx.Set<TEntity>().Add(entidade);
            return await _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Obtem entidade pelo Id Chave primária da tabela.
        /// </summary>
        /// <param name="id">Chave primária ID.</param>
        /// <returns>Entidade correspondente.</returns>
        public async Task<TEntity> GetById(int id)
        {
            return await Task.Run(() => _ctx.Set<TEntity>().Find(id));
        }


        /// <summary>
        /// Atualiza entidade no banco.
        /// </summary>
        /// <param name="entidade">Entidade a ser atualizada, necessário ter o ID primário preenchido.</param>
        /// <returns>Número de linhas afetadas no banco.</returns>
        public async Task<int> Update(TEntity entidade)
        {
            _ctx.Set<TEntity>().Update(entidade);
            return await _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Remove entidade no banco.
        /// </summary>
        /// <param name="entidade">Entidade a ser removida do banco, necessário ter o ID primário preenchido.</param>
        /// <returns>Número de linhas afetadas no banco.</returns>
        public async Task<int> Delete(TEntity entidade)
        {
            _ctx.Set<TEntity>().Remove(entidade);
            return await _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Obtem todas as entidades do banco, ATENÇÃO: não utilize esse método para tabelas de regras de negócio, somente para tabelas de domínio.
        /// </summary>
        /// <returns>Todas as entidades da tabela do banco.</returns>
        public async Task<List<TEntity>> GetAll()
        {
            return await Task.Run(() => _ctx.Set<TEntity>().ToList());
        }
        #endregion
    }
}
