namespace FirstHWFabricMethod;

public class LogovoVolkov : ILogovo
{
    public Monster CreateMonster()
    {
        return new Wolf();
    }
}