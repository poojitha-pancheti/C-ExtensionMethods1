using System;
using System.Collections.Generic;
using System.Text;

namespace ExxtensionMethods.Library
{
    public class Target
    {
        private string _id;
        protected string Id
        {
            get { return _id; }
            set { _id = value.Trim(); }
        }
        public string GetId()
        {
            return _id;
        }
        public string GetStandardizeId()
        {
            return _id.ToLower();
        }
        public Target(string id)
        {
            _id = id;
        }
    }
    internal class InternalTarget
    {
        protected class ProtectedStatusClass
        { }
    }
}
