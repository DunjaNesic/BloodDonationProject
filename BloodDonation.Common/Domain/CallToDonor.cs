﻿using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Domain
{
    [Serializable]
    public class CallToDonor : IEntity
    {
        public string JMBG { get; set; }
        public int ActionID { get; set; }

        public string TableName => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string SelectValues => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string IDName => throw new NotImplementedException();

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
