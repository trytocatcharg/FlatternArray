using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatten.Array
{
    public class ArrayTransform
    {

        private List<object> _finalArray;
        public List<object> FinalArray { get => _finalArray;
                                        set => _finalArray = value; }

        public ArrayTransform()
        {
            _finalArray = new List<object>();
        }
        public void SolveArray(object[] array)
        {
            foreach (var item in array)
            {
                if (item is object[])
                {
                    SolveArray((object[])item);
                }
                else
                {
                    if (item is Int32)
                        _finalArray.Add(item);
                    else
                        throw new Exception("invalid number");
                }
            }
        }
    }
}
