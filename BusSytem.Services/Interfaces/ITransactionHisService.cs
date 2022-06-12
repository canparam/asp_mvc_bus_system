using BusSystem.Entity;
using BusSystem.Model.Transacion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface ITransactionHisService
    {
        TransactionHis GetById(int id);
        Task<TransactionHis> GetByIdAsync(int id);
        Task<TransactionHis> CreateTransaction(TransactionHis entity);

        List<TranserHisViewModel> ListTransHis(int pageIndex, int pageSize, int? type, int? status, string username);
        Task<List<TranserHisViewModel>> ListTranHistByUser(int pageIndex, int pageSize);

        Task<int> GetTotalTransaction();

        decimal GetSumTotal();

    }
}
