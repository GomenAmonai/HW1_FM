namespace FirstHWFabricMethod;

internal class Program
{
    static void Main(string[] args)
    {
        // Статический фабричный метод для гоблинов
        Goblin goblin = Goblin.CreateRandomGoblin();

        // Экземплярный фабричный метод для крыс
        LogovoKrys logovoKrys = new LogovoKrys(50, 50);
        Rat rat = logovoKrys.CreateRat();

        // Виртуальный фабричный метод для логов
        ILogovo logovoVolkov = new LogovoVolkov();
        Monster wolf = logovoVolkov.CreateMonster();
        wolf.Roar();

        ILogovo logovoTigrov = new LogovoTigrov();
        Monster tiger = logovoTigrov.CreateMonster();
        tiger.Roar();

        ILogovo logovoMedvedey = new LogovoMedvedey();
        Monster bear = logovoMedvedey.CreateMonster();
        bear.Roar();
    }
}