namespace FirstHWFabricMethod;

public class LogovoMedvedey : ILogovo
{
    public Monster CreateMonster()
    {
        return new Bear();
    }
}