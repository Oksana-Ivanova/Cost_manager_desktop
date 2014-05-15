using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class User
    {
        private string _Id;
        private string _Name;
        private string _Email;
        private string _Pasword;
        private uint   _SignInCount;

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
        public string Email
        {
            set { _Email = value; }
            get { return _Email; }
        }
        public string Pasword
        {
            set { _Pasword = value; }
            get { return _Pasword; }
        }
        public uint SignInCount
        {
            set { _SignInCount = value; }
            get { return _SignInCount; }
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

        public User(string id,
                    string name,
                    string email,
                    string pasword,
                    uint signInCount,
                    DateTime createdAt,
                    DateTime updatedAt)
        {
            _Id = id;
            _Name = name;
            _Email = email;
            _Pasword = pasword;
            _SignInCount = signInCount;
            _CreateDate = createdAt;
            _UpdateDate = updatedAt;
        }

        public User()
        {
            _Id = SequenceGenerator.GenerateUniqueString();
            _Name = "";
            _Email = "";
            _Pasword = "";
            _SignInCount = 0;
            _CreateDate = DateTime.Now;
            _UpdateDate = DateTime.Now;
        }

    }
}