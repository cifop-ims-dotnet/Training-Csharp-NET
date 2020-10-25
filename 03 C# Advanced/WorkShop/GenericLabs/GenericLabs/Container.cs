using System;
namespace GenericLabs
{
    //public class Container<T,V>
    //    where T : Person, IWorker, new()
    //    where V : new()

    public class Container<T, V>
       where T : Person, IWorker, new()
    {
        private T _value;
        //private V _valueV;
        public Container(T value)
        {
            _value = new T();

        }
    }

    public class ContainerInt
    {
        private int _value;
        public ContainerInt(int t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }
    }

    public class ContainerString
    {
        private string _value;
        public ContainerString(string t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }
    }

    public class ContainerDatetime
    {
        private DateTime _value;
        public ContainerDatetime(DateTime t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }
    }
}
