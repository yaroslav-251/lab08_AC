// int lessonNumber = 5; //номер занятия
// int TotalLessons = 1; //всего занятий

// while (lessonNumber >= TotalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber = lessonNumber -1;
// }
// Console.WriteLine("Пары закончились");
// int count = 0;
// Console.WriteLine("Вводите оценки по одной, для завершения введите -1");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     count++;
// }
// Console.WriteLine("Ввод завершен");
// Console.WriteLine(count);

// int m = 0;
// int sum = 0;
// int count = 0;
// Console.WriteLine("Вводите оценки, для завершения введите -1");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1)
// {
//     if (grade > m)
//     {
//         m = grade;
//     }
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());

// }
// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }
// Console.WriteLine(m);
// int c = 0;
// string correctPassword = "qwerty123";
// while (true)
// {
//     Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();
//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешен");
//         break;
//     }
//     Console.WriteLine("Неверный пароль, попробуйте снова");
//     c++;
// }
// Console.WriteLine(c);
// string answer;
// do
// {
//     Console.WriteLine("Введите дату посещения (например 01.09)");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");
//     Console.Write("Добавить еще одну запись? (да/нет)");
//     answer = Console.ReadLine();
// } while (answer == "да");
// Console.WriteLine("Дневник сохранен");

//задача А
// int i = 0;
// int N = int.Parse(Console.ReadLine());
// while (i <= N+1)
// {
//     Console.WriteLine($"{i} * {N} = {i * N}");
//     i++;
// }
//Задача Б
// int d = 0;
// string name = Console.ReadLine();
// while (name != "конец")
// {
//     d++;
//     name = Console.ReadLine();
// }
// Console.WriteLine(d);
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
//Вариант 1
// int N = int.Parse(Console.ReadLine());
// while (N >= 1)
// {
//     Console.WriteLine(N);
//     N = N - 1;
// }
// Console.WriteLine("Старт!");
//Вариант 6
int count = 0;
int s = int.Parse(Console.ReadLine());
while (s != 0)
{
    s = s / 10;
    count++;
}
Console.WriteLine(count);