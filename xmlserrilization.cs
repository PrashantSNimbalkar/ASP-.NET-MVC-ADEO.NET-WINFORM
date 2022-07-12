using System;
using System.IO;

namespace SampleWinform
{
    internal class xmlSerilization
    {
        private Type type;

        public xmlSerilization(Type type)
        {
            this.type = type;
        }

        internal void Serialize(FileStream fs, Product prod)
        {
            throw new NotImplementedException();
        }

        internal Product Deserialize(FileStream fs)
        {
            throw new NotImplementedException();
        }
    }
}