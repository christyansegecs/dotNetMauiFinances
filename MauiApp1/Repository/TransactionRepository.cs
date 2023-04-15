using AppMauiFinances.Models;
using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMauiFinances.Repository
{
    internal class TransactionRepository : ITransactionRepository
    {
        private readonly LiteDatabase _liteDatabase;
        private readonly string collectionName = "transactions";
        public TransactionRepository(LiteDatabase database)
        {
            _liteDatabase = database;
        }

        public List<Transaction> GetAllTransactions() {
            return _liteDatabase.GetCollection<Transaction>(collectionName).
                Query().
                OrderByDescending(a=>a.Date).
                ToList();
        }

        public void Add(Transaction transaction) {
            var collection = _liteDatabase
                .GetCollection<Transaction>(collectionName);
            collection.Insert(transaction);
            collection.EnsureIndex(a => a.Date);
        }

        public void Delete(Transaction transaction) {

            var collection = _liteDatabase
                    .GetCollection<Transaction>(collectionName);
            collection.Delete(transaction.Id);
        }

        public void Update(Transaction transaction) {

            var collection = _liteDatabase
                    .GetCollection<Transaction>(collectionName);
            collection.Update(transaction);
        }
    }
}
