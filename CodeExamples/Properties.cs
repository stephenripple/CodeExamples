using System;

public class Properties
{
    //Basic example of using properties to provide accessibility
    private string _privatevariable;
    public string PublicVariable
    {
        get
        {
            return _privatevariable;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Variable cannot be blank.", "PublicVariable");
            _privatevariable = value;
        }
    }

    //Build in and enforce multi threading
    private object _syncHandle = new object();
    private string _syncvariable;
    public string SyncVariable
    {
        get
        {
            lock (_syncHandle)
                return _syncvariable;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("SyncVariable cannot be blank.", "SyncVariable");
            lock (_syncHandle)
                _syncvariable = value;
        }
    }

    //Virtual property
    public virtual string VirtualVariable
    {
        get;
        protected set;
    }

    //Indexer 
    private int[] _intarray = new int[] { 0, 1, 2, 3 };
    public int this[int index]
    {
        get
        {
            return _intarray[index];
        }
        set
        {
            _intarray[index] = value;
        }
    }

	public Properties()
	{
	}
}

//Virtual property on interface
public interface IProprtyValuePair<T>
{
    string Variable
    { get; }

    T Value
    { get; set; }
}
