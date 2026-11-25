Probe.Run();
Experiments.Run();

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);
// Hero sergey = new Hero("Сергей", 110);

// alexander.TakeDamage(10);
// alexander.Heal(10);

// Guild guild = new Guild("Гильдия героев");
// guild.AddHero(yaroslav);
// guild.AddHero(anastasia);
// guild.AddHero(artem);
// guild.AddHero(alexander);
// guild.AddHero(sergey);

// List<Hero> members = guild.GetMembers();

// Console.WriteLine($">>> {guild.Name}: перекличка <<<");
// Console.WriteLine($"Участников: {guild.MemberCount}");

// if (members.Count > 0) {
//     Console.WriteLine($"Первый: {members[0].Name}");
//     Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
// }

// Console.WriteLine();
// foreach (Hero hero in members) {
//     Console.WriteLine(hero.GetInfo());
//     Console.WriteLine();
// }

// Hero? found = guild.FindHeroByName(" аРтЁм ");
// if (found != null) {
//     Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
// } else {
//     Console.WriteLine("По запросу « аРтЁм » никого нет.");
// }

// Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
// Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
// Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

// Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

// Hero? strongest = guild.FindStrongest();
// if (strongest != null) {
//     Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
// }

// // ===== Личный проект: «Библиотека» (закрытый каталог) =====
// Console.WriteLine();
// Console.WriteLine("=== Личный проект: библиотека ===");

// Book warAndPeace = new Book("Война и мир", "Лев Толстой", 1225, 650);
// Book masterAndMargarita = new Book("  Мастер и Маргарита  ", "Михаил Булгаков", 480, 520);
// Book crimeAndPunishment = new Book("Преступление и наказание", "Фёдор Достоевский", 592, 380);
// Book twelveChairs = new Book("Двенадцать стульев", "Илья Ильф и Евгений Петров", 400, 310);

// Library library = new Library("Городская библиотека");
// Console.WriteLine($"Принята «Война и мир»: {library.AddBook(warAndPeace)}");
// Console.WriteLine($"Принята «Мастер и Маргарита»: {library.AddBook(masterAndMargarita)}");
// Console.WriteLine($"Принята «Преступление и наказание»: {library.AddBook(crimeAndPunishment)}");
// Console.WriteLine($"Принята «Двенадцать стульев»: {library.AddBook(twelveChairs)}");

// Book titleTwin = new Book(" вОйНа и МиР ", "Другой автор", 100, 100);
// Console.WriteLine($"Повтор той же книги принят: {library.AddBook(warAndPeace)}");
// Console.WriteLine($"Другой объект с тем же ключом принят: {library.AddBook(titleTwin)}");

// List<Book> books = library.GetBooks();
// Console.WriteLine($">>> {library.Name}: каталог <<<");
// Console.WriteLine($"Книг до удаления: {library.BookCount}");

// if (books.Count > 0) {
//     Console.WriteLine($"Первая: {books[0].Title}");
//     Console.WriteLine($"Последняя: {books[books.Count - 1].Title}");
// }

// Book? foundBook = library.FindBookByTitle("  мАСТЕР и маргарита ");
// if (foundBook != null) {
//     Console.WriteLine($"Найдена по запросу: {foundBook.Title}");
// } else {
//     Console.WriteLine("По запросу «мАСТЕР и маргарита» ничего нет.");
// }

// Book? missingBook = library.FindBookByTitle("Анна Каренина");
// if (missingBook != null) {
//     Console.WriteLine($"Найдена по запросу: {missingBook.Title}");
// } else {
//     Console.WriteLine("По запросу «Анна Каренина» ничего нет.");
// }

// Console.WriteLine($"Удалена «Двенадцать стульев»: {library.RemoveBook("двенадцать СТУЛЬЕВ")}");
// Console.WriteLine($"Удалена отсутствующая: {library.RemoveBook("Анна Каренина")}");
// Console.WriteLine($"Книг после удаления: {library.BookCount}");
// Console.WriteLine($"Книг дороже 500 руб.: {library.CountPricierThan(500)}");
