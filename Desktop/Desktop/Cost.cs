﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class Cost
    {
        private string _Id;
        private int    _UserId;
        private string _CostTypeId;

        private string _Name;
        private string _Description;
        private double _Price = 0.0;

        private DateTime _CreateDate;
        private DateTime _UpdateDate;

        public string Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public int UserId
        {
            set { _UserId = value; }
            get { return _UserId; }
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
        public string Description
        {
            set { _Description = value; }
            get { return _Description; }
        }
        public double Price
        {
            set { _Price = value; }
            get { return _Price; }
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

        public Cost(string id,
                    int    userId,
                    string costTypeId,
                    string name,
                    string description,
                    double price,
                    DateTime createdAt,
                    DateTime updatedAt)
        {
            _Id             = id;
            _UserId         = userId;
            _CostTypeId     = costTypeId;
            _Name           = name;
            _Description    = description;
            _Price          = price;
            _CreateDate     = createdAt;
            _UpdateDate     = updatedAt;
        }

        public Cost()
        {
            _Id             = SequenceGenerator.GenerateUniqueString();
            _UserId         = 0;
            _CostTypeId     = "";
            _Name           = "";
            _Description    = "";
            _Price          = 0.0;
            _CreateDate     = DateTime.Now;
            _UpdateDate     = DateTime.Now;
        }                    

    }
}
