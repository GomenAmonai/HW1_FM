namespace FirstHWFabricMethod;

public class LogovoTigrov : ILogovo
{
    public Monster CreateMonster()
    {
        return new Tiger();
    }
}