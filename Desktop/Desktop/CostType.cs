using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    class CostType
    {
        private string _Id;

        private string _Name;

        private DateTime _CreateDate;
        private DateTime _UpdateDate;

        public string Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
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

        public CostType(string id,
                        string name,
                        DateTime createdAt,
                        DateTime updatedAt)
        {
            _Id             = id;
            _Name           = name;
            
            _CreateDate     = createdAt;
            _UpdateDate     = updatedAt;
        }

        public CostType()
        {
            _Id = "";
            _Name = "";

            _CreateDate = DateTime.Today;
            _UpdateDate = DateTime.Today;
        }  

    }
}
