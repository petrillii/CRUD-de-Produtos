using LojaJet.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.Models.Contexts
{
    public class LojaJetContext : DbContext
    {
        #region Base
        public LojaJetContext(DbContextOptions<LojaJetContext> options) : base(options)
        {
        }

        public void AddEntity(object entity)
        {
            base.Add(entity);
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        #region DbSets
        public virtual DbSet<ProductEntity> product { get; set; }

        #endregion

    
    }
}
