// Эксперименты ПР №5: пробы, трассировка, проверки пустой гильдии и дополнительная часть.

public static class Experiments {
    public static void Run() {
        Console.WriteLine("##### ПР №5: эксперименты #####");
        AddRepeatRemove();
        CopyNotOriginal();
        Trace();
        EmptyGuild();
        ExtraSelectHealthy();
        ExtraRuleBoundaries();
    }

    private static void Header(string text) {
        Console.WriteLine();
        Console.WriteLine($"--- {text} ---");
    }

    // Этап 7: приём, повтор и удаление
    private static void AddRepeatRemove() {
        Header("Этап 7: приём, повтор и удаление");

        Guild probeGuild = new Guild("Учебная гильдия");
        Hero probeWarrior = new Hero("Учебный воин", 150);
        Hero probeTwin = new Hero(" учебный ВОИН ", 120);

        Console.WriteLine($"Первый: {probeGuild.AddHero(probeWarrior)}");
        Console.WriteLine($"Тот же объект: {probeGuild.AddHero(probeWarrior)}");
        Console.WriteLine($"Другой объект, то же имя: {probeGuild.AddHero(probeTwin)}");
        Console.WriteLine($"Участников: {probeGuild.MemberCount}");

        Console.WriteLine($"Удалён: {probeGuild.RemoveHero("учебный воин")}");
        Console.WriteLine($"Участников: {probeGuild.MemberCount}");
        Console.WriteLine($"Объект жив: {probeWarrior.Name}, {probeWarrior.Health}");
    }

    // Этап 8: наружу выдаётся копия
    private static void CopyNotOriginal() {
        Header("Этап 8: копия списка");

        Guild probeGuild = new Guild("Учебная гильдия");
        probeGuild.AddHero(new Hero("Учебный воин", 150));
        probeGuild.AddHero(new Hero("Учебный маг", 90));

        List<Hero> copy = probeGuild.GetMembers();
        copy.Clear();
        Console.WriteLine($"В копии: {copy.Count}");
        Console.WriteLine($"В гильдии: {probeGuild.MemberCount}");

        List<Hero> again = probeGuild.GetMembers();
        again[0].TakeDamage(50);
        Hero? warrior = probeGuild.FindHeroByName("Учебный воин");
        if (warrior != null) {
            Console.WriteLine($"Здоровье воина в гильдии: {warrior.Health}");
        }
    }

    // Этап 9: трассировка
    private static void Trace() {
        Header("Этап 9: трассировка");

        Guild traceGuild = new Guild("Трассировка");
        Hero first = new Hero("Первый", 100);
        Hero second = new Hero("Второй", 80);

        Console.WriteLine(traceGuild.AddHero(first));
        Console.WriteLine(traceGuild.AddHero(new Hero(" пЕРВЫЙ ", 50)));
        Console.WriteLine(traceGuild.AddHero(second));

        List<Hero> snapshot = traceGuild.GetMembers();
        Console.WriteLine(traceGuild.RemoveHero("первый"));

        Console.WriteLine(traceGuild.MemberCount);
        Console.WriteLine(snapshot.Count);

        Hero? found = traceGuild.FindHeroByName("Первый");
        Console.WriteLine(found == null);
    }

    // Этап 11: пустая гильдия
    private static void EmptyGuild() {
        Header("Этап 11: пустая гильдия");

        Guild emptyGuild = new Guild("Пустая учебная гильдия");
        Console.WriteLine($"FindStrongest() == null: {emptyGuild.FindStrongest() == null}");
        Console.WriteLine($"CountHealthy(0): {emptyGuild.CountHealthy(0)}");
    }

    // Д.1: подборка, а не число
    private static void ExtraSelectHealthy() {
        Header("Д.1: подборка SelectHealthy");

        Guild guild = new Guild("Гильдия героев");
        guild.AddHero(new Hero("Ярослав", 100));
        guild.AddHero(new Hero("Анастасия", 90));
        guild.AddHero(new Hero("Артём", 120));
        guild.AddHero(new Hero("Александр", 150));
        guild.AddHero(new Hero("Сергей", 110));

        List<Hero> selection = guild.SelectHealthy(120);
        Console.WriteLine($"В подборке (порог 120): {selection.Count}");
        foreach (Hero hero in selection) {
            Console.WriteLine(hero.Name);
        }

        selection.RemoveAt(0);
        Console.WriteLine($"После удаления из подборки: подборка {selection.Count}, MemberCount {guild.MemberCount}");
    }

    // Д.2: где граница правила
    private static void ExtraRuleBoundaries() {
        Header("Д.2: границы правила");

        Guild guild = new Guild("Гильдия героев");
        guild.AddHero(new Hero("Артём", 120));

        Console.WriteLine($"«Артем» через «е» при «Артём»: {guild.AddHero(new Hero("Артем", 100))}");

        Hero nameless = new Hero("", 100);
        Console.WriteLine($"Имя героя с пустым именем: {nameless.Name}");
        Console.WriteLine($"Первый безымянный принят: {guild.AddHero(nameless)}");
        Console.WriteLine($"Второй безымянный принят: {guild.AddHero(new Hero("", 100))}");

        Hero? blank = guild.FindHeroByName("   ");
        Console.WriteLine($"FindHeroByName(\"   \") == null: {blank == null}");
    }
}
