using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    class Limit
    {
        private string _Id;
        private string _CostTypeId;

        private string _Name;
        private double _Value;

        private DateTime _CreateDate;
        private DateTime _UpdateDate;

        public string Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string CostTypeId
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

        public Limit(string id,
                    string costTypeId,
                    string name,
                    string description,
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
