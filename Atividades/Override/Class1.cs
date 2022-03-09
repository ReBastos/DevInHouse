using System;

public class Animal
{
	public virtual string Hello()
    {
        return "Hello!";
    }
}

public class Gato : Animal
{
    public override string Hello()
    {
        return "Miau";
    }
}

public class Cachorro : Animal
{
    public override string Hello()
    {
        return "Au Au";
    }
}