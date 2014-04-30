using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_project
{
    class Limit
    {
        private uint _Id;
        private uint _CostTypeId;

        private string _Name;
        private double _Value;

        private DateTime _CreateDate;
        private DateTime _UpdateDate;

        public uint Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public uint CostTypeId
        {
            set { _CostTypeId = value; }
            get { return _CostTypeId; }
        }

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public double Value
        {
            set { _Value = value; }
            get { return _Value; }
        }

        public DateTime CreateDate
        {
            set { _CreateDate = value; }
            get { return _CreateDate; }
        }
        public DateTime UpdateDate
        {
            set { _UpdateDate = value; }
            get { return _UpdateDate; }
        }

        public Limit(uint id,
                    uint userId,
                    uint costTypeId,
                    string name,
                    string description,
                    double price,
                    DateTime createdAt,
                    DateTime updatedAt)
        {
            _Id             = id;
            _CostTypeId     = costTypeId;
            _Name           = name;
            _CreateDate     = createdAt;
            _UpdateDate     = updatedAt;
        }  
    }
}
