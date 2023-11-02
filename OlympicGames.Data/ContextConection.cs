using Microsoft.EntityFrameworkCore;
using OlympicGames.Data.LogicBussiness;
using OlympicGames.Data.Models;

namespace OlympicGames.Data
{
    public static class ContextConection
    {
        public static ResultBase<T> GetAllData<T>(this DbSet<T> table) where T : ModelBase
        {
            ResultBase<T> data = new();
            try
            {
                data.ResultList = table.ToList();
            }
            catch (Exception ex)
            {
                data.StatusBase.Error = true;
                data.StatusBase.Message = ex.Message;
            }

            return data;
        }

        public static ResultBase<T> GetAllData<T>(this DbSet<T> table, string spName) where T : ModelBase
        {
            ResultBase<T> data = new();
            try
            {
                data.ResultList = table.FromSqlRaw($"CALL {spName};").ToList();
            }
            catch (Exception ex)
            {
                data.StatusBase.Error = true;
                data.StatusBase.Message = ex.Message;
            }

            return data;
        }

        public static ResultBase<T> InsertData<T>(this DbSet<T> table, DbContextOlympicGames dbContext, T entity) where T : ModelBase
        {
            ResultBase<T> data = new();
            try
            {
                data.Result = table.Add(entity).Entity;
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                data.StatusBase.Error = true;
                data.StatusBase.Message = ex.Message;
            }

            return data;
        }

        public static ResultBase<T> InsertData<T>(this DbSet<T> table, DbContextOlympicGames dbContext, List<T> entity) where T : ModelBase
        {
            ResultBase<T> data = new();
            try
            {
                table.AddRange(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                data.StatusBase.Error = true;
                data.StatusBase.Message = ex.Message;
            }

            return data;
        }

    }
}