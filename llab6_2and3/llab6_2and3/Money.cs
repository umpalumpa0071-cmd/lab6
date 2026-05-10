public class Money
{
    private uint _rubles;
    private byte _kopeks;

    public Money() : this(0, 0) { }

    public Money(uint rubles, byte kopeks)
    {
        this._rubles = rubles;
        this._kopeks = (byte)(kopeks % 100);
        this._rubles += (uint)(kopeks / 100);
    }

    public Money(Money other)
    {
        _rubles = other._rubles;
        _kopeks = other._kopeks;
    }

    public uint Rubles
    {
        get 
        {
            return _rubles; 
        }
        set 
        {
            _rubles = value; 
        }
    }

    public byte Kopeks
    {
        get 
        {
            return _kopeks; 
        }
        set 
        {
            _kopeks = (byte)(value % 100); 
        }
    }

    
    public Money AddKopeks(uint k)
    {
        uint total = _rubles * 100 + _kopeks + k;
        return new Money(total / 100, (byte)(total % 100));
    }

    public override string ToString()
    {
        return $"{_rubles} руб. {_kopeks} коп.";
    }

   

    public static Money operator ++(Money m)
    {
        return m.AddKopeks(1);
    }

    public static Money operator --(Money m)
    {
        uint total = m.Rubles * 100 + m.Kopeks;

        if (total > 0)
            total--;

        return new Money(total / 100, (byte)(total % 100));
    }

   

    public static explicit operator uint(Money m)
    {
        return m.Rubles;
    }

    public static implicit operator double(Money m)
    {
        return m.Kopeks / 100.0;
    }

    

    public static Money operator +(Money m, uint k)
    {
        return m.AddKopeks(k);
    }

    public static Money operator +(uint k, Money m)
    {
        return m.AddKopeks(k);
    }

    public static Money operator -(Money m, uint k)
    {
        uint total = m.Rubles * 100 + m.Kopeks;

        if (k > total)
            total = 0;
        else
            total -= k;

        return new Money(total / 100, (byte)(total % 100));
    }

    public static Money operator -(uint k, Money m)
    {
        uint total = m.Rubles * 100 + m.Kopeks;

        if (k < total)
            total = 0;
        else
            total = k - total;

        return new Money(total / 100, (byte)(total % 100));
    }
}