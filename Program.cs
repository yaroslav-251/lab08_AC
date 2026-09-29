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


