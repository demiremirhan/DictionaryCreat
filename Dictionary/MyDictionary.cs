using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Dictionary
{
    class MyDictionary <T1 ,T2>
    {
        T1[] _keys;
        T2[] _values;
        T1[] _tempkeys;
        T2[] _tempvalues;

        public MyDictionary()
        {
            _keys = new T1[0];
            _values = new T2[0];

        }

        public void Add(T1 _key, T2 _value)
        {
            _tempkeys = _keys;
            _tempvalues = _values;
            _keys = new T1[_keys.Length + 1];
            _values = new T2[_values.Length + 1];
            for (int i = 0; i < _tempkeys.Length; i++)
            {
                _keys[i] = _tempkeys[i];
            }

            for (int i = 0; i < _tempvalues.Length; i++)
            {
                _values[i] = _tempvalues[i];

            }

        }

        public int Count
        {
            get
            {
                return _keys.Length;

            }
        }
    }
}
