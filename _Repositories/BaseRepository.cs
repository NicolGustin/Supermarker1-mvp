using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarker_mvp.Model;
using System.Data;

  namespace Supermarker_mvp._Repositories
{
	internal class payModeRepository: BaseReporitory, IPayModeRepository
    {
		public PayModeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PayModeModel payModeModel)
		{
			throw new NotImplementedException();
		}

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void IEnumerable<PayModeModel> GetAll()
        {
            // throw new NotImplementedException();
            var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PayMode 
                                        WHERE Pay_Mode_Id=@id or Pay_Mode_Name  like     @name+ '%'
                                        ORDER BY Pay_Mode_Id DESC";
                command.Parameters.Add("@id",SqlDbType.Int).Value = payModeId;
                command.Parameters.Add("@name",SqlDbType.NVarChar).Value = payModeName;
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read()) 
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeModel.Add(payModeModel);
                    }
                }
            }
            return payModeList;
        }
    }
}
