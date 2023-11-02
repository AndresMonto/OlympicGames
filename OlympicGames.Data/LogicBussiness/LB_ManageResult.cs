using OlympicGames.Data.Models;

namespace OlympicGames.Data.LogicBussiness
{
    public class LB_ManageResult<T> where T : ModelBase
    {
        private readonly DbContextOlympicGames DbContext;

        public LB_ManageResult(DbContextOlympicGames DbContext)
        {
            this.DbContext = DbContext;
        }

        private ResultBase<ResultHalterofilia> GetData()
        {
            return this.DbContext.ResultHalterofilia.GetAllData();
        }

        public ResultBase<ResultHalterofilia> GetOrderedData()
        {
            return this.DbContext.ResultHalterofilia.GetAllData(Resource.GetOrderedData);
        }

        public ResultBase<ResultHalterofilia> InsertData(ResultHalterofilia entity)
        {
            return this.DbContext.ResultHalterofilia.InsertData(DbContext, entity);
        }

        public ResultBase<ResultHalterofilia> InsertMultipleData(List<ResultHalterofilia> entity)
        {
            return this.DbContext.ResultHalterofilia.InsertData(DbContext, entity);
        }


    }
}
