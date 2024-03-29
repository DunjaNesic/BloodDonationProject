﻿using BloodDonation.Repository.DBConnection;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Repository.Implementation
{
    public class GenericDbRepository : IDbRepository<IEntity>
    {
        private SqlCommand CreateSqlCommand(string query)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand();
            cmd.CommandText = query;
            return cmd;
        }
        public void Add(IEntity entity)
        {             
            using (SqlCommand cmd = CreateSqlCommand($"INSERT INTO {entity.TableName} OUTPUT inserted.{entity.IDName} VALUES ({entity.InsertValues})"))
            {
                if (!string.IsNullOrEmpty(entity.IDName))
                {
                    object primaryKeyValue = cmd.ExecuteScalar();
                    entity.GetType().GetProperty(entity.IDName).SetValue(entity, primaryKeyValue);
                }
                else
                {
                    int affectedRows = cmd.ExecuteNonQuery();
                    Console.WriteLine("Affected rows insert: " + affectedRows);
                }
            }
        }

        public void Update(IEntity entity, string condition)
        {
            using (SqlCommand cmd = CreateSqlCommand($"UPDATE {entity.TableName} SET {entity.UpdateValues} WHERE {condition}"))
            {
                if (cmd.ExecuteNonQuery() != 1) throw new Exception("Greška pri ažuriranju baze");
            }
        }
        public void Delete(IEntity entity, string condition)
        {
            using (SqlCommand cmd = CreateSqlCommand($"DELETE FROM {entity.TableName} WHERE {condition}"))
            {
                if (cmd.ExecuteNonQuery() != 1) throw new Exception("Greška pri brisanju iz baze");
            }
        }

        private List<IEntity> ExecuteSelectQuery(IEntity entity, string condition)
        {
            using (SqlCommand cmd = CreateSqlCommand($"SELECT {entity.SelectValues} FROM {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} WHERE {condition}"))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return entity.GetReaderList(reader);
            }
        }
        public List<IEntity> Find(IEntity entity, string condition)
        {
            return ExecuteSelectQuery(entity, condition);
        }
        public IEntity Get(IEntity entity, string condition)
        {
            List<IEntity> result = ExecuteSelectQuery(entity, condition);
            return result.FirstOrDefault();
        }
        public List<IEntity> GetAll(IEntity entity)
        {
            string condition = "1=1";
            return ExecuteSelectQuery(entity, condition);
        }
        public void CloseConnection()
        {
            DbConnectionFactory.Instance.GetDbConnection().CloseConnection();
        }
        public void BeginTransaction()
        {
            DbConnectionFactory.Instance.GetDbConnection().BeginTransaction();
        }
        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }
        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();  
        }
    }
}
