// int lessonNumber = 5; //номер занятия
// int TotalLessons = 1; //всего занятий

// while (lessonNumber >= TotalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber = lessonNumber -1;
// }
// Console.WriteLine("Пары закончились");
int count = 0;
Console.WriteLine("Вводите оценки по одной, для завершения введите -1");
int grade = int.Parse(Console.ReadLine());
while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    count++;
}
Console.WriteLine("Ввод завершен");
Console.WriteLine(count);

