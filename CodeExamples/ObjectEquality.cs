using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeExamples
{
    public class ObjectEquality:IEnumerable<ObjectEquality>
    {
        public List<ObjectEquality> objects = null;
        public int id = 0;

        public ObjectEquality()
        {
            objects = new List<ObjectEquality>();
        }

        public ObjectEquality(int objectid)
        {
            objects = new List<ObjectEquality>();
            id = objectid;
        }

        public override bool Equals(object toCompObj)
        {
            if (toCompObj.GetType() != this.GetType())
                return false;

            if (((ObjectEquality)toCompObj).id == this.id)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        IEnumerator<ObjectEquality> IEnumerable<ObjectEquality>.GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
