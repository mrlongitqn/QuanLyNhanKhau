using System.Data.Entity;
using System.Transactions;
using QLNK.EF;

namespace QLNK.Repositories.Interfaces
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _transaction;
        private readonly QLNhanKhau_DBEntities _db;


        public UnitOfWork()
        {
            _db = new QLNhanKhau_DBEntities();

        }

        public void Dispose()
        {

        }

        public void StartTransaction()
        {

            _transaction = new TransactionScope();

        }

        public void Commit()
        {
            _db.SaveChanges();
            _transaction.Complete();
        }

        public DbContext Db => _db;
    }
}
