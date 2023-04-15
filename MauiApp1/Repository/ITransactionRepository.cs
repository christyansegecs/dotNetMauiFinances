using AppMauiFinances.Models;

namespace AppMauiFinances.Repository
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        void Delete(Transaction transaction);
        List<Transaction> GetAllTransactions();
        void Update(Transaction transaction);
    }
}